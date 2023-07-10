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
    public partial class F_Medico_Atualizar : Form
    {

        string cpf;
        MySqlConnection conexao;
        MySqlCommand comandosql;
        MySqlCommand comandosql2;
        Form_Medicos FM;

        public F_Medico_Atualizar(string cpf, MySqlConnection conexao, MySqlCommand comandosql, Form_Medicos FM)
        {
            InitializeComponent();
            this.cpf = cpf;
            this.conexao = conexao;
            this.comandosql = comandosql;
            this.FM = FM;
        }

        private void btn_att_med_limpar_Click(object sender, EventArgs e)
        {
            tb1_nome.Clear();
            tb2_nasc.Clear();
            tb3_cpf.Clear();
            tb4_end.Clear();
            tb5_tel.Clear();
            tb6_email.Clear();
            tb7_espec.Clear();
            tb1_nome.Focus();
        }

        private void btn_att_med_cancelar_Click(object sender, EventArgs e)
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

        private void btn_att_med_confirmar_Click(object sender, EventArgs e)
        {
            if (tb1_nome.Text == "" || tb2_nasc.Text == "" || tb3_cpf.Text == "" || tb4_end.Text == "" || tb5_tel.Text == "" || tb6_email.Text == "" || tb7_espec.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else

            {
                for (int i = 0; i < FM.medico_aux.Count; i++)
                {

                    if (cpf == FM.medico_aux[i].cpf)
                    {

                        comandosql = new MySqlCommand("UPDATE Medico SET especialidade = '" + tb7_espec.Text + "', cpf_pessoa_medico = '" + FM.medico_aux[i].cpf + "' WHERE cpf_pessoa_medico = '" + FM.medico_aux[i].cpf + "';", conexao);
                        comandosql2 = new MySqlCommand("UPDATE pessoa SET cpf_pessoa = '" + FM.medico_aux[i].cpf + "', nome = '" + tb1_nome.Text + "', endereco = '" + tb4_end.Text + "', telefone = '" + tb5_tel.Text + "', email = '" + tb6_email.Text + "' WHERE cpf_pessoa = '" + FM.medico_aux[i].cpf + "' ; ", conexao);

                        comandosql.ExecuteNonQuery();
                        comandosql2.ExecuteNonQuery();

                        FM.medico_aux[i].nome = tb1_nome.Text;
                        FM.medico_aux[i].nascimento = tb2_nasc.Text;
                        FM.medico_aux[i].cpf = tb3_cpf.Text;
                        FM.medico_aux[i].endereco = tb4_end.Text;
                        FM.medico_aux[i].telefone = tb5_tel.Text;
                        FM.medico_aux[i].especialidade = tb7_espec.Text;


                    }

                }
                MessageBox.Show("Dados atualizados com sucesso!", "Parabéns!");
            }

            
        }

        private void F_Medico_Atualizar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
