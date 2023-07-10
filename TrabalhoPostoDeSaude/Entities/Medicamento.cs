using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Medicamento
    {
        public string Nome { get; set; }
        public string Dosagem { get; set; }

        public Medicamento(string nome, string dosagem)
        {
            Nome = nome;
            Dosagem = dosagem;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"\tNome do Medicamento: {Nome}");
            Console.WriteLine($"\tDosagem: {Dosagem}"); 
        }
    }
}
