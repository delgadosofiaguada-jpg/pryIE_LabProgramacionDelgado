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
        public string NombreArchivoR = "Rubros.csv";
        public string NombreArchivoA = "Articulos.csv";
        public void CargarRubros(ComboBox cbRubros)
        {
            
            string DatosLeidos;
            cbRubros.Items.Clear();
            //abrir
            StreamReader AD = new StreamReader(NombreArchivoR);

            //leer
            DatosLeidos = AD.ReadLine();
           

            while (DatosLeidos != null)
            {

                // Lo agregamos directamente al ComboBox
                if (DatosLeidos != "")
                {
                    cbRubros.Items.Add(DatosLeidos);
                }

                // Leer la siguiente línea al final del ciclo
                DatosLeidos = AD.ReadLine();
            }

            //cerrar
            AD.Close();
            AD.Dispose();

        }
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

                        // Agregamos la fila a la grilla
                        dgvArticulos.Rows.Add(VectorDatos[0], VectorDatos[1], VectorDatos[2], VectorDatos[4], valorstock);

                        // Incrementamos contador y acumulador
                        cantidad++;
                        totalgeneral=totalgeneral+ valorstock;
                    }
                    DatosLeidos = AD.ReadLine();
                }
                AD.Close();
                AD.Dispose();

                // Mostramos los resultados en las etiquetas
                lblCantidad.Text = "Cantidad: " + cantidad.ToString();
                lblTotal.Text = "Total: $" + totalgeneral.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un rubro primero.");
            }
        }
    }
}

