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
    public partial class FrmConsultas : Form
    {
        AccesoDatos d;
        public FrmConsultas()
        {
            InitializeComponent();
        }

        private void FrmConsultas_Load(object sender, EventArgs e)
        {
            Deshabilitar1(false); 
            d = new AccesoDatos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Juan\Desktop\Cosas de la facu\TP FINAL FINAL FINAL\Voto Electronico\VotoElectronico V2.mdb");
        }

        private void Deshabilitar1(bool x)
        {
            btnBorrarListado.Enabled = !x;
            dgvConsultas.Enabled = !x;
            btnConsulta1.Enabled = !x;
            btnConsulta2.Enabled = !x;
            btnConsulta3.Enabled = !x;


        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            FrmInicio formC = new FrmInicio();
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

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            //Candidato a Diputadado por cada partido politico
            btnConsulta5.Enabled = false;
            btnConsulta3.Enabled = false;
            btnConsulta2.Enabled = false;
            btnConsulta1.Enabled = false;
            btnConsulta4.Enabled = false;
            d.cargardatagrid(dgvConsultas, "SELECT ci.Nombre, ci.Apellido, c.id_candidato, l.id_lista as 'Lista Numero', l.NomLista as 'Nombre de Lista' "
                                           + " FROM candidatos c, listas l, Ciudadanos ci "
                                           + " WHERE c.id_lista = l.id_lista and ci.dni = c.dni and c.cargo like 'diputado'");
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            //ciudadanos que no votaron
            btnConsulta5.Enabled = false;
            btnConsulta1.Enabled = false;
            btnConsulta2.Enabled = false;
            btnConsulta4.Enabled = false;
            btnConsulta3.Enabled = false;
            d.cargardatagrid(dgvConsultas, "SELECT c.dni , c.nombre + ' ' + c.apellido as 'Nombre y Apellido', c.id_barrio, c.id_depto, c.direccion as 'Domicilio', p.id_mesa as' Numero de Mesa' FROM ciudadanos c, padrones p"
            + " WHERE c.dni = p.dni and votoSiNo = false");
        }
        private void btnConsulta3_Click_1(object sender, EventArgs e)
        {
            //cantidad de votos que tuvo una mesa
            btnConsulta5.Enabled = false;
            btnConsulta3.Enabled = false;
            btnConsulta2.Enabled = false;
            btnConsulta1.Enabled = false;
            btnConsulta4.Enabled = false;
            d.cargardatagrid(dgvConsultas, "SELECT count(*) as 'Cantidad de Votos'"
            + " FROM votos v, mesas m, escuelas e, Departamentos d"
            + " WHERE (v.id_mesa = m.id_mesa and e.id_escuela = m.id_escuela and e.id_depto = d.id_depto) and d.Nomdpto like 'capital'");
        }
        private void btnConsulta4_Click_1(object sender, EventArgs e)
        {

            //cantidad de votos en blanco
            btnConsulta5.Enabled = false;
            btnConsulta3.Enabled = false;
            btnConsulta4.Enabled = false;
            btnConsulta2.Enabled = false;
            btnConsulta1.Enabled = false;
            d.cargardatagrid(dgvConsultas, "SELECT count (*) as 'Votos en Blanco' "
                + "FROM votos where id_candidato = 12");
        }

        private void btnConsulta5_Click_1(object sender, EventArgs e)
        {

            //Mesa de los colegios que estan en el barrio 5 de eleccion de senadores
            
            btnConsulta3.Enabled = false;
            btnConsulta5.Enabled = false;
            btnConsulta4.Enabled = false;
            btnConsulta2.Enabled = false;
            btnConsulta1.Enabled = false;
            d.cargardatagrid(dgvConsultas, "SELECT m.id_mesa as 'Numero de Mesa', e.NombEscuela as 'Nombre de la Escuela', b.NomBarrio as 'Nombre del Barrio', el.descripcion as 'Tipo de Elecciones'"
                + " FROM Escuelas e, Mesas m, Elecciones el, Barrios b"
                + " WHERE (m.id_escuela = e.Id_escuela and e.id_barrio = b.id_barrio and m.id_eleccion = el.id_eleccion) and b.NomBarrio like 'Alberto' and el.descripcion like 'Senador'");
        }

        private void btnBorrarListado_Click_1(object sender, EventArgs e)
        {
            this.dgvConsultas.DataSource = null;
            this.dgvConsultas.Rows.Clear();
            btnConsulta1.Enabled = true;
            btnConsulta2.Enabled = true;
            btnConsulta3.Enabled = true;
            btnConsulta4.Enabled = true;
            btnConsulta5.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from departamentos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from candidatos");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from listas");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from votos");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from elecciones");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from Mesas");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from escuelas");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from padrones");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from barrios");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            d.cargardatagrid(dgvConsultas, "Select * from Ciudadanos");
        }

        private void dgvConsultas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormConsultas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {


        }

    }
}
