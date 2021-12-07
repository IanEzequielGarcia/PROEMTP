using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibliotecas
{
    public static class Estadisticas
    {
        /// <summary>
        /// Calcula el medico que mas atendio, el que menos atendio, Los ordena de mayor a menor, y muestra la estadistica que mas atendio
        /// </summary>
        /// <param name="ListaMedicos"></param>
        /// <param name="contadorMedico"></param>
        /// <param name="contadorEspecialidad"></param>
        /// <returns></returns>
        public static string CalcularEstadisticas(List<Medico> ListaMedicos, List<int> contadorMedico, Dictionary<string, int> contadorEspecialidad)
        {
            StringBuilder stringBuilder = new StringBuilder();
            int indexMax = 0;
            int indexMin = 0;
            int numeroMax = int.MinValue;
            int numeroMin = int.MaxValue;
            List<int> listaAux = new List<int>(contadorMedico);

            contadorMedico.Sort();
            for (int i = ListaMedicos.Count - 1; i >= 0; i--)
            {
                int auxIndex = listaAux.FindIndex(x => x == contadorMedico[i]);
                stringBuilder.Append($"{ListaMedicos[auxIndex].Nombre} Atendio : {contadorMedico[i]}\n");

                if (numeroMin > contadorMedico[i])
                {
                    numeroMin = contadorMedico[i];
                    indexMin = auxIndex;
                }
                if (numeroMax < contadorMedico[i])
                {
                    indexMax = auxIndex;
                    numeroMax = contadorMedico[i];
                }
            }
            //var (max, indexMax) = contadorMedico.Select((n, i) => (n, i)).Max();
            //var (min, indexMin) = contadorMedico.Select((n, i) => (n, i)).Min();
            stringBuilder.Append($"Doctor que mas atendio:  {ListaMedicos[indexMax].Nombre} - {numeroMax}\n");


            int especialidadMax = contadorEspecialidad.Values.Max();
            stringBuilder.Append($"Especialidad que mas atendio: {contadorEspecialidad.FirstOrDefault(x => x.Value == especialidadMax).Key} {especialidadMax} \n");

            /*foreach (KeyValuePair<string, int> aux in contadorEspecialidad)
            {
                stringBuilder.Append($"Especialidad: {aux.Key} {aux.Value} \n");
                //Console.WriteLine("Key: {0}, Value: {1}", author.Key, author.Value);
            }*/
            stringBuilder.Append($"Doctor que menos atendio:  {ListaMedicos[indexMin].Nombre} - {numeroMin} \n");

            return stringBuilder.ToString();
        }
    }
}
