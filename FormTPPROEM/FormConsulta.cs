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
    public partial class FormConsulta : Form
    {
        public ListaPersonas<Medico> ListaMedicos;
        public ListaPersonas<Paciente> ListaPacientes;
        private List<string> respuesta;
        private List<int> contadorMedico;
        private Dictionary<string, int> contadorEspecialidad;

        public FormConsulta()
        {
            InitializeComponent();
            this.ListaPacientes = new ListaPersonas<Paciente>();
            this.ListaMedicos = new ListaPersonas<Medico>();
            this.respuesta = new List<string>();
            this.contadorMedico = new List<int>();
            this.contadorEspecialidad = new Dictionary<string,int>();

            #region Hardcodeo
            Paciente paciente = new Paciente(1, "Juan", "Perez", 15, ObraSocial.NoTiene);
            Paciente paciente2 = new Paciente(2, "Juana", "Pereza", 25, ObraSocial.CoberturaBasica);
            Paciente paciente3 = new Paciente(3, "Juanito", "Pereyra", 35, ObraSocial.CobreturaCompleta);

            this.ListaPacientes = this.ListaPacientes + paciente;
            this.ListaPacientes = this.ListaPacientes + paciente2;
            this.ListaPacientes = this.ListaPacientes + paciente3;

            Medico medico = new Medico("Hipocrates", "de Cos", "medicina clinica");
            Medico medico2 = new Medico("Robert", "Koch", "microbiologo");
            Medico medico3 = new Medico("Rene", "Favaloro", "cardiocirujano");

            this.ListaMedicos = this.ListaMedicos + medico;
            this.ListaMedicos = this.ListaMedicos + medico2;
            this.ListaMedicos = this.ListaMedicos + medico3;

            respuesta.Add("Nada grave, se fue a casa");
            respuesta.Add("Tomar las pastillas indicadas por el doctor");
            respuesta.Add("Operacion de urgencia");
            respuesta.Add("Delegado al enfermero");
            respuesta.Add("Enviado a la guardia");
            respuesta.Add("Derivado a otro hospital");
            respuesta.Add("Realizar estudios del corazon");
            respuesta.Add("Internado");
            respuesta.Add("Tratamiento por dos meses");
            respuesta.Add("Hacer reposo");

            #endregion

            CargarMedicos();
            CargarPacientes();
            InicializarEstadisticas();
        }
        /// <summary>
        /// Crea una nueva consulta al primer paciente libre en la lista y le agrega el medico elegido,
        /// si el medico se encuentra ocupado lo agrega a la lista de espera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConsulta_Click(object sender, EventArgs e)
        {
            NuevaConsulta form = new NuevaConsulta(this.ListaMedicos.Elementos,this.ListaPacientes.Elementos);
            int atendido = 0;
            if (this.ListaPacientes.Elementos.Count > 0)
            {
                form.ShowDialog();
                if (form.DialogResult == DialogResult.OK)
                {
                    if (form.medicoId != -1)
                    {
                        for (int i = 0; i < this.ListaPacientes.Elementos.Count; i++)
                        {
                            if (this.ListaPacientes.Elementos[i] != null && this.ListaPacientes.Elementos[i].Ocupado == false)
                            {
                                (this.ListaMedicos.Elementos.ElementAt(form.medicoId)).Ocupado = true;
                                this.contadorMedico[form.medicoId]++;
                                this.contadorEspecialidad[this.ListaMedicos.Elementos.ElementAt(form.medicoId).Especialidad]++;
                                (this.ListaMedicos.Elementos.ElementAt(form.medicoId)).listaEspera.Add(this.ListaPacientes.Elementos[i]);
                                this.ListaPacientes.Elementos[i].Ocupado = true;
                                atendido = 1;
                                break;
                            }
                        }
                        CargarMedicos();
                    }
                    else
                    {
                        MessageBox.Show("El medico no fue encontrado");
                    }
                }
                else if (form.DialogResult == DialogResult.No)
                {
                    if(MessageBox.Show("El medico esta ocupado, agregar a la lista de espera?", "importante",MessageBoxButtons.YesNo)==DialogResult.Yes)
                    {
                        for (int i = 0; i < this.ListaPacientes.Elementos.Count; i++)
                        {
                            if (this.ListaPacientes.Elementos[i] != null && this.ListaPacientes.Elementos[i].Ocupado == false)
                            {
                                //(this.ListaMedicos.Elementos.ElementAt(form.medicoId)).idAtendido = this.ListaPacientes.Elementos[i].Dni;
                                (this.ListaMedicos.Elementos.ElementAt(form.medicoId)).listaEspera.Add(this.ListaPacientes.Elementos[i]);
                                this.ListaPacientes.Elementos[i].Ocupado = true;
                                this.contadorMedico[form.medicoId]++;
                                this.contadorEspecialidad[this.ListaMedicos.Elementos.ElementAt(form.medicoId).Especialidad]++;
                                atendido = 1;
                                break;
                            }
                        }
                        CargarMedicos();
                    }
                    //MessageBox.Show("El medico esta ocupado");
                }
                if(atendido==0 && (form.DialogResult != DialogResult.Cancel && form.DialogResult != DialogResult.No))
                {
                    MessageBox.Show("Todos los pacientes estan siendo atendidos");
                }
            }
            else 
            {
                MessageBox.Show("No hay nadie para atender");
            }
        }
        /// <summary>
        /// carga los medicos en ListaMedicos a ListBoxMedicos
        /// </summary>
        private void CargarMedicos()
        {
            this.lMedicos.DataSource = null;
            List<string> medicos = new List<string>();
            foreach(Medico medico in this.ListaMedicos.Elementos)
            {
                medicos.Add((string)medico);
            }
            this.lMedicos.DataSource = medicos;
        }
        /// <summary>
        /// carga los pacientes en ListaPacientes a ListBoxPacientes
        /// </summary>
        private void CargarPacientes()
        {
            this.lPacientes.DataSource = null;
            List<string> pacientes = new List<string>();
            foreach(Paciente paciente in this.ListaPacientes.Elementos)
            {
                pacientes.Add((string)paciente);
            }
            this.lPacientes.DataSource = pacientes;
        }
        /// <summary>
        /// BUSCA AL PACIENTE QUE ESTA SIENDO ATENDIDO POR EL MEDICO Y TERMINA LA CONSULTA, LUEGO DA UNA RESPUESTA ALEATORIA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                NuevaConsulta form = new NuevaConsulta(this.ListaMedicos.Elementos, this.ListaPacientes.Elementos);
                form.ShowDialog();
                if (form.medicoId>=0&&(this.ListaMedicos.Elementos.ElementAt(form.medicoId)).Ocupado != false)
                {
                    foreach (Paciente pacientes in this.ListaPacientes.Elementos)
                    {
                        if ((this.ListaMedicos.Elementos.ElementAt(form.medicoId)).listaEspera.Contains(pacientes))
                        {
                            this.ListaPacientes = this.ListaPacientes - pacientes;
                            (this.ListaMedicos.Elementos.ElementAt(form.medicoId)).listaEspera.Remove(pacientes);
                            if ((this.ListaMedicos.Elementos.ElementAt(form.medicoId)).listaEspera.Count == 0)
                            {
                                (this.ListaMedicos.Elementos.ElementAt(form.medicoId)).Ocupado = false;
                            }
                            break;
                        }
                    
                        /*if(pacientes.Dni ==(this.ListaMedicos.Elementos.ElementAt(this.lMedicos.SelectedIndex)).idAtendido)
                        {
                                this.ListaPacientes= this.ListaPacientes-pacientes;
                                (this.ListaMedicos.Elementos.ElementAt(this.lMedicos.SelectedIndex)).idAtendido = -1;
                                break;
                        }*/
                    }
                    //this.ListaPacientes.RemoveAt((this.ListaMedicos.Elementos.ElementAt(this.lMedicos.SelectedIndex)).idAtendido);
                    Random r = new Random();
                    int index = r.Next(this.respuesta.Count);

                    MessageBox.Show("Consulta Finalizada, " + this.respuesta[index]);
                    CargarMedicos();
                    CargarPacientes();
                }
                else
                {
                    MessageBox.Show("No hay ninguna consulta para finalizar");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        /// <summary>
        /// Estadisticas historicas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Estadisticas.CalcularEstadisticas(this.ListaMedicos.Elementos, this.contadorMedico, this.contadorEspecialidad));
        }
        private void InicializarEstadisticas()
        {
            for(int i=0; i < this.ListaMedicos.Elementos.Count;i++)
            {
                this.contadorMedico.Add(0);
                this.contadorEspecialidad.Add(this.ListaMedicos.Elementos.ElementAt(i).Especialidad, 0);
            }
        }
        /// <summary>
        /// Lista de los pacientes que estan siendo atendidos actualmente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEspera_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i=0;i<this.ListaMedicos.Elementos.Count;i++)
            {
                if (this.ListaMedicos.Elementos[i].listaEspera.Count > 0)
                {
                    int idAux = this.ListaPacientes.Elementos.IndexOf(this.ListaMedicos.Elementos[i].listaEspera[0]);
                    stringBuilder.AppendLine($"{this.ListaPacientes.Elementos[idAux].Nombre} {this.ListaPacientes.Elementos[idAux].Apellido}" +
                    $" esta siendo atendido por {this.ListaMedicos.Elementos[i].Nombre} {this.ListaMedicos.Elementos[i].Apellido}");
                }
            }
            if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
            {
                stringBuilder.AppendLine("Nadie esta siendo atendido actualmente");
            }
            TextoMostrar siendoAtendidos = new TextoMostrar(stringBuilder.ToString());
            siendoAtendidos.Show();
        }
        /// <summary>
        /// Lista de los pacientes que estan en la lista de espera
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalaEspera_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < this.ListaMedicos.Elementos.Count; i++)
            {
                if (this.ListaMedicos.Elementos[i].listaEspera.Count > 1)
                {
                    for (int z = 1; z < this.ListaMedicos.Elementos[i].listaEspera.Count; z++)
                    {
                        int idAux = this.ListaPacientes.Elementos.IndexOf(this.ListaMedicos.Elementos[i].listaEspera[z]);
                        stringBuilder.AppendLine($"{this.ListaPacientes.Elementos[idAux].Nombre} {this.ListaPacientes.Elementos[idAux].Apellido}" +
                        $" esta en la lista de espera de {this.ListaMedicos.Elementos[i].Nombre} {this.ListaMedicos.Elementos[i].Apellido}");
                    }
                }
            }
            if (string.IsNullOrWhiteSpace(stringBuilder.ToString()))
            {
                stringBuilder.AppendLine("La lista de espera esta vacia");
            }
            TextoMostrar siendoAtendidos = new TextoMostrar(stringBuilder.ToString());
            siendoAtendidos.Show();
        }
    }
}
