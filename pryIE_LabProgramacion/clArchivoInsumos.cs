using System;
using System.Collections.Generic;
using System.IO;//Agregar para StreamWriter
using System.Data;
using System.Data.OleDb;//Agregar para conexion a BD Access
using System.Drawing;//Agregar para fuentes y colores
using System.Drawing.Printing;//Agregar para imprimir
using System.Linq;
using System.Text;
using System.Threading.Tasks;//Agregar para codificacion UTF8   
using System.Windows.Forms;//Agregar para ComboBox y DataGridView


namespace pryIE_LabProgramacion
{
    internal class clArchivoInsumos
    {
        //Que base de datos usar y donde esta el archivo
        //Si es con mdb: "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Clientes.mdb";
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventarioArticulos.accdb;";
        
       
        
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand comando = new OleDbCommand();
        OleDbDataAdapter adapter;
        private string TabArticulos = "Articulos";//Guarda en string el nombre de la tabla
        private string TabRubros = "Rubros";
        private string Rub = "";
        private int cant = 0;
        private decimal TotalStock = 0;

        public int CantArticulos { get { return cant; } }//Cantidad de articulos listados en la grilla
        public decimal TotalVStock { get { return TotalStock; } }


        //DataAdapter + DataSet: Memoria, recorre varias veces, modifica datos(GRILLA, CALCULOS, TOTALES)
        //DataReader: Trae datos de la BD, recorre 1 vez, no modifica datos (COMBOBOX, EXPORTAR)



