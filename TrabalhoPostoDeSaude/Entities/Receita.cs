using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPostoDeSaude.Entities
{
    public class Receita
    {
        private List<Medicamento> medicamentos;
        private string observacao;
        private DateTime data;

        public Receita()
        {
            medicamentos = new List<Medicamento>();
        }

        public void GerarReceita()
        {
            Console.WriteLine("\n\n- GERANDO RECEITA -");

            Console.Write("\n\tO Paciente está em Observação (sim ou não): ");
            string observacao = Console.ReadLine();

            // Validar a entrada da observação
            while (!observacao.Equals("sim", StringComparison.OrdinalIgnoreCase) &&
                !observacao.Equals("não", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("\t\tEntrada inválida. Digite 'sim' ou 'não'.");
                Console.Write("\tObservação (sim ou não): ");
                observacao = Console.ReadLine();
            }

            this.observacao = observacao;

            Console.Write("\n\tDigite a quantidade de medicamentos prescritos: ");
            int quantidadeMedicamentos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\tInsira os medicamentos prescritos:");

            for (int i = 0; i < quantidadeMedicamentos; i++)
            {
                Console.WriteLine($"\n\tMedicamento {i + 1}:");
                Console.Write("\n\t\tNome: ");
                string nome = Console.ReadLine();

                // Validar o nome do medicamento
                while (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("\t\tNome inválido. Digite novamente.");
                    Console.Write("\n\t\tNome: ");
                    nome = Console.ReadLine();
                }

                Console.Write("\t\tDosagem: ");
                string dosagem = Console.ReadLine();

                // Validar a dosagem do medicamento
                while (!double.TryParse(dosagem, out _))
                {
                    Console.WriteLine("\t\tDosagem inválida. Digite novamente.");
                    Console.Write("\t\tDosagem: ");
                    dosagem = Console.ReadLine();
                }

                Medicamento medicamento = new Medicamento(nome, dosagem);
                medicamentos.Add(medicamento);
            }

            Console.WriteLine("\n\tMedicamentos prescritos:");
            foreach (Medicamento medicamento in medicamentos)
            {
                medicamento.ExibirInformacoes();
            }
        }
    }
}

