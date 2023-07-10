using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Enfermeiro:Pessoa
    {

        public string formacao { get; set; }
        public string sexo { get; set; }
        public string email { get; set; }

        public Enfermeiro(string nome, string nascimento, string cpf, string sexo, string endereco, string telefone, string email, string formacao) {

            this.nome = nome;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.sexo = sexo;
            this.endereco = endereco;
            this.telefone = telefone;
            this.email = email;
            this.formacao = formacao;
        
        
        
        }


    }
}
