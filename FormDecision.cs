using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voto_Electronico
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnInicioVotante_Click(object sender, EventArgs e)
        {
            FrmCiudadanos formC = new FrmCiudadanos();
            formC.Show();
            this.Hide();
        }

        private void btnInicioJuez_Click(object sender, EventArgs e)
        {
            FrmConsultas formC = new FrmConsultas();
            formC.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Realmente Salir del Sistema?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {

        }
        private void FormDecision_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
    }
}
