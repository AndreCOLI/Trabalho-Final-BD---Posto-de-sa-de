using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class HistoricoConsulta
    {
        private List<Consulta> consultas;

        public HistoricoConsulta()
        {
            consultas = new List<Consulta>();
        }

        public void AdicionarConsulta(Consulta consulta)
        {
            consultas.Add(consulta);
        }

        public void ImprimirHistorico()
        {
            Console.WriteLine("Histórico de Consultas:");
            foreach (Consulta consulta in consultas)
            {
                Console.WriteLine($"Médico: {consulta.Medico.nome}, Paciente: {consulta.Paciente.nome}");
            }
        }
    }
}
