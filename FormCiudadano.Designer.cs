namespace Voto_Electronico
{
    partial class FrmCiudadanos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbDatosPersona = new System.Windows.Forms.GroupBox();
            this.btnVolverInicio = new System.Windows.Forms.Button();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregarCiudadano = new System.Windows.Forms.Button();
            this.btnConfirmarCarga = new System.Windows.Forms.Button();
            this.grbMensajeSist = new System.Windows.Forms.GroupBox();
            this.lblMensajeSist = new System.Windows.Forms.Label();
            this.grbListaCiudadanos = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lstCiudadanos = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfirmarModif = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.grbDatosPersona.SuspendLayout();
            this.grbMensajeSist.SuspendLayout();
            this.grbListaCiudadanos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosPersona
            // 
            this.grbDatosPersona.BackColor = System.Drawing.Color.Transparent;
            this.grbDatosPersona.Controls.Add(this.btnVolverInicio);
            this.grbDatosPersona.Controls.Add(this.cmbDepartamento);
            this.grbDatosPersona.Controls.Add(this.cmbBarrio);
            this.grbDatosPersona.Controls.Add(this.rdbFemenino);
            this.grbDatosPersona.Controls.Add(this.rdbMasculino);
            this.grbDatosPersona.Controls.Add(this.lblAltura);
            this.grbDatosPersona.Controls.Add(this.lblDepartamento);
            this.grbDatosPersona.Controls.Add(this.lblLocalidad);
            this.grbDatosPersona.Controls.Add(this.lblCalle);
            this.grbDatosPersona.Controls.Add(this.lblDocumento);
            this.grbDatosPersona.Controls.Add(this.lblApellido);
            this.grbDatosPersona.Controls.Add(this.lblNombre);
            this.grbDatosPersona.Controls.Add(this.txtDireccion);
            this.grbDatosPersona.Controls.Add(this.txtDocumento);
            this.grbDatosPersona.Controls.Add(this.txtApellido);
            this.grbDatosPersona.Controls.Add(this.txtNombre);
            this.grbDatosPersona.Location = new System.Drawing.Point(11, 11);
            this.grbDatosPersona.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDatosPersona.Name = "grbDatosPersona";
            this.grbDatosPersona.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbDatosPersona.Size = new System.Drawing.Size(761, 173);
            this.grbDatosPersona.TabIndex = 1;
            this.grbDatosPersona.TabStop = false;
            this.grbDatosPersona.Text = "Informacion del Ciudadano";
            this.grbDatosPersona.Enter += new System.EventHandler(this.grbDatosPersona_Enter);
            // 
            // btnVolverInicio
            // 
            this.btnVolverInicio.Location = new System.Drawing.Point(669, 15);
            this.btnVolverInicio.Name = "btnVolverInicio";
            this.btnVolverInicio.Size = new System.Drawing.Size(85, 22);
            this.btnVolverInicio.TabIndex = 0;
            this.btnVolverInicio.Text = "Volver al Inicio";
            this.btnVolverInicio.UseVisualStyleBackColor = true;
            this.btnVolverInicio.Click += new System.EventHandler(this.btnVolverInicio_Click);
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(424, 126);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(330, 21);
            this.cmbDepartamento.TabIndex = 13;
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(559, 101);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(195, 21);
            this.cmbBarrio.TabIndex = 15;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(209, 129);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rdbFemenino.TabIndex = 11;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Femenino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            this.rdbFemenino.CheckedChanged += new System.EventHandler(this.rdbFemenino_CheckedChanged);
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(118, 129);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 10;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(514, 105);
            this.lblAltura.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(40, 13);
            this.lblAltura.TabIndex = 14;
            this.lblAltura.Text = "Barrio";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(333, 129);
            this.lblDepartamento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(86, 13);
            this.lblDepartamento.TabIndex = 12;
            this.lblDepartamento.Text = "Departamento";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLocalidad.Location = new System.Drawing.Point(20, 129);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(35, 13);
            this.lblLocalidad.TabIndex = 9;
            this.lblLocalidad.Text = "Sexo";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalle.Location = new System.Drawing.Point(20, 105);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(61, 13);
            this.lblCalle.TabIndex = 7;
            this.lblCalle.Text = "Direccion";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocumento.Location = new System.Drawing.Point(20, 36);
            this.lblDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(71, 13);
            this.lblDocumento.TabIndex = 1;
            this.lblDocumento.Text = "Documento";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(20, 82);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(52, 13);
            this.lblApellido.TabIndex = 5;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(20, 59);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre";
            // 
            // txtDireccion
            // 
            this.txtDireccion.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtDireccion.Location = new System.Drawing.Point(118, 102);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(392, 20);
            this.txtDireccion.TabIndex = 8;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Location = new System.Drawing.Point(118, 34);
            this.txtDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(147, 20);
            this.txtDocumento.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtApellido.Location = new System.Drawing.Point(118, 79);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(636, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txtNombre.Location = new System.Drawing.Point(118, 57);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(636, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // btnAgregarCiudadano
            // 
            this.btnAgregarCiudadano.Location = new System.Drawing.Point(165, 189);
            this.btnAgregarCiudadano.Name = "btnAgregarCiudadano";
            this.btnAgregarCiudadano.Size = new System.Drawing.Size(153, 44);
            this.btnAgregarCiudadano.TabIndex = 2;
            this.btnAgregarCiudadano.Text = "Agregar Ciudadano";
            this.btnAgregarCiudadano.UseVisualStyleBackColor = true;
            this.btnAgregarCiudadano.Click += new System.EventHandler(this.btnAgregarCiudadano_Click);
            // 
            // btnConfirmarCarga
            // 
            this.btnConfirmarCarga.Location = new System.Drawing.Point(324, 189);
            this.btnConfirmarCarga.Name = "btnConfirmarCarga";
            this.btnConfirmarCarga.Size = new System.Drawing.Size(153, 44);
            this.btnConfirmarCarga.TabIndex = 3;
            this.btnConfirmarCarga.Text = "Confirmar Ciudadano";
            this.btnConfirmarCarga.UseVisualStyleBackColor = true;
            this.btnConfirmarCarga.Click += new System.EventHandler(this.btnConfirmarCarga_Click);
            // 
            // grbMensajeSist
            // 
            this.grbMensajeSist.BackColor = System.Drawing.Color.Transparent;
            this.grbMensajeSist.Controls.Add(this.lblMensajeSist);
            this.grbMensajeSist.Location = new System.Drawing.Point(11, 251);
            this.grbMensajeSist.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbMensajeSist.Name = "grbMensajeSist";
            this.grbMensajeSist.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbMensajeSist.Size = new System.Drawing.Size(761, 61);
            this.grbMensajeSist.TabIndex = 4;
            this.grbMensajeSist.TabStop = false;
            this.grbMensajeSist.Text = "Mensaje Del Sistema";
            // 
            // lblMensajeSist
            // 
            this.lblMensajeSist.AutoSize = true;
            this.lblMensajeSist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajeSist.ForeColor = System.Drawing.Color.Red;
            this.lblMensajeSist.Location = new System.Drawing.Point(115, 26);
            this.lblMensajeSist.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMensajeSist.Name = "lblMensajeSist";
            this.lblMensajeSist.Size = new System.Drawing.Size(177, 18);
            this.lblMensajeSist.TabIndex = 0;
            this.lblMensajeSist.Text = "Esperando Instruccion";
            // 
            // grbListaCiudadanos
            // 
            this.grbListaCiudadanos.BackColor = System.Drawing.Color.Transparent;
            this.grbListaCiudadanos.Controls.Add(this.btnModificar);
            this.grbListaCiudadanos.Controls.Add(this.btnBorrar);
            this.grbListaCiudadanos.Controls.Add(this.lstCiudadanos);
            this.grbListaCiudadanos.Location = new System.Drawing.Point(13, 318);
            this.grbListaCiudadanos.Name = "grbListaCiudadanos";
            this.grbListaCiudadanos.Size = new System.Drawing.Size(758, 162);
            this.grbListaCiudadanos.TabIndex = 5;
            this.grbListaCiudadanos.TabStop = false;
            this.grbListaCiudadanos.Text = "Lista de Ciudadanos";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(655, 20);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(85, 44);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar Ciudadano";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(655, 97);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(85, 44);
            this.btnBorrar.TabIndex = 7;
            this.btnBorrar.Text = "Borrar Ciudadano";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lstCiudadanos
            // 
            this.lstCiudadanos.FormattingEnabled = true;
            this.lstCiudadanos.Location = new System.Drawing.Point(7, 20);
            this.lstCiudadanos.Name = "lstCiudadanos";
            this.lstCiudadanos.Size = new System.Drawing.Size(624, 121);
            this.lstCiudadanos.TabIndex = 0;
            this.lstCiudadanos.SelectedIndexChanged += new System.EventHandler(this.lstCiudadanos_SelectedIndexChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(177, 486);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(189, 44);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfirmarModif
            // 
            this.btnConfirmarModif.Location = new System.Drawing.Point(483, 189);
            this.btnConfirmarModif.Name = "btnConfirmarModif";
            this.btnConfirmarModif.Size = new System.Drawing.Size(153, 44);
            this.btnConfirmarModif.TabIndex = 6;
            this.btnConfirmarModif.Text = "Confirmar Modificacion";
            this.btnConfirmarModif.UseVisualStyleBackColor = true;
            this.btnConfirmarModif.Click += new System.EventHandler(this.btnConfirmarModif_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(372, 486);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(189, 44);
            this.btnReporte.TabIndex = 7;
            this.btnReporte.Text = "Generar Informe Completo";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // FrmCiudadanos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voto_Electronico.Properties.Resources.FondoVE;
            this.ClientSize = new System.Drawing.Size(778, 621);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnConfirmarModif);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.grbListaCiudadanos);
            this.Controls.Add(this.grbMensajeSist);
            this.Controls.Add(this.btnConfirmarCarga);
            this.Controls.Add(this.btnAgregarCiudadano);
            this.Controls.Add(this.grbDatosPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCiudadanos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ciudadanos";
            this.Load += new System.EventHandler(this.Ciudadanos_Load);
            this.grbDatosPersona.ResumeLayout(false);
            this.grbDatosPersona.PerformLayout();
            this.grbMensajeSist.ResumeLayout(false);
            this.grbMensajeSist.PerformLayout();
            this.grbListaCiudadanos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosPersona;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtDocumento;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnAgregarCiudadano;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Button btnConfirmarCarga;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.GroupBox grbMensajeSist;
        private System.Windows.Forms.Label lblMensajeSist;
        private System.Windows.Forms.GroupBox grbListaCiudadanos;
        private System.Windows.Forms.ListBox lstCiudadanos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVolverInicio;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnConfirmarModif;
        private System.Windows.Forms.Button btnReporte;
    }
}