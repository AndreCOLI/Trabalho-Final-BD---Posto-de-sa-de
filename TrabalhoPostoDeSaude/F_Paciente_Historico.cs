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
    public partial class F_Paciente_Historico : Form
    {
        Form_Pacientes FP;
        bool existe = false;
        List<int> ids = new List<int>();
        List<string> cpf_medicos = new List<string>();
        List<string> cpf_enfermeiros = new List<string>();
        MySqlCommand comandosql;
        MySqlDataReader reader;
        MySqlConnection conexao;
        string cpf;


        public F_Paciente_Historico(string cpf, MySqlConnection conexao, MySqlCommand comandosql, Form_Pacientes FP)
        {
            InitializeComponent();
            this.FP = FP;
            this.conexao = conexao;
            this.comandosql = comandosql;
            this.cpf = cpf;
        }

        private void F_Paciente_Historico_Load(object sender, EventArgs e)
        {
            FP.Hide();


            string sql = "select m.cpf_pessoa_medico from medico as m;";
            comandosql = new MySqlCommand(sql, conexao);
            reader = comandosql.ExecuteReader();


            while (reader.Read())
            {
                
                    cpf_medicos.Add(reader.GetString(0));             
                
                

            }
            reader.Close();


            string sql2 = "select e.cpf_pessoa_enfer from  enfermeiro as e;";
            comandosql = new MySqlCommand(sql2, conexao);
            reader = comandosql.ExecuteReader();


            while (reader.Read())
            {

                
                cpf_enfermeiros.Add(reader.GetString(0));


            }
            reader.Close();


            for (int i = 0; i < cpf_medicos.Count; i++)
            {
                cb_medicos.Items.Add(cpf_medicos[i]);
            
            }

            for (int i = 0; i < cpf_enfermeiros.Count; i++)
            {
                cb_enfermeiros.Items.Add(cpf_enfermeiros[i]);

            }

            string sql3 = "select * from consulta;";
            comandosql = new MySqlCommand(sql3, conexao);
            reader = comandosql.ExecuteReader();


            while (reader.Read())
            {
                if(cpf == reader.GetString(1))

                lb_consultas.Items.Add("Id da ficha: " + reader.GetString(4) + ", Cpf do médico: " + reader.GetString(0) + ", Cpf do paciente: " + reader.GetString(1) + ", Cpf do enfermeiro da ficha: " + reader.GetString(6) + ", Data da consulta: " + reader.GetString(3) + ", Sala: " + reader.GetString(2) + ", Diagnóstico: " + reader.GetString(5));



            }
            reader.Close();




        }

        private void F_Paciente_Historico_FormClosed(object sender, FormClosedEventArgs e)
        {
            FP.Show();
        }

        private void btn_historico_inserir_Click(object sender, EventArgs e)
        {
            if (tb_id.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                for (int i = 0; i < ids.Count; i++)
                {
                    if (int.Parse(tb_id.Text) == ids[i])
                    {

                        MessageBox.Show("Código de consulta já existente!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        existe = true;
                    }

                }
                
                if (existe == false)
                {
                    comandosql = new MySqlCommand("INSERT INTO Consulta (cpf_pessoa_medico, cpf_pessoa_paciente, sala_consulta, data_consulta, id_ficha_consulta, diagnostico, cpf_pessoa_enfer_ficha) VALUES (?,?,?,?,?,?,?); ", conexao);
                    comandosql.Parameters.Add("@cpf_pessoa_medico", MySqlDbType.VarChar, 11).Value = cb_medicos.Text;
                    comandosql.Parameters.Add("@cpf_pessoa_paciente", MySqlDbType.VarChar, 11).Value = cpf;
                    comandosql.Parameters.Add("@sala_consulta", MySqlDbType.Int32).Value = int.Parse(tb_sala.Text);
                    comandosql.Parameters.Add("@data_consulta", MySqlDbType.DateTime).Value = DateTime.Parse(maskedTextBox1.Text);
                    comandosql.Parameters.Add("@id_ficha_consulta", MySqlDbType.Int32).Value = int.Parse(tb_id.Text);
                    comandosql.Parameters.Add("@diagnostico", MySqlDbType.VarChar, 200).Value = tb_diag.Text;
                    comandosql.Parameters.Add("@cpf_pessoa_enfer_ficha", MySqlDbType.VarChar, 11).Value = cb_enfermeiros.Text;
                    comandosql.ExecuteNonQuery();

                    lb_consultas.Items.Add("Id da ficha: " + tb_id.Text + ", Cpf do médico: " + cb_medicos.Text + ", Cpf do paciente: " + cpf + ", Cpf do enfermeiro da ficha: " + cb_enfermeiros.Text + ", Data da consulta: " + maskedTextBox1.Text + ", Sala: " + tb_sala.Text + ", Diagnóstico: " + tb_diag.Text);

                    MessageBox.Show("Exame inserido com sucesso!", "Parabéns!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }
    }
}
