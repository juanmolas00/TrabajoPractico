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
    public partial class FrmCiudadanos : Form
    {
        AccesoDatos AD;
        AccesoDatos AD2;
        Ciudadano[] Ciudadano = new Ciudadano[1000];
        

        public FrmCiudadanos()
        {

            InitializeComponent();
            AD = new AccesoDatos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Juan\Desktop\Cosas de la facu\TP FINAL FINAL FINAL\Voto Electronico\VotoElectronico V2.mdb");
            AD2 = new AccesoDatos(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Juan\Desktop\Cosas de la facu\TP FINAL FINAL FINAL\Voto Electronico\VotoElectronico V2.mdb");
        }

        private void Ciudadanos_Load(object sender, EventArgs e)
        {
            deshabilitar(true);
            btnConfirmarModif.Enabled = false;
            cargarCombobox();
            cargarCombobox2();
            cargarlistbox();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Realmente Salir del Sistema?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }


        }

        private void btnAgregarCiudadano_Click(object sender, EventArgs e)
        {
            deshabilitar(false);
            lblMensajeSist.Text = "Ingrese la Informacion del Ciudadano a cargar";
            btnConfirmarModif.Enabled = false;
            btnModificar.Enabled = false;
            btnBorrar.Enabled = false;
        }


        private void btnConfirmarCarga_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Ciudadano a = new Ciudadano();
                a.Apellido1 = txtApellido.Text;
                a.Nombre1 = txtNombre.Text;
                a.Direccion1 = txtDireccion.Text;
                a.DNI1 = Convert.ToInt32(txtDocumento.Text);
                a.Barrio1 = Convert.ToInt32(cmbBarrio.SelectedValue);
                a.Depto1 = Convert.ToInt32(cmbDepartamento.SelectedValue);
                if (rdbFemenino.Checked)
                    a.Sexo1 = true;
                if (rdbMasculino.Checked)
                    a.Sexo1 = false;
                AD.actualizarDB("INSERT INTO Ciudadanos (DNI, apellido, nombre, direccion, id_barrio, id_depto, sexo) VALUES (" + a.DNI1 + ", '" + a.Apellido1 + "', '" + a.Nombre1 + "', '" + a.Direccion1 + "', " + a.Barrio1 + ", " + a.Depto1 + ", " + a.Sexo1 + ")");
                lblMensajeSist.Text = "Carga de Nuevo Ciudadano Exitosa";

                Limpiarcampos();
                deshabilitar(true);
                cargarlistbox();

            }

        }

        private void lstCiudadanos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCiudadanos.SelectedIndex != -1)
            {
                btnBorrar.Enabled = true;
                btnModificar.Enabled = true;
                txtDocumento.Text = Convert.ToString(Ciudadano[lstCiudadanos.SelectedIndex].DNI1);
                txtApellido.Text = Convert.ToString(Ciudadano[lstCiudadanos.SelectedIndex].Apellido1);
                txtNombre.Text = Convert.ToString(Ciudadano[lstCiudadanos.SelectedIndex].Nombre1);
                txtDireccion.Text = Convert.ToString(Ciudadano[lstCiudadanos.SelectedIndex].Direccion1);
                if (Ciudadano[lstCiudadanos.SelectedIndex].Sexo1)
                    rdbFemenino.Checked = true;
                else
                    rdbMasculino.Checked = true;
                cmbBarrio.SelectedValue = Ciudadano[lstCiudadanos.SelectedIndex].Barrio1;
                cmbDepartamento.SelectedValue = Ciudadano[lstCiudadanos.SelectedIndex].Depto1;                
            }
        }
        //Solo admite el ingreso de numeros en el textbox de documento
        //private void txtDocumento_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (Char.IsDigit(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    else if (Char.IsControl(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    else if (Char.IsSeparator(e.KeyChar))
        //    {
        //        e.Handled = false;
        //    }
        //    else
        //    {
        //        e.Handled = true;
        //    }
        //}


        //Metodo de Validacion, revisa que ningun textbox o combobox este vacio o radiobutton sin seleccionar
        private bool Validacion()
        {
            if (txtApellido.Text == "")
            {
                lblMensajeSist.Text = "Error de Carga, Intente Nuevamente";
                MessageBox.Show("El Campo Apellido se encuentra Vacio", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtNombre.Text == "")
            {
                lblMensajeSist.Text = "Error de Carga, Intente Nuevamente";
                MessageBox.Show("El Campo Nombre se encuentra Vacio", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDireccion.Text == "")
            {
                lblMensajeSist.Text = "Error de Carga, Intente Nuevamente";
                MessageBox.Show("El Campo Direccion se encuentra Vacio", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            try
            {
                int error = Convert.ToInt32(txtDocumento.Text);
            }
            catch
            {
                MessageBox.Show("Error", "El campo Documento debe ser un numero");
                return false;
            }
            if (txtDocumento.Text == "")
            {
                lblMensajeSist.Text = "Error de Carga, Intente Nuevamente";
                MessageBox.Show("El Campo Documento se encuentra Vacio", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbBarrio.SelectedIndex == -1)
            {
                lblMensajeSist.Text = "Error de Carga, Intente Nuevamente";
                MessageBox.Show("No se ha elegido ningun Barrio", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (cmbDepartamento.SelectedIndex == -1)
            {
                lblMensajeSist.Text = "Error de Carga, Intente Nuevamente";
                MessageBox.Show("No se ha elegido ningun Departamento", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!rdbFemenino.Checked && !rdbMasculino.Checked)
            {
                lblMensajeSist.Text = "Error de Carga, Intente Nuevamente";
                MessageBox.Show("Debe Elegir el Sexo del Ciudadano", "Error de Carga", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;

        }

        //Metodo que deshabilita o habilita todos los campos, botones y la lista del form segun el valor de X.
        private void deshabilitar(bool x)
        {
            txtDocumento.Enabled = !x;
            txtApellido.Enabled = !x;
            txtDireccion.Enabled = !x;
            txtNombre.Enabled = !x;
            btnConfirmarCarga.Enabled = !x;
            cmbBarrio.Enabled = !x;
            cmbDepartamento.Enabled = !x;
            rdbFemenino.Enabled = !x;
            rdbMasculino.Enabled = !x;
            btnModificar.Enabled = !x;
            btnBorrar.Enabled = !x;
            btnAgregarCiudadano.Enabled = x;
            lstCiudadanos.Enabled = x;
            
        }
        private void deshabilitarModif(bool x)
        {
            txtDocumento.Enabled = x;
            txtApellido.Enabled = !x;
            txtDireccion.Enabled = !x;
            txtNombre.Enabled = !x;
            btnConfirmarCarga.Enabled = x;
            cmbBarrio.Enabled = !x;
            cmbDepartamento.Enabled = !x;
            rdbFemenino.Enabled = !x;
            rdbMasculino.Enabled = !x;
            btnConfirmarModif.Enabled = !x;
            btnModificar.Enabled = x;
            btnBorrar.Enabled = x;
            btnAgregarCiudadano.Enabled = x;
            lstCiudadanos.Enabled = !x;
        }

        //Metodo de limpieza de Campos, limpia cada textbox dejando en blanco.
        private void Limpiarcampos()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtDocumento.Text = "";
            cmbBarrio.SelectedIndex = -1;
            cmbDepartamento.SelectedIndex = -1;
            rdbFemenino.Checked = false;
            rdbMasculino.Checked = false;
        }

        //metodo para cargar la listbox con los datos de la base de datos.
        private void cargarlistbox()
        {
            AD.leerTabla("Ciudadanos");
            int c = 0;
            while (AD.pLector.Read())
            {
                Ciudadano a = new Ciudadano();
                if (!AD.pLector.IsDBNull(0))
                    a.DNI1 = AD.pLector.GetInt32(0);
                if (!AD.pLector.IsDBNull(2))
                    a.Apellido1 = AD.pLector.GetString(2);
                if (!AD.pLector.IsDBNull(1))
                    a.Nombre1 = AD.pLector.GetString(1);
                if (!AD.pLector.IsDBNull(6))
                    a.Direccion1 = AD.pLector.GetString(6);
                if (!AD.pLector.IsDBNull(4))
                    a.Barrio1 = AD.pLector.GetInt32(4);
                if (!AD.pLector.IsDBNull(5))
                    a.Depto1 = AD.pLector.GetInt32(5);
                if (!AD.pLector.IsDBNull(3))
                    a.Sexo1 = AD.pLector.GetBoolean(3);
                Ciudadano[c] = a;
                c++;

            }
            AD.desconectar();
            lstCiudadanos.Items.Clear();
            for (int i = 0; i < c; i++)
            {
                lstCiudadanos.Items.Add(Ciudadano[i].ToString());
            }

        }

        private void btnVolverInicio_Click(object sender, EventArgs e)
        {

            FrmInicio formC = new FrmInicio();
            formC.Show();
            this.Hide();

        }

        //metodo para cargar los combo box con los datos de los barrio y los departamentos directo de la base de datos.
        private void cargarCombobox()
        {
            DataTable dat = new DataTable();
            dat = AD.consultarTabla("Barrios");
            cmbBarrio.DataSource = dat;
            cmbBarrio.ValueMember = dat.Columns[0].ColumnName;
            cmbBarrio.DisplayMember = dat.Columns[1].ColumnName;
            AD.desconectar();

        }

        private void cargarCombobox2()
        {
            DataTable dat1 = new DataTable();
            dat1 = AD2.consultarTabla("Departamentos");
            cmbDepartamento.DataSource = dat1;
            cmbDepartamento.ValueMember = dat1.Columns[0].ColumnName;
            cmbDepartamento.DisplayMember = "Nomdpto";
            AD2.desconectar();

        }


        private void grbDatosPersona_Enter(object sender, EventArgs e)
        {

        }

        private void rdbFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            deshabilitarModif(false);
            lblMensajeSist.Text = "Ingrese la informacion a Modificar";
        }

        private void btnConfirmarModif_Click(object sender, EventArgs e)
        {
            if (Validacion())
            {
                Ciudadano a = new Ciudadano();
                a.Apellido1 = txtApellido.Text;
                a.Nombre1 = txtNombre.Text;
                a.Direccion1 = txtDireccion.Text;
                a.DNI1 = Convert.ToInt32(txtDocumento.Text);
                a.Barrio1 = Convert.ToInt32(cmbBarrio.SelectedValue);
                a.Depto1 = Convert.ToInt32(cmbDepartamento.SelectedValue);
                if (rdbFemenino.Checked)
                    a.Sexo1 = true;
                if (rdbMasculino.Checked)
                    a.Sexo1 = false;
                AD.actualizarDB("UPDATE Ciudadanos SET Apellido = '" + a.Apellido1 + "', Nombre = '" + a.Nombre1 + "', Direccion = '" + a.Direccion1 + "', Id_Barrio =" + a.Barrio1 + ", Id_depto = " + a.Depto1 + ", Sexo = " + a.Sexo1 + " WHERE DNI = " + a.DNI1 + "");
                lblMensajeSist.Text = "Modificacion del Ciudadano Exitosa";
                Limpiarcampos();
                deshabilitar(true);
                cargarlistbox();
            }
        }
        private void FormCiudadanos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que desea abandonar la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question,MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea borrar el ciudadano?", "Borrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Ciudadano a = new Ciudadano();
                a.Apellido1 = txtApellido.Text;
                a.Nombre1 = txtNombre.Text;
                a.Direccion1 = txtDireccion.Text;
                a.DNI1 = Convert.ToInt32(txtDocumento.Text);
                a.Barrio1 = Convert.ToInt32(cmbBarrio.SelectedValue);
                a.Depto1 = Convert.ToInt32(cmbDepartamento.SelectedValue);
                if (rdbFemenino.Checked)
                    a.Sexo1 = true;
                if (rdbMasculino.Checked)
                    a.Sexo1 = false;
                AD.DeleteDB("Ciudadanos","DNI="+ a.DNI1 +"");
                lblMensajeSist.Text = "Eliminacion del Ciudadano Exitosa";
                Limpiarcampos();
                deshabilitar(true);
                cargarlistbox();
            }
        }


        private void btnReporte_Click(object sender, EventArgs e)
        {
            FormInforme formC = new FormInforme();
            formC.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}

