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
    public partial class Form_Pacientes : Form
    {
        public List<Paciente> paciente_aux = new List<Paciente>();
       // public List<string> Lista_para_cpf = new List<string>();
        Form1 form1;
        MySqlConnection conexao;
        MySqlCommand comando1;
        MySqlDataReader reader;
        MySqlCommand comando;
        string nome;
        string cpf;


        public Form_Pacientes( MySqlConnection conexao ,Form1 form1)
        {
            
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.att;
            this.form1 = form1;
            this.conexao = conexao;

            string sql = "SELECT * , (select count(*) from paciente) From paciente as pa, pessoa as pe where pa.cpf_pessoa_paciente = pe.cpf_pessoa order by pe.nome ";
            comando = new MySqlCommand(sql, conexao);
            reader = comando.ExecuteReader();
         

            while (reader.Read())
            {
                string nome_aux = reader.GetString(4);
                string nasc_aux = "2010";
                string cpf_aux = reader.GetString(2);
                string endereco_aux = reader.GetString(5);
                string telefone_aux = reader.GetString(6);
                string sexo_aux = reader.GetString(1);

                Paciente pacienteaux = new Paciente(nome_aux, nasc_aux, cpf_aux, endereco_aux, telefone_aux, sexo_aux);
                paciente_aux.Add(pacienteaux);

                CB1.Items.Add(reader.GetString(4));
                //Lista_para_cpf.Add(reader.GetString(0));
        

               
            
                
            }
            reader.Close();
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            F_Pacientes_cadastro f_Pacientes_Cadastro = new F_Pacientes_cadastro(conexao, comando, this);
            f_Pacientes_Cadastro.ShowDialog();
        }

        private void cb_ListaPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            for (int i = 0; i < paciente_aux.Count; i++)
            {
                if (CB1.SelectedIndex == i)
                {
                    tb1.Text = paciente_aux[i].nome;
                    tb2.Text = paciente_aux[i].dataNascimento;
                    tb3.Text = paciente_aux[i].cpf;
                    tb4.Text = paciente_aux[i].endereco;
                    tb5.Text = paciente_aux[i].telefone;
                    cpf = paciente_aux[i].cpf;
                    nome = paciente_aux[i].nome;
                }

            }
        }

        private void btn_pacientes_excluir_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < paciente_aux.Count; i++)
            {
                if (CB1.Text == paciente_aux[i].nome)
                {
                    paciente_aux.Remove(paciente_aux[i]);
                    tb1.Clear();
                    tb2.Clear();
                    tb3.Clear();
                    tb4.Clear();
                    tb5.Clear();
                    tb1.Focus();
                    pictureBox1.Image = Properties.Resources.att;
                    CB1.Items.Remove(CB1.Text);




                    comando1 = new MySqlCommand("delete FROM paciente where cpf_pessoa_paciente = ?; ", conexao);
                    comando1.Parameters.Add("@cpf_pessoa_paciente", MySqlDbType.VarChar, 11).Value = cpf;
                    comando1.ExecuteNonQuery();


                }
            }
        }

        private void btn_paciente_atualiza_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Atualizar f_Paciente_Atualizar = new F_Paciente_Atualizar(cpf, conexao, comando, this);
                f_Paciente_Atualizar.ShowDialog();
            }
            else
                MessageBox.Show("Paciente não selecionado!","Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btn_paciente_historico_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Historico f_Paciente_Historico = new F_Paciente_Historico(cpf, conexao, comando, this);
                f_Paciente_Historico.ShowDialog();
            }
            else
                MessageBox.Show("Paciente não selecionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

            private void btn_paciente_exames_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Exame f_Paciente_Exame = new F_Paciente_Exame(cpf, conexao, comando, this);
                f_Paciente_Exame.ShowDialog();
            }
            else
                MessageBox.Show("Paciente não selecionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void Form_Pacientes_Load(object sender, EventArgs e)
        {
           
        }

        private void refresh_Click(object sender, EventArgs e)
        {

           

            string sql = "SELECT * , (select count(*) from paciente) From paciente as pa, pessoa as pe where pa.cpf_pessoa_paciente = pe.cpf_pessoa order by pe.nome ";
            comando = new MySqlCommand(sql, conexao);
            reader = comando.ExecuteReader();

            CB1.Items.Clear();


            while (reader.Read())
            {
                
                string nome_aux = reader.GetString(4);
                string nasc_aux = "2010";
                string cpf_aux = reader.GetString(2);
                string endereco_aux = reader.GetString(5);
                string telefone_aux = reader.GetString(6);
                string sexo_aux = reader.GetString(1);

                Paciente pacienteaux = new Paciente(nome_aux, nasc_aux, cpf_aux, endereco_aux, telefone_aux, sexo_aux);
                paciente_aux.Add(pacienteaux);

                CB1.Items.Add(reader.GetString(4));

               

            }
            reader.Close();

        }

        private void btn_pacientes_fichas_Click(object sender, EventArgs e)
        {
            if (CB1.Text != "")
            {
                F_Paciente_Fichas f_Paciente_Fichas = new F_Paciente_Fichas(nome, cpf, conexao, comando, this);
                f_Paciente_Fichas.ShowDialog();
            }
            else
                MessageBox.Show("Paciente não selecionado!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
