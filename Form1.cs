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
    public partial class FormInforme : Form
    {
        public FormInforme()
        {
            InitializeComponent();
        }

        private void FormInforme_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'votoElectronico_V2DataSet11.Ciudadanos' Puede moverla o quitarla según sea necesario.
            this.ciudadanosTableAdapter1.Fill(this.votoElectronico_V2DataSet11.Ciudadanos);
            // TODO: esta línea de código carga datos en la tabla 'votoElectronico_V2DataSet11.Votos' Puede moverla o quitarla según sea necesario.
            this.votosTableAdapter.Fill(this.votoElectronico_V2DataSet11.Votos);
            // TODO: esta línea de código carga datos en la tabla 'votoElectronico_V2DataSet11.Candidatos' Puede moverla o quitarla según sea necesario.
            this.candidatosTableAdapter.Fill(this.votoElectronico_V2DataSet11.Candidatos);
            // TODO: esta línea de código carga datos en la tabla 'votoElectronico_V2DataSet1.Ciudadanos' Puede moverla o quitarla según sea necesario.
            this.ciudadanosTableAdapter.Fill(this.votoElectronico_V2DataSet1.Ciudadanos);

        }

        private void btnVolverRepo_Click(object sender, EventArgs e)
        {
            FrmCiudadanos formC = new FrmCiudadanos();
            formC.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
