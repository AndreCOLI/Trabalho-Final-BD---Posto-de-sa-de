using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Endereco
    {
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
   
        public Endereco(string logradouro, string numero, string bairro, string municipio, string estado)
        {
            this.logradouro = logradouro;
            this.numero = numero;
            this.bairro = bairro;
            this.municipio = municipio;
            this.estado = estado;


        }

        public void alterarEndereco()
        {

        }


    }
}
