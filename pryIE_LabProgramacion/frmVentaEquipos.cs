using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                            "1º Instancia Evaluativa\n" +
                            "Información del Alumno\n" +
                            "DNI:46656705 – Delgado Sofía");
        }

        private void frmVentaEquipos_Load(object sender, EventArgs e)
        {
            x.CargarRubros(cbRubros);
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            x.ListarArticulos(cbRubros, dgvArticulos, lblCantidad, lblTotal);
        }

        private void cmdExportarDatos_Click(object sender, EventArgs e)
        {

        }
    }
}
