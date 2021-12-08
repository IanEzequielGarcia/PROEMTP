using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bibliotecas;

namespace FormTPPROEM
{
    public partial class NuevaConsulta : Form
    {
        public List<Paciente> ListaPacientes;
        public List<Medico> ListaMedicos;
        public int medicoId;
        public NuevaConsulta(List<Medico> ListaMedicos,List<Paciente> ListaPacientes)
        {
            InitializeComponent();
            this.ListaPacientes=ListaPacientes;
            this.ListaMedicos=ListaMedicos;
            this.medicoId = -1;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            string ingresado = this.txtNombreMedico.Text;
            int contador = 0;
            this.DialogResult = DialogResult.OK;
            foreach (Medico medico in ListaMedicos)
            {
                if ((medico.Especialidad == ingresado || medico.Nombre == ingresado))
                {
                    this.medicoId = contador;
                    if (medico.Ocupado == false)
                    {
                        break;
                    }
                    else 
                    {
                        this.DialogResult = DialogResult.No;
                        break;
                    }
                }
                contador++;
            }
        }
    }
}
