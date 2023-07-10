using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Paciente
    {
        public string nome { get; set; }
        public string dataNascimento { get; set; }
        public string cpf { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }
        public string sexo { get; set; }

        public Paciente(string nome, string dataNascimento, string cpf, string endereco, string telefone, string sexo)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.sexo = sexo;

        }


    }

}
