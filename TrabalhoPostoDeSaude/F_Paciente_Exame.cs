using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using TrabalhoPostoDeSaude.Entities;

namespace TrabalhoPostoDeSaude
{
    public partial class F_Paciente_Exame : Form
    {
        public List<Exame> Exame_aux = new List<Exame>();
        public List<int> ids = new List<int>();
        Form_Pacientes FP;
        MySqlCommand comandosql;
        MySqlDataReader reader;
        MySqlConnection conexao;
        bool existe = false;
        string cpf;

        public F_Paciente_Exame(string cpf, MySqlConnection conexao, MySqlCommand comandosql, Form_Pacientes FP)
        {
            InitializeComponent();
            this.FP = FP;
            this.conexao = conexao;
            this.comandosql = comandosql;
            this.cpf = cpf;
        }

        private void F_Paciente_Exame_Load(object sender, EventArgs e)
        {
            FP.Hide();


            string sql = "SELECT e.*, pe.nome FROM Medico as m, pessoa as pe, exame as e, paciente as pa where pa.cpf_pessoa_paciente = pe.cpf_pessoa and e.cpf_pessoa_paciente = pa.cpf_pessoa_paciente and e.cpf_pessoa_medico = m.cpf_pessoa_medico; ";
            comandosql = new MySqlCommand(sql, conexao);
            reader = comandosql.ExecuteReader();


            while (reader.Read())
            {
                    ids.Add(int.Parse(reader.GetString(0)));
                if (cpf == reader.GetString(2)) {

                    string nome_paciente_aux = reader.GetString(5);
                    string id_aux = reader.GetString(0);
                    string cpf_medico_aux = reader.GetString(1);
                    string cpf_paciente_aux = reader.GetString(2);
                    string nome_exame_aux = reader.GetString(3);
                    string data_entrega_aux = reader.GetString(4);

                    
                    Exame exameaux = new Exame(nome_paciente_aux, id_aux, cpf_medico_aux, cpf_paciente_aux, nome_exame_aux, data_entrega_aux);
                    Exame_aux.Add(exameaux);

                    DateTime data = new DateTime();
                    data = DateTime.Parse(reader.GetString(4));
                    lb_lista_exames.Items.Add(reader.GetString(3) + ", entrega em: " + data.Date);
                    
                    
               }

            }
            reader.Close();


        }

        private void F_Paciente_Exame_FormClosed(object sender, FormClosedEventArgs e)
        {
            FP.Show();
        }

        private void btn_pac_exames_inserir_Click(object sender, EventArgs e)
        {
            if (tb1_nome_exame.Text == "" || tb2_data_exame.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
  
                for (int i = 0; i < ids.Count; i++)
                {
                    if (int.Parse(tb_id_exame.Text) == ids[i])
                    {
                        
                        MessageBox.Show("Código de exame já existente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                    }

                }

                if (existe == false)
                {
                    comandosql = new MySqlCommand("INSERT INTO Exame (id_exame, cpf_pessoa_medico, cpf_pessoa_paciente, nome_exame, data_entrega) VALUES (?,?,?,?,?); ", conexao);
                    comandosql.Parameters.Add("@id_exame", MySqlDbType.Int32, 3).Value = int.Parse(tb_id_exame.Text);
                    comandosql.Parameters.Add("@cpf_pessoa_medico", MySqlDbType.VarChar, 11).Value = tb_cpf_med.Text;
                    comandosql.Parameters.Add("@cpf_pessoa_paciente", MySqlDbType.VarChar, 11).Value = cpf;
                    comandosql.Parameters.Add("@nome_exame", MySqlDbType.VarChar, 100).Value = tb1_nome_exame.Text;
                    DateTime data = new DateTime();
                    DateTime.TryParse(tb2_data_exame.Text, out data);  
                    comandosql.Parameters.Add("@data_entrega", MySqlDbType.Date).Value = data.Date;
                    comandosql.ExecuteNonQuery();
                    lb_lista_exames.Items.Add("Exame " + tb1_nome_exame.Text + ", entrega em: " + tb2_data_exame.Text);
                    MessageBox.Show("Exame inserido com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
               
            }
                
        }
    }
}
