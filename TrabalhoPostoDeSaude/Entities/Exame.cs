using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Exame
    {
        public string nome_paciente { get; set; }
        public string id { get; set; }
        public string cpf_medico { get; set; }
        public string cpf_paciente { get; set; }
        public string nome_exame { get; set; }
        public string data_entrega { get; set; }

        public Exame(string nome_paciente, string id, string cpf_medico, string cpf_paciente, string nome_exame, string data_entrega)
        {
            this.nome_paciente = nome_paciente;
            this.id = id;
            this.cpf_medico = cpf_medico;
            this.cpf_paciente = cpf_paciente;
            this.nome_exame = nome_exame;
            this.data_entrega = data_entrega;
        }

    }

    
}