        //CARGA DE COMBOBOX RUBROS
        public void CargarRubros(ComboBox cbRubros)
        {

            try
            {
                cbRubros.Items.Clear();
                
                //Asigna la cadena y abre la conexion(BD)
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                //Configura el comando
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;//TableDirect porque es con tabla
                comando.CommandText = TabRubros;//Tabla a utilizar 

                //DATA READER:Cada llamada a Read() avanza una fila y devuelve true. Cuando no hay más filas, false
                OleDbDataReader DR = comando.ExecuteReader();
               
                while (DR.Read())//Guarda en el cmb nombre de rubro
                {
                    //DR.GetInt32(n) o DR["nombre"]
                    cbRubros.Items.Add(DR.GetString(0));
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        //CARGA DE GRILLA-ARTICULOS : Filtra articulos por rubro y los muestra en la grilla
        public void ListarArticulos(DataGridView grilla, string rubro)
        {
            try
            {
                Rub = rubro;
                cant = 0;
                TotalStock = 0;
                grilla.Rows.Clear();

                
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;//Text porque es con instruccion SQL
                
                // Aclara que se quiere filtrar por rubro, sino trae todos los articulos
                comando.CommandText = "SELECT * FROM Articulos WHERE Rubro = '" + rubro + "'";

               
                //2: DataAdapter llena el DataSet y cerramos conexion
              
                adapter = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adapter.Fill(DS, TabArticulos);//Fill trae los datos y los guarda en DS.Tables
                conexion.Close();


                //3: Recorrer filas con foreach
                if (DS.Tables[TabArticulos].Rows.Count > 0)//Si hay datos cargados en articulos
                {
                    foreach (DataRow fila in DS.Tables[TabArticulos].Rows)//Recorre por cada fila sus columnas
                    {
                       
                        decimal costo = Convert.ToDecimal(fila["Costo"]);
                        int stock = Convert.ToInt32(fila["Stock"]);
                        decimal valstock = costo * stock;

                        //costo.ToString("C"); $1.500,50 (MONEDA)
                        grilla.Rows.Add(fila["Codigo"].ToString(), fila["Descripcion"].ToString(), costo.ToString("C"), stock, valstock.ToString("C"));
                        cant++;//Cantidad de articulos
                        TotalStock += valstock;//Stock total de articulos
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                // MessageBox.Show("Error al listar artículos: " + e.Message);
            }
        }



        //EXPORTAR DATOS
        public void ExportarRubro(string rubro, string rutaArchivo)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Articulos WHERE Rubro = '" + rubro + "'";

                OleDbDataReader DR = comando.ExecuteReader();


                // PASO 4: crear el StreamWriter con la ruta del SaveFileDialog
                // false = sobreescribir el archivo (no agregar al final)
                StreamWriter reporte = new StreamWriter(rutaArchivo, false, Encoding.UTF8);

                // TÍTULOS
                reporte.WriteLine("Artículos clasificados por Rubro");
                reporte.WriteLine("Rubro: " + rubro);
                reporte.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                reporte.WriteLine();
                reporte.WriteLine("Codigo;Descripcion;Costo;Stock;Valor en Stock");

                int cantidadExport = 0;
                decimal totalStockExport = 0;

                //Cargar los datos fila por fila en el archivo
                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        decimal costo = DR.GetDecimal(2);//posicion
                        int stock = DR.GetInt32(4);
                        decimal valstock = costo * stock;

                        reporte.Write(DR["Codigo"].ToString()); reporte.Write(";");
                        reporte.Write(DR["Descripcion"].ToString()); reporte.Write(";");
                        reporte.Write(costo); reporte.Write(";");
                        reporte.Write(stock); reporte.Write(";");
                        reporte.WriteLine(valstock);

                        cantidadExport++;
                        totalStockExport += valstock;
                    }

                }

                reporte.WriteLine();
                reporte.WriteLine("Total de articulos;" + cantidadExport);
                reporte.WriteLine("Valor en stock total;" + totalStockExport);

                reporte.Close();
                conexion.Close();
            }
            catch (Exception e) { MessageBox.Show(e.ToString()); }
        }




        //IMPRIMIR 
        public void Imprimir(PrintPageEventArgs reporte, DataGridView dgvArticulos, string rubro)
        {
            try
            {
                //Fuentes
                Font LetraTitulo = new Font("Arial", 12);
                Font LetraEncabezado = new Font("Arial", 9, FontStyle.Bold);
                Font LetraTexto = new Font("Arial", 8);

                int f = 100; //Posicion vertical inicial 

                // Título del reporte
                reporte.Graphics.DrawString("Listado de Artículos - Rubro: " + rubro, LetraTitulo, Brushes.DarkBlue, 100, 50);

                // Encabezados de las columnas  
                reporte.Graphics.DrawString("Código", LetraEncabezado, Brushes.Blue, 100, f);
                reporte.Graphics.DrawString("Descripción", LetraEncabezado, Brushes.Blue, 220, f);
                reporte.Graphics.DrawString("Costo", LetraEncabezado, Brushes.Blue, 570, f);
                reporte.Graphics.DrawString("Stock", LetraEncabezado, Brushes.Blue, 670, f);
                reporte.Graphics.DrawString("Valor Stock", LetraEncabezado, Brushes.Blue, 740, f);

                f = f + 20;// Salto de línea para los datos

              
                // Abrir la conexión y ejecutar la consulta para obtener los datos de los artículos
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Articulos WHERE Rubro = '" + Rub + "'";

                // Llenar un DataSet con los datos de los artículos
                adapter = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adapter.Fill(DS, TabArticulos);

                
                foreach (DataGridViewRow fila in dgvArticulos.Rows)//Recorre cada fila de la grilla
                {
                    if (fila.IsNewRow) continue;

                    reporte.Graphics.DrawString(fila.Cells[0].Value?.ToString(), LetraTexto, Brushes.Black, 100, f);
                    reporte.Graphics.DrawString(fila.Cells[1].Value?.ToString(), LetraTexto, Brushes.Black, 220, f);
                    reporte.Graphics.DrawString(fila.Cells[2].Value?.ToString(), LetraTexto, Brushes.Black, 570, f);
                    reporte.Graphics.DrawString(fila.Cells[3].Value?.ToString(), LetraTexto, Brushes.Black, 670, f);
                    reporte.Graphics.DrawString(fila.Cells[4].Value?.ToString(), LetraTexto, Brushes.Black, 740, f);

                    f = f + 15;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}