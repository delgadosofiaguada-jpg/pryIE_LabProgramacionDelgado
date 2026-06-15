using System;
using System.Collections.Generic;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryIE_LabProgramacion
{
    internal class clArchivoInsumos
    {
        private string CadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=InventarioArticulos.accdb;";

        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand comando = new OleDbCommand();
        OleDbDataAdapter adapter;
        private string TabArticulos = "Articulos";
        private string TabRubros = "Rubros";
        private string Rub = "";
        private int cant = 0;
        private decimal TotalStock = 0;

        public int CantArticulos { get { return cant; } }
        public decimal TotalVStock { get { return TotalStock; } }

        //CARGA DE COMBOBOX RUBROS
        public void CargarRubros(ComboBox cbRubros)
        {

            try
            {
                cbRubros.Items.Clear();
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = TabRubros;

                OleDbDataReader DR = comando.ExecuteReader();
                while (DR.Read())
                {
                    cbRubros.Items.Add(DR.GetString(0));
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        //CARGA DE GRILLA-ARTICULOS
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
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Articulos WHERE Rubro = '" + rubro + "'";

                adapter = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adapter.Fill(DS, TabArticulos);
                conexion.Close();

                if (DS.Tables[TabArticulos].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[TabArticulos].Rows)
                    {
                        decimal costo = Convert.ToDecimal(fila["Costo"]);
                        int stock = Convert.ToInt32(fila["Stock"]);
                        decimal valstock = costo * stock;

                        grilla.Rows.Add(fila["Codigo"].ToString(), fila["Descripcion"].ToString(), costo.ToString("C"), stock, valstock.ToString("C"));
                        cant++;
                        TotalStock += valstock;
                    }

                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
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
                StreamWriter reporte = new StreamWriter(rutaArchivo, false, Encoding.UTF8);

                // TÍTULO
                reporte.WriteLine("Artículos clasificados por Rubro");
                reporte.WriteLine("Rubro: " + rubro);
                reporte.WriteLine("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                reporte.WriteLine();
                reporte.WriteLine("Codigo;Descripcion;Costo;Stock;Valor en Stock");

                int cantidadExport = 0;
                decimal totalStockExport = 0;

                if (DR.HasRows)
                {
                    while (DR.Read())
                    {
                        decimal costo = DR.GetDecimal(2);
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
                Font LetraTitulo = new Font("Arial", 14);
                Font LetraEncabezado = new Font("Arial", 10, FontStyle.Bold);
                Font LetraTexto = new Font("Arial", 9);

                int f = 100;

                reporte.Graphics.DrawString("Listado de Artículos - Rubro: " + rubro, LetraTitulo, Brushes.DarkBlue, 100, 50);

                reporte.Graphics.DrawString("Código", LetraEncabezado, Brushes.Blue, 100, f);
                reporte.Graphics.DrawString("Descripción", LetraEncabezado, Brushes.Blue, 220, f);
                reporte.Graphics.DrawString("Costo", LetraEncabezado, Brushes.Blue, 480, f);
                reporte.Graphics.DrawString("Stock", LetraEncabezado, Brushes.Blue, 570, f);
                reporte.Graphics.DrawString("Valor Stock", LetraEncabezado, Brushes.Blue, 640, f);

                f = f + 20;

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM Articulos WHERE Rubro = '" + Rub + "'";

                adapter = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adapter.Fill(DS, TabArticulos);

                foreach (DataGridViewRow fila in dgvArticulos.Rows)
                {
                    if (fila.IsNewRow) continue;

                    reporte.Graphics.DrawString(fila.Cells[0].Value?.ToString(), LetraTexto, Brushes.Black, 100, f);
                    reporte.Graphics.DrawString(fila.Cells[1].Value?.ToString(), LetraTexto, Brushes.Black, 220, f);
                    reporte.Graphics.DrawString(fila.Cells[2].Value?.ToString(), LetraTexto, Brushes.Black, 480, f);
                    reporte.Graphics.DrawString(fila.Cells[3].Value?.ToString(), LetraTexto, Brushes.Black, 570, f);
                    reporte.Graphics.DrawString(fila.Cells[4].Value?.ToString(), LetraTexto, Brushes.Black, 640, f);

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