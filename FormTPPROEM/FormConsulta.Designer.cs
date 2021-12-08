
namespace FormTPPROEM
{
    partial class FormConsulta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
            this.lblPacientes = new System.Windows.Forms.Label();
            this.lblMedicos = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.lPacientes = new System.Windows.Forms.ListBox();
            this.lMedicos = new System.Windows.Forms.ListBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnEstadisticas = new System.Windows.Forms.Button();
            this.btnSiendoAtendidos = new System.Windows.Forms.Button();
            this.btnSalaEspera = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPacientes
            // 
            this.lblPacientes.AutoSize = true;
            this.lblPacientes.Location = new System.Drawing.Point(12, 67);
            this.lblPacientes.Name = "lblPacientes";
            this.lblPacientes.Size = new System.Drawing.Size(57, 15);
            this.lblPacientes.TabIndex = 2;
            this.lblPacientes.Text = "Pacientes";
            // 
            // lblMedicos
            // 
            this.lblMedicos.AutoSize = true;
            this.lblMedicos.Location = new System.Drawing.Point(456, 67);
            this.lblMedicos.Name = "lblMedicos";
            this.lblMedicos.Size = new System.Drawing.Size(52, 15);
            this.lblMedicos.TabIndex = 3;
            this.lblMedicos.Text = "Medicos";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(246)))), ((int)(((byte)(169)))));
            this.btnConsulta.FlatAppearance.BorderSize = 0;
            this.btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsulta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsulta.Image = global::FormTPPROEM.Properties.Resources.add1;
            this.btnConsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsulta.Location = new System.Drawing.Point(0, 0);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConsulta.Size = new System.Drawing.Size(169, 50);
            this.btnConsulta.TabIndex = 4;
            this.btnConsulta.Text = "Nueva\r\n Consulta";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // lPacientes
            // 
            this.lPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lPacientes.ForeColor = System.Drawing.SystemColors.Window;
            this.lPacientes.FormattingEnabled = true;
            this.lPacientes.ItemHeight = 15;
            this.lPacientes.Location = new System.Drawing.Point(12, 85);
            this.lPacientes.Name = "lPacientes";
            this.lPacientes.Size = new System.Drawing.Size(420, 394);
            this.lPacientes.TabIndex = 5;
            // 
            // lMedicos
            // 
            this.lMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(115)))), ((int)(((byte)(115)))));
            this.lMedicos.ForeColor = System.Drawing.SystemColors.Window;
            this.lMedicos.FormattingEnabled = true;
            this.lMedicos.ItemHeight = 15;
            this.lMedicos.Location = new System.Drawing.Point(456, 85);
            this.lMedicos.Name = "lMedicos";
            this.lMedicos.Size = new System.Drawing.Size(420, 394);
            this.lMedicos.TabIndex = 6;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(128)))), ((int)(((byte)(148)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Image = global::FormTPPROEM.Properties.Resources.minus2;
            this.btnFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalizar.Location = new System.Drawing.Point(0, 0);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(169, 50);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Terminar\r\nConsulta";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnEstadisticas
            // 
            this.btnEstadisticas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(213)))), ((int)(((byte)(250)))));
            this.btnEstadisticas.FlatAppearance.BorderSize = 0;
            this.btnEstadisticas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstadisticas.Image = global::FormTPPROEM.Properties.Resources.graph2;
            this.btnEstadisticas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstadisticas.Location = new System.Drawing.Point(0, 0);
            this.btnEstadisticas.Name = "btnEstadisticas";
            this.btnEstadisticas.Size = new System.Drawing.Size(164, 50);
            this.btnEstadisticas.TabIndex = 8;
            this.btnEstadisticas.Text = "   Estadisticas";
            this.btnEstadisticas.UseVisualStyleBackColor = false;
            this.btnEstadisticas.Click += new System.EventHandler(this.btnEstadisticas_Click);
            // 
            // btnSiendoAtendidos
            // 
            this.btnSiendoAtendidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(172)))), ((int)(((byte)(249)))));
            this.btnSiendoAtendidos.FlatAppearance.BorderSize = 0;
            this.btnSiendoAtendidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiendoAtendidos.Image = global::FormTPPROEM.Properties.Resources.patient3;
            this.btnSiendoAtendidos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSiendoAtendidos.Location = new System.Drawing.Point(0, 0);
            this.btnSiendoAtendidos.Name = "btnSiendoAtendidos";
            this.btnSiendoAtendidos.Size = new System.Drawing.Size(169, 52);
            this.btnSiendoAtendidos.TabIndex = 9;
            this.btnSiendoAtendidos.Text = "En Atencion";
            this.btnSiendoAtendidos.UseVisualStyleBackColor = false;
            this.btnSiendoAtendidos.Click += new System.EventHandler(this.btnEspera_Click);
            // 
            // btnSalaEspera
            // 
            this.btnSalaEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.btnSalaEspera.FlatAppearance.BorderSize = 0;
            this.btnSalaEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalaEspera.Image = global::FormTPPROEM.Properties.Resources.waiting3;
            this.btnSalaEspera.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalaEspera.Location = new System.Drawing.Point(0, 0);
            this.btnSalaEspera.Name = "btnSalaEspera";
            this.btnSalaEspera.Size = new System.Drawing.Size(169, 50);
            this.btnSalaEspera.TabIndex = 10;
            this.btnSalaEspera.Text = "   Sala Espera";
            this.btnSalaEspera.UseVisualStyleBackColor = false;
            this.btnSalaEspera.Click += new System.EventHandler(this.btnSalaEspera_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 51);
            this.panel1.TabIndex = 11;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel5.Controls.Add(this.btnEstadisticas);
            this.panel5.Location = new System.Drawing.Point(712, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(169, 50);
            this.panel5.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel4.Controls.Add(this.btnSiendoAtendidos);
            this.panel4.Location = new System.Drawing.Point(537, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(169, 50);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel3.Controls.Add(this.btnSalaEspera);
            this.panel3.Location = new System.Drawing.Point(362, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(169, 50);
            this.panel3.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.btnFinalizar);
            this.panel2.Location = new System.Drawing.Point(187, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(169, 50);
            this.panel2.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel6.Controls.Add(this.btnConsulta);
            this.panel6.Location = new System.Drawing.Point(12, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(169, 50);
            this.panel6.TabIndex = 12;
            // 
            // FormConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(888, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lMedicos);
            this.Controls.Add(this.lPacientes);
            this.Controls.Add(this.lblMedicos);
            this.Controls.Add(this.lblPacientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultorio Online";
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPacientes;
        private System.Windows.Forms.Label lblMedicos;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.ListBox lPacientes;
        private System.Windows.Forms.ListBox lMedicos;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnEstadisticas;
        private System.Windows.Forms.Button btnSiendoAtendidos;
        private System.Windows.Forms.Button btnSalaEspera;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel6;
    }
}

