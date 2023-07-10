using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPostoDeSaude.Entities;
using MySql.Data.MySqlClient;

namespace TrabalhoPostoDeSaude
{
    public partial class Form_Enfermeiros : Form
    {

        public List<Enfermeiro> enfermeiro_aux = new List<Enfermeiro>();
        Form1 form1;
        MySqlConnection conexao;
        MySqlDataReader reader;
        MySqlCommand comando;
        MySqlCommand comando1;
        string Tamanho;
        string cpf;


        public Form_Enfermeiros(MySqlConnection conexao, Form1 form1)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.att;
            this.conexao = conexao;
            this.form1 = form1;


            string sql = "SELECT * , (select count(*) from Enfermeiro) From enfermeiro as e, pessoa as pe where e.cpf_pessoa_enfer = pe.cpf_pessoa order by pe.nome ";
            comando = new MySqlCommand(sql, conexao);
            reader = comando.ExecuteReader();
            


            while (reader.Read())
            {
                string nome_aux = reader.GetString(5);
                string nasc_aux = "2010";
                string cpf_aux = reader.GetString(0);
                string endereco_aux = reader.GetString(6);
                string telefone_aux = reader.GetString(7);
                string formacao_aux = reader.GetString(1);
                string sexo_aux = reader.GetString(2);
                string email_aux = reader.GetString(8);

                Enfermeiro enfermeiroaux = new Enfermeiro(nome_aux, nasc_aux, cpf_aux, sexo_aux, endereco_aux, telefone_aux, email_aux, formacao_aux);
                enfermeiro_aux.Add(enfermeiroaux);

                CB1.Items.Add(reader.GetString(5));

                Tamanho = reader.GetString(8);
            }
            reader.Close();


        }

        private void Form_Enfermeiros_Load(object sender, EventArgs e)
        {

        }

        private void btn_enf_atualizar_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Enfermeiro_Atualizar f_Enfermeiro_Atualizar = new F_Enfermeiro_Atualizar(cpf, conexao, comando, this);
                f_Enfermeiro_Atualizar.ShowDialog();
            }
            else
            MessageBox.Show("Enfermeiro não selecionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_enf_cadastrar_Click(object sender, EventArgs e)
        {
            F_Enfermeiro_Cadastro f_Enfermeiro_Cadastro = new F_Enfermeiro_Cadastro(conexao, comando, this);
            f_Enfermeiro_Cadastro.ShowDialog();
        }

        private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < enfermeiro_aux.Count; i++)
            {
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = enfermeiro_aux[i].nome;
                    tb2.Text = enfermeiro_aux[i].nascimento;
                    tb3.Text = enfermeiro_aux[i].cpf;
                    tb4.Text = enfermeiro_aux[i].endereco;
                    tb5.Text = enfermeiro_aux[i].telefone;
                    tb6.Text = enfermeiro_aux[i].formacao;
                    cpf = enfermeiro_aux[i].cpf;
                }

            }
        }

        private void btn_enf_excluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < enfermeiro_aux.Count; i++)
            {
                if (CB1.Text == enfermeiro_aux[i].nome)
                {
                    enfermeiro_aux.Remove(enfermeiro_aux[i]);
                    tb1.Clear();
                    tb2.Clear();
                    tb3.Clear();
                    tb4.Clear();
                    tb5.Clear();
                    tb6.Clear();
                    tb1.Focus();
                    pictureBox1.Image = Properties.Resources.att;
                    CB1.Items.Remove(CB1.Text);


                    comando1 = new MySqlCommand("delete FROM enfermeiro where cpf_pessoa_enfer = ?; ", conexao);
                    comando1.Parameters.Add("@cpf_pessoa_enfer", MySqlDbType.VarChar, 11).Value = cpf;
                    comando1.ExecuteNonQuery();


                }
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * , (select count(*) from Enfermeiro) From enfermeiro as e, pessoa as pe where e.cpf_pessoa_enfer = pe.cpf_pessoa order by pe.nome";
            comando = new MySqlCommand(sql, conexao);
            reader = comando.ExecuteReader();

            CB1.Items.Clear();

            while (reader.Read())
            {
                string nome_aux = reader.GetString(5);
                string nasc_aux = "2010";
                string cpf_aux = reader.GetString(0);
                string endereco_aux = reader.GetString(6);
                string telefone_aux = reader.GetString(7);
                string formacao_aux = reader.GetString(1);
                string sexo_aux = reader.GetString(2);
                string email_aux = reader.GetString(8);

                Enfermeiro enfermeiroaux = new Enfermeiro(nome_aux, nasc_aux, cpf_aux, sexo_aux, endereco_aux, telefone_aux, email_aux, formacao_aux);
                enfermeiro_aux.Add(enfermeiroaux);

                CB1.Items.Add(reader.GetString(5));

                Tamanho = reader.GetString(8);
            }
            reader.Close();

        }
    }
}
