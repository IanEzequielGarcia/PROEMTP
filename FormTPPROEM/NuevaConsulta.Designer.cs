
namespace FormTPPROEM
{
    partial class NuevaConsulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevaConsulta));
            this.txtNombreMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreMedico
            // 
            this.txtNombreMedico.Location = new System.Drawing.Point(12, 27);
            this.txtNombreMedico.Name = "txtNombreMedico";
            this.txtNombreMedico.Size = new System.Drawing.Size(290, 23);
            this.txtNombreMedico.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del medico o especialidad";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(92, 56);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(134, 23);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar Medico";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // NuevaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(316, 84);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreMedico);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NuevaConsulta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAsignar;
    }
}