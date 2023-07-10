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
    public partial class F_Paciente_Atualizar : Form
    {
        Form_Pacientes FP;
        MySqlCommand comandosql1;
        MySqlCommand comandosql2;
        MySqlConnection conexao;
        string cpf;



        public F_Paciente_Atualizar( string cpf, MySqlConnection conexao, MySqlCommand comandosql, Form_Pacientes FP)
        {
            InitializeComponent();
            this.FP = FP;
            this.comandosql1 = comandosql;
            this.conexao = conexao;
            this.cpf = cpf;

            FP.Hide();
            

        }

        private void F_Paciente_Atualizar_Load(object sender, EventArgs e)
        {
          
            Nome_atualizar.Text = FP.CB1.Text;
           

        }

        private void F_Paciente_Atualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            

            FP.Show();
            

        }

        private void btn_att_confirmar_Click(object sender, EventArgs e)
        {
            if (tb1_nome.Text == "" || tb2_nasc.Text == "" || tb3_cpf.Text == "" || tb4_end.Text == "" || tb5_telefone.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                for (int i = 0; i < FP.paciente_aux.Count; i++)
                {
                    
                    if (cpf == FP.paciente_aux[i].cpf)
                    {

                        comandosql1 = new MySqlCommand("UPDATE paciente SET sexo = '" + cb_att_sexo.Text + "' WHERE cpf_pessoa_paciente = '" + FP.paciente_aux[i].cpf +"';", conexao);
                        comandosql2 = new MySqlCommand("UPDATE pessoa SET cpf_pessoa = '" + FP.paciente_aux[i].cpf + "', nome = '" + tb1_nome.Text + "', endereco = '" + tb4_end.Text + "', telefone = '" + tb5_telefone.Text + "' WHERE cpf_pessoa = '" + FP.paciente_aux[i].cpf + "' ; ", conexao);

                        comandosql1.ExecuteNonQuery();
                        comandosql2.ExecuteNonQuery();

                        FP.paciente_aux[i].nome = tb1_nome.Text;
                        FP.paciente_aux[i].dataNascimento = tb2_nasc.Text;
                        FP.paciente_aux[i].cpf = tb3_cpf.Text;
                        FP.paciente_aux[i].endereco = tb4_end.Text;
                        FP.paciente_aux[i].telefone = tb5_telefone.Text;
                        FP.paciente_aux[i].sexo = cb_att_sexo.Text;
                       

                    }

                }

                MessageBox.Show("Dados atualizados com sucesso!", "Parabéns!");
            }

            }

        private void btn_att_pac_limpar_Click(object sender, EventArgs e)
        {
            tb1_nome.Clear();
            tb2_nasc.Clear();
            tb3_cpf.Clear();
            tb4_end.Clear();
            tb5_telefone.Clear();
            tb1_nome.Focus();
          
        }

        private void btn_att_pac_cancelar_Click(object sender, EventArgs e)
        {
            string message = "Deseja cancelar a atualização dos dados?";
            string caption = "Atenção!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.Close();

            }
            else
                tb1_nome.Focus();
        }
    }
}
