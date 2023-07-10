using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Pessoa
    {
        public string nome { get; set; }
        public string nascimento { get; set; }
        public string cpf { get; set; }
        public string sexo { get; set; }
        public string endereco { get; set; }
        public string telefone { get; set; }

        public void atualizarDados(string endereco, string sexo)
        {
            this.endereco = endereco;
            this.sexo = sexo;

        }

        
    }
}
