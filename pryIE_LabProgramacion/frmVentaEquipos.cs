using System;
using System.Drawing.Printing;//AGREGAR
using System.Windows.Forms;//AGREGAR 

namespace pryIE_LabProgramacion
{
    public partial class frmVentaEquipos : Form
    {
        public frmVentaEquipos()
        {
            InitializeComponent();
        }

        clArchivoInsumos x = new clArchivoInsumos();

        private void lblInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Analista de Sistemas\n" +
                            "Laboratorio de Programación 2\n" +
                            "IE2º Instancia Evaluativa\n" +
                            "Información del Alumno\n" +
                            "DNI:46656705 – Delgado Sofía");
        }

        private void frmVentaEquipos_Load(object sender, EventArgs e)
        {
            x.CargarRubros(cbRubros);
            cmdConsultar.Enabled = false;
            cmdExportarDatos.Enabled = false;
            cmdImprimir.Enabled = false;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            x.ListarArticulos(dgvArticulos, cbRubros.Text);

            lblCantidad.Text = x.CantArticulos.ToString();
            lblTotal.Text = x.TotalVStock.ToString("C");

            cmdExportarDatos.Enabled = true;
            cmdImprimir.Enabled = true;
        }

        private void cmdExportarDatos_Click(object sender, EventArgs e)
        {
            //SafeFileDialog = sfdGuarda : Ventana de Windows(Elegir carpeta y nombre del archivo)
           
            sfdGuarda.FileName = "ReporteArticulos_" + cbRubros.Text + ".csv";
            sfdGuarda.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*";
            sfdGuarda.Title = "Guardar reporte de artículos";//Titulo ventana

            if (sfdGuarda.ShowDialog() == DialogResult.OK)
            {
                x.ExportarRubro(cbRubros.Text, sfdGuarda.FileName);
                MessageBox.Show("Archivo exportado correctamente", "Exportación");
            }
        }

        private void cmdImprimir_Click(object sender, EventArgs e)
        {
            //PrintDialog = prtVentana : Dialogo de impresion
            //PrintDocument = prtDocumento : Documento a imprimir
            
            // Se asigna el documento al diálogo de impresión
            prtVentana.Document = prtDocumento;

            if (prtVentana.ShowDialog() == DialogResult.OK)//Si acepta
            {
                prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
                prtDocumento.Print();// Se inicia la impresión del documento(PrintPage)
                MessageBox.Show("Reporte impreso", "Impresión");
            }
        }

        private void prtDocumento_PrintPage(object sender, PrintPageEventArgs e)
        {
            x.Imprimir(e, dgvArticulos, cbRubros.Text);
            //Se llama al método Imprimir de la clase clArchivoInsumos
        }


        private void cbRubros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbRubros.Text != "")
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
            }
        }
    }
}