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
    public partial class F_Enfermeiro_Atualizar : Form
    {
        Form_Enfermeiros FE;
        MySqlCommand comandosql1;
        MySqlCommand comandosql2;
        MySqlConnection conexao;
        string cpf;


        public F_Enfermeiro_Atualizar(string cpf, MySqlConnection conexao, MySqlCommand comandosql1, Form_Enfermeiros FE)
        {
            InitializeComponent();
            this.comandosql1 = comandosql1;
            this.conexao = conexao;
            this.FE = FE;
            this.cpf = cpf;
            FE.Hide();
        }

        private void btn_att_enf_confirmar_Click(object sender, EventArgs e)
        {
            if (tb1_nome.Text == "" || tb2_nasc.Text == "" || tb3_cpf.Text == "" || tb4_end.Text == "" || tb5_tel.Text == "" || tb6_email.Text == "" || cb1_formacao.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            { 

                for (int i = 0; i < FE.enfermeiro_aux.Count; i++)
                {

                    if (cpf == FE.enfermeiro_aux[i].cpf)
                    {

                        comandosql1 = new MySqlCommand("UPDATE Enfermeiro SET sexo = '" + cb_att_sexo.Text + "', formacao = '" + cb1_formacao.Text + "', cpf_pessoa_enfer = '" + FE.enfermeiro_aux[i].cpf + " ' WHERE cpf_pessoa_enfer = '" + FE.enfermeiro_aux[i].cpf + "';", conexao);
                        comandosql2 = new MySqlCommand("UPDATE pessoa SET cpf_pessoa = '" + FE.enfermeiro_aux[i].cpf + "', nome = '" + tb1_nome.Text + "', endereco = '" + tb4_end.Text + "', telefone = '" + tb5_tel.Text + "', email = '" + tb6_email.Text + "' WHERE cpf_pessoa = '" + FE.enfermeiro_aux[i].cpf + "' ; ", conexao);

                        comandosql1.ExecuteNonQuery();
                        comandosql2.ExecuteNonQuery();

                        FE.enfermeiro_aux[i].nome = tb1_nome.Text;
                        FE.enfermeiro_aux[i].nascimento = tb2_nasc.Text;
                        FE.enfermeiro_aux[i].cpf = tb3_cpf.Text;
                        FE.enfermeiro_aux[i].endereco = tb4_end.Text;
                        FE.enfermeiro_aux[i].telefone = tb5_tel.Text;
                        FE.enfermeiro_aux[i].email = tb6_email.Text;
                        FE.enfermeiro_aux[i].formacao = cb1_formacao.Text;
                        FE.enfermeiro_aux[i].sexo = cb_att_sexo.Text;


                    }

                }


            MessageBox.Show("Dados atualizados com sucesso!", "Parabéns!");
        }
        }

        private void btn_att_enf_limpar_Click(object sender, EventArgs e)
        {
            tb1_nome.Clear();
            tb2_nasc.Clear();
            tb3_cpf.Clear();
            tb4_end.Clear();
            tb5_tel.Clear();
            tb6_email.Clear();
            cb1_formacao.ResetText();
            tb1_nome.Focus();


        }

        private void btn_att_enf_cancelar_Click(object sender, EventArgs e)
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

        private void F_Enfermeiro_Atualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            FE.CB1.ResetText();
            FE.tb1.Clear();
            FE.tb2.Clear();
            FE.tb3.Clear();
            FE.tb4.Clear();
            FE.tb5.Clear();
            FE.tb6.Clear();

            FE.Show();

        }
    }
}
