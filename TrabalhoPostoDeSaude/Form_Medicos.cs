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
    public partial class Form_Medicos : Form
    {

        public List<Medico> medico_aux = new List<Medico>();
        Form1 form1;
        MySqlConnection conexao;
        MySqlDataReader reader;
        MySqlCommand comando;
        MySqlCommand comando1;
        string Tamanho;
        string cpf;


        public Form_Medicos(MySqlConnection conexao, Form1 form1)
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.att;
            this.conexao = conexao;
            this.form1 = form1;


            string sql = "SELECT * , (select count(*) from Medico) From medico as m, pessoa as pe where m.cpf_pessoa_medico = pe.cpf_pessoa order by pe.nome ";
            comando = new MySqlCommand(sql, conexao);
            reader = comando.ExecuteReader();


            while (reader.Read())
            {
                string nome_aux = reader.GetString(5);
                string nasc_aux = "2010";
                string cpf_aux = reader.GetString(0);
                string endereco_aux = reader.GetString(6);
                string telefone_aux = reader.GetString(7);

                string crm_aux = reader.GetString(1);
                string especialidade_aux = reader.GetString(2);
                double salario_aux = 1000.0;

                Medico pacienteaux = new Medico(nome_aux, nasc_aux, cpf_aux, endereco_aux, telefone_aux, crm_aux, especialidade_aux, salario_aux);
                medico_aux.Add(pacienteaux);

                CB1.Items.Add(reader.GetString(5));

                Tamanho = reader.GetString(8);

            }
            reader.Close();


        }

        private void Form_Medicos_Load(object sender, EventArgs e)
        {

        }

        private void btn_medico_atualizar_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {

                F_Medico_Atualizar f_Medico_Atualizar = new F_Medico_Atualizar(cpf, conexao, comando, this);
                f_Medico_Atualizar.ShowDialog();
            }
            else
            MessageBox.Show("Médico não selecionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_medico_cadastro_Click(object sender, EventArgs e)
        {
            F_Medico_Cadastro f_Medico_Cadastro = new F_Medico_Cadastro(conexao, comando, this);
            f_Medico_Cadastro.ShowDialog();
        }

        private void CB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < medico_aux.Count; i++)
            {
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = medico_aux[i].nome;
                    tb2.Text = medico_aux[i].nascimento;
                    tb3.Text = medico_aux[i].cpf;
                    tb4.Text = medico_aux[i].endereco;
                    tb5.Text = medico_aux[i].telefone;
                    tb6.Text = medico_aux[i].especialidade;
                    tb7.Text = medico_aux[i].crm;
                    cpf = medico_aux[i].cpf;
                }

            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * , (select count(*) from Medico) From medico as m, pessoa as pe where m.cpf_pessoa_medico = pe.cpf_pessoa order by pe.nome ";
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

                string crm_aux = reader.GetString(1);
                string especialidade_aux = reader.GetString(2);
                double salario_aux = 1000.0;

                Medico pacienteaux = new Medico(nome_aux, nasc_aux, cpf_aux, endereco_aux, telefone_aux, crm_aux, especialidade_aux, salario_aux);
                medico_aux.Add(pacienteaux);

                CB1.Items.Add(reader.GetString(5));

                Tamanho = reader.GetString(8);

            }
            reader.Close();
        }

        private void btn_medico_excluir_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < medico_aux.Count; i++)
            {
                if (CB1.Text == medico_aux[i].nome)
                {
                    medico_aux.Remove(medico_aux[i]);
                    tb1.Clear();
                    tb2.Clear();
                    tb3.Clear();
                    tb4.Clear();
                    tb5.Clear();
                    tb6.Clear();
                    tb7.Clear();
                    tb1.Focus();
                    pictureBox1.Image = Properties.Resources.att;
                    CB1.Items.Remove(CB1.Text);


                    comando1 = new MySqlCommand("delete FROM medico where cpf_pessoa_medico = ?; ", conexao);
                    comando1.Parameters.Add("@cpf_pessoa_medico", MySqlDbType.VarChar, 11).Value = cpf;
                    comando1.ExecuteNonQuery();


                }
            }
        }
    }
}
