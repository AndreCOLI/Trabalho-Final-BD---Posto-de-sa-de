using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Medico:Pessoa
    {
        public string crm { get; set; }
        public string especialidade { get; set; }
        public double salario { get; set; }
       


        public Medico(string nome, string nascimento, string cpf, string endereco, string telefone, string crm, string especialidade, double salario)
        {
            this.nome = nome;
            this.nascimento = nascimento;
            this.cpf = cpf;
            this.endereco = endereco;
            this.telefone = telefone;
            this.crm = crm;
            this.especialidade = especialidade;
            this.salario = salario;
        }



        public void mostrarDados()
        {
            string mensagem;
            mensagem = "O nome é" + this.nome;
            
        }
    }
}
