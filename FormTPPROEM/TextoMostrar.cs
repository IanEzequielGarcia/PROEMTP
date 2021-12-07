using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTPPROEM
{
    public partial class TextoMostrar : Form
    {
        public TextoMostrar(string texto)
        {
            InitializeComponent();
            try
            {
                this.txtAtendidos.Text = texto;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
