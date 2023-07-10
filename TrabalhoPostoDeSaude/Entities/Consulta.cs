using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Consulta
    {
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public Consulta(Medico medico, Paciente paciente, DateTime dataInicio, DateTime dataFim)
        {
            Medico = medico;
            Paciente = paciente;
            DataInicio = dataInicio;
            DataFim = dataFim;
        }

        public void GerarDiagnostico()
        {
            Console.WriteLine("Gerando diagnóstico...");
        }

        public void AgendarRetorno()
        {
            Console.WriteLine("Agendando retorno...");
        }
    }
}
