
namespace FormTPPROEM
{
    partial class TextoMostrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextoMostrar));
            this.txtAtendidos = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtAtendidos
            // 
            this.txtAtendidos.BackColor = System.Drawing.SystemColors.Control;
            this.txtAtendidos.Location = new System.Drawing.Point(1, 2);
            this.txtAtendidos.Name = "txtAtendidos";
            this.txtAtendidos.Size = new System.Drawing.Size(395, 447);
            this.txtAtendidos.TabIndex = 0;
            this.txtAtendidos.Text = "";
            // 
            // TextoMostrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.txtAtendidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TextoMostrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtAtendidos;
    }
}