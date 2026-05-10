using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryIE_LabProgramacion
{
    internal class clArchivoInsumos
    {
        public string NombreArchivoR = "RUBROS.csv";
        public string NombreArchivoA = "ARTICULOS.csv";

        //CARGA DE COMBOBOX RUBROS
        public void CargarRubros(ComboBox cbRubros)
        {
            string DatosLeidos;
            cbRubros.Items.Clear();
            
            StreamReader AD = new StreamReader(NombreArchivoR);
            DatosLeidos = AD.ReadLine();
           
            while (DatosLeidos != null)
            {
                if (DatosLeidos != "")
                {
                    cbRubros.Items.Add(DatosLeidos);
                }
                DatosLeidos = AD.ReadLine();
            }
            AD.Close();
            AD.Dispose();
        }

        //CARGA DE GRILLA-ARTICULOS
        public void ListarArticulos(ComboBox cbRubros, DataGridView dgvArticulos, Label lblCantidad, Label lblTotal)
        { 
            string DatosLeidos;
            string[] VectorDatos;

            int cantidad = 0;
            decimal totalgeneral = 0;
            decimal valorstock = 0;

            dgvArticulos.Rows.Clear();
            if (cbRubros.SelectedIndex != -1)
            { 
                StreamReader AD = new StreamReader(NombreArchivoA);
                DatosLeidos = AD.ReadLine();
                while (DatosLeidos != null)
                { 
                    VectorDatos = DatosLeidos.Split(';');
                    if (VectorDatos[3] == cbRubros.Text)
                    {
                        valorstock = Convert.ToDecimal(VectorDatos[2]) * Convert.ToInt32(VectorDatos[4]);

                        // Agrega fila a la grilla
                        dgvArticulos.Rows.Add(VectorDatos[0], VectorDatos[1], VectorDatos[2], VectorDatos[4], valorstock);
                        cantidad++;
                        totalgeneral=totalgeneral+ valorstock;
                    }
                    DatosLeidos = AD.ReadLine();
                }
                AD.Close();
                AD.Dispose();

                lblCantidad.Text = "Cantidad: " + cantidad.ToString();
                lblTotal.Text = "Total: $" + totalgeneral.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rubro primero.");
            }
        }
        //EXPORTAR DATOS
        public void ExportarRubro(string rubro)
        {
            string DatoLeido;
            string[] vecDatos;
            decimal costo;
            int stock;
            decimal valorStock;

            StreamReader AD = new StreamReader(NombreArchivoA);
            StreamWriter Reporte = new StreamWriter("ReporteArticulosExportados.csv", false,System.Text.Encoding.UTF8);//false para que no se sobreescriba y encoding para que se guarde con el formato correcto2
            Reporte.WriteLine("Código;Descripcion;Costo;Stock;Valor en Stock");
            DatoLeido = AD.ReadLine();

            while (DatoLeido !=null)
            {
                vecDatos =DatoLeido.Split(';');
                if (vecDatos[3] ==rubro)
                {
                    costo = Convert.ToDecimal(vecDatos[2]);
                    stock = Convert.ToInt32(vecDatos[4]);
                    valorStock = costo * stock;
                    Reporte.WriteLine($"{vecDatos[0]};{vecDatos[1]};{vecDatos[2]};{vecDatos[4]};{valorStock}");
                }
                DatoLeido=AD.ReadLine();
            }
            AD.Close();
            Reporte.Close();
            AD.Dispose();
        }

    }
}

