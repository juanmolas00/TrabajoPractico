namespace Voto_Electronico
{
    partial class FrmInicio
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicioJuez = new System.Windows.Forms.Button();
            this.btnInicioVotante = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Por favor seleccione el modulo a usar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(336, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido al Sistema de Voto Electronico";
            // 
            // btnInicioJuez
            // 
            this.btnInicioJuez.Location = new System.Drawing.Point(280, 411);
            this.btnInicioJuez.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioJuez.Name = "btnInicioJuez";
            this.btnInicioJuez.Size = new System.Drawing.Size(433, 64);
            this.btnInicioJuez.TabIndex = 3;
            this.btnInicioJuez.Text = "Consultas";
            this.btnInicioJuez.UseVisualStyleBackColor = true;
            this.btnInicioJuez.Click += new System.EventHandler(this.btnInicioJuez_Click);
            // 
            // btnInicioVotante
            // 
            this.btnInicioVotante.Location = new System.Drawing.Point(280, 311);
            this.btnInicioVotante.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInicioVotante.Name = "btnInicioVotante";
            this.btnInicioVotante.Size = new System.Drawing.Size(433, 64);
            this.btnInicioVotante.TabIndex = 2;
            this.btnInicioVotante.Text = "Ciudadanos";
            this.btnInicioVotante.UseVisualStyleBackColor = true;
            this.btnInicioVotante.Click += new System.EventHandler(this.btnInicioVotante_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(417, 510);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(152, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Voto_Electronico.Properties.Resources.FondoVE;
            this.ClientSize = new System.Drawing.Size(1037, 764);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInicioJuez);
            this.Controls.Add(this.btnInicioVotante);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDecision";
            this.Load += new System.EventHandler(this.FrmInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicioJuez;
        private System.Windows.Forms.Button btnInicioVotante;
        private System.Windows.Forms.Button btnSalir;
    }
}