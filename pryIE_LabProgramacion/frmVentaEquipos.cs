using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void lblInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show(" Analista de Sistemas\n" +
                            "Laboratorio de Programación 2\n" +
                            "1º Instancia Evaluativa\n" +
                            "Información del Alumno\n" +
                            "DNI:46656705 – Delgado Sofía");
        }
    }
}
