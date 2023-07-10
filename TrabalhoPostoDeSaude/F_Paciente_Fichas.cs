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

namespace TrabalhoPostoDeSaude
{
    public partial class F_Paciente_Fichas : Form
    {
        bool existe = false;
        string cpf;
        string nome;
        MySqlConnection conexao;
        MySqlCommand comandosql;
        Form_Pacientes FP;
        MySqlDataReader reader;
        public List<int> ids = new List<int>();
        public F_Paciente_Fichas(string nome, string cpf, MySqlConnection conexao, MySqlCommand comandosql, Form_Pacientes FP)
        {
            InitializeComponent();
            this.cpf = cpf;
            this.conexao = conexao;
            this.comandosql = comandosql;
            this.FP = FP;
            this.nome = nome;


        }

        private void btn_pac_fichas_inserir_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "" || tb_peso.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    if (int.Parse(tb_id.Text) == ids[i])
                    {

                        MessageBox.Show("Id de ficha já existente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                    }

                }

                if (existe == false)
                {
                    comandosql = new MySqlCommand("INSERT INTO Ficha (id_ficha, cpf_pessoa_paciente, cpf_pessoa_enfer, temperatura, pressao, altura, peso, sintomas) VALUES (?,?,?,?,?,?,?,?); ", conexao);
                    comandosql.Parameters.Add("@id_ficha", MySqlDbType.Int32, 4).Value = int.Parse(tb_id.Text);
                    comandosql.Parameters.Add("@cpf_pessoa_paciente", MySqlDbType.VarChar, 11).Value = cpf;
                    comandosql.Parameters.Add("@cpf_pessoa_enfer", MySqlDbType.VarChar, 11).Value = "55555555569";
                    comandosql.Parameters.Add("@temperatura", MySqlDbType.Float).Value = float.Parse(tb_temp.Text);
                    comandosql.Parameters.Add("@pressao", MySqlDbType.VarChar, 10).Value = tb_pressao.Text;
                    comandosql.Parameters.Add("@altura", MySqlDbType.Float).Value = float.Parse(tb_altura.Text);
                    comandosql.Parameters.Add("@peso", MySqlDbType.Float).Value = float.Parse(tb_peso.Text);
                    comandosql.Parameters.Add("@sintomas", MySqlDbType.VarChar, 200).Value = tb_sintomas.Text;
                    comandosql.ExecuteNonQuery();
                    lb_fichas.Items.Add("Id ficha: " + tb_id.Text + ", Sintomas: " + tb_sintomas.Text +  ", Pressão: " + tb_pressao.Text + ", Temperatura: " + tb_temp.Text +  ", Peso: " + tb_peso.Text + ", Altura: " + tb_altura.Text );

                    MessageBox.Show("Exame inserido com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void F_Paciente_Fichas_Load(object sender, EventArgs e)
        {
            string sql = "select f.* ,pe.* from ficha as f, pessoa as pe, paciente as pa, enfermeiro as e where f.cpf_pessoa_paciente = pa.cpf_pessoa_paciente and f.cpf_pessoa_enfer = e.cpf_pessoa_enfer and e.cpf_pessoa_enfer = pe.cpf_pessoa;";
            comandosql = new MySqlCommand(sql, conexao);
            reader = comandosql.ExecuteReader();


            while (reader.Read())
            {
                ids.Add(int.Parse(reader.GetString(0)));
                if (cpf == reader.GetString(1))
                {


                    lb_fichas.Items.Add("Id ficha:" + reader.GetString(0) + ", Sintomas: " + reader.GetString(6) + ", Pressão: " + reader.GetString(3) + ", Temperatura: " + reader.GetString(2) + ", Peso: " + reader.GetString(5) +  ", Altura: " + reader.GetString(4));


                }

            }
            reader.Close();
        }
    }
}