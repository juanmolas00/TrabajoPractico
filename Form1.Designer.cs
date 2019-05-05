namespace Voto_Electronico
{
    partial class FormInforme
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ciudadanosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votoElectronico_V2DataSet1 = new Voto_Electronico.VotoElectronico_V2DataSet();
            this.btnVolverRepo = new System.Windows.Forms.Button();
            this.ciudadanosTableAdapter = new Voto_Electronico.VotoElectronico_V2DataSetTableAdapters.CiudadanosTableAdapter();
            this.votoElectronico_V2DataSet11 = new Voto_Electronico.VotoElectronico_V2DataSet1();
            this.candidatosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatosTableAdapter = new Voto_Electronico.VotoElectronico_V2DataSet1TableAdapters.CandidatosTableAdapter();
            this.candidatosVotosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.votosTableAdapter = new Voto_Electronico.VotoElectronico_V2DataSet1TableAdapters.VotosTableAdapter();
            this.votoElectronicoV2DataSet11BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dNIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ciudadanosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ciudadanosTableAdapter1 = new Voto_Electronico.VotoElectronico_V2DataSet1TableAdapters.CiudadanosTableAdapter();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id_Barrio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id_depto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronico_V2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronico_V2DataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosVotosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronicoV2DataSet11BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dNIDataGridViewTextBoxColumn,
            this.Nombre,
            this.Apellido,
            this.Sexo,
            this.Id_Barrio,
            this.Id_depto,
            this.Direccion});
            this.dataGridView1.DataSource = this.ciudadanosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1032, 671);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ciudadanosBindingSource
            // 
            this.ciudadanosBindingSource.DataMember = "Ciudadanos";
            this.ciudadanosBindingSource.DataSource = this.votoElectronico_V2DataSet1;
            // 
            // votoElectronico_V2DataSet1
            // 
            this.votoElectronico_V2DataSet1.DataSetName = "VotoElectronico_V2DataSet";
            this.votoElectronico_V2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnVolverRepo
            // 
            this.btnVolverRepo.Location = new System.Drawing.Point(389, 715);
            this.btnVolverRepo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVolverRepo.Name = "btnVolverRepo";
            this.btnVolverRepo.Size = new System.Drawing.Size(125, 36);
            this.btnVolverRepo.TabIndex = 1;
            this.btnVolverRepo.Text = "Volver";
            this.btnVolverRepo.UseVisualStyleBackColor = true;
            this.btnVolverRepo.Click += new System.EventHandler(this.btnVolverRepo_Click);
            // 
            // ciudadanosTableAdapter
            // 
            this.ciudadanosTableAdapter.ClearBeforeFill = true;
            // 
            // votoElectronico_V2DataSet11
            // 
            this.votoElectronico_V2DataSet11.DataSetName = "VotoElectronico_V2DataSet1";
            this.votoElectronico_V2DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // candidatosBindingSource
            // 
            this.candidatosBindingSource.DataMember = "Candidatos";
            this.candidatosBindingSource.DataSource = this.votoElectronico_V2DataSet11;
            // 
            // candidatosTableAdapter
            // 
            this.candidatosTableAdapter.ClearBeforeFill = true;
            // 
            // candidatosVotosBindingSource
            // 
            this.candidatosVotosBindingSource.DataMember = "CandidatosVotos";
            this.candidatosVotosBindingSource.DataSource = this.candidatosBindingSource;
            // 
            // votosTableAdapter
            // 
            this.votosTableAdapter.ClearBeforeFill = true;
            // 
            // votoElectronicoV2DataSet11BindingSource
            // 
            this.votoElectronicoV2DataSet11BindingSource.DataSource = this.votoElectronico_V2DataSet11;
            this.votoElectronicoV2DataSet11BindingSource.Position = 0;
            // 
            // dNIDataGridViewTextBoxColumn
            // 
            this.dNIDataGridViewTextBoxColumn.DataPropertyName = "DNI";
            this.dNIDataGridViewTextBoxColumn.HeaderText = "DNI";
            this.dNIDataGridViewTextBoxColumn.Name = "dNIDataGridViewTextBoxColumn";
            // 
            // ciudadanosBindingSource1
            // 
            this.ciudadanosBindingSource1.DataMember = "Ciudadanos";
            this.ciudadanosBindingSource1.DataSource = this.votoElectronicoV2DataSet11BindingSource;
            // 
            // ciudadanosTableAdapter1
            // 
            this.ciudadanosTableAdapter1.ClearBeforeFill = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Sexo
            // 
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // Id_Barrio
            // 
            this.Id_Barrio.DataPropertyName = "Id_Barrio";
            this.Id_Barrio.HeaderText = "Id_Barrio";
            this.Id_Barrio.Name = "Id_Barrio";
            // 
            // Id_depto
            // 
            this.Id_depto.DataPropertyName = "Id_depto";
            this.Id_depto.HeaderText = "Id_depto";
            this.Id_depto.Name = "Id_depto";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // FormInforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voto_Electronico.Properties.Resources.FondoVE;
            this.ClientSize = new System.Drawing.Size(1035, 766);
            this.Controls.Add(this.btnVolverRepo);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormInforme";
            this.Text = "Informe De Ciudadanos";
            this.Load += new System.EventHandler(this.FormInforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronico_V2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronico_V2DataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatosVotosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.votoElectronicoV2DataSet11BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciudadanosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private VotoElectronico_V2DataSet votoElectronico_V2DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnVolverRepo;
        private System.Windows.Forms.BindingSource ciudadanosBindingSource;
        private VotoElectronico_V2DataSetTableAdapters.CiudadanosTableAdapter ciudadanosTableAdapter;
        private VotoElectronico_V2DataSet1 votoElectronico_V2DataSet11;
        private System.Windows.Forms.BindingSource candidatosBindingSource;
        private VotoElectronico_V2DataSet1TableAdapters.CandidatosTableAdapter candidatosTableAdapter;
        private System.Windows.Forms.BindingSource candidatosVotosBindingSource;
        private VotoElectronico_V2DataSet1TableAdapters.VotosTableAdapter votosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dNIDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource votoElectronicoV2DataSet11BindingSource;
        private System.Windows.Forms.BindingSource ciudadanosBindingSource1;
        private VotoElectronico_V2DataSet1TableAdapters.CiudadanosTableAdapter ciudadanosTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Barrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_depto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
    }
}