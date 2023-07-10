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
    public partial class F_Enfermeiro_Cadastro : Form
    {
        Form_Enfermeiros FE;
        MySqlCommand comandosql;
        MySqlConnection conexao;

        public F_Enfermeiro_Cadastro(MySqlConnection conexao, MySqlCommand comandosql, Form_Enfermeiros FE)
        {
            InitializeComponent();
            this.FE = FE;
            this.comandosql = comandosql;
            this.conexao = conexao;
        }

        private void btn_canc_cad_pac_Click(object sender, EventArgs e)
        {
            string message = "Você deseja cancelar o cadastro?";
            string caption = "Atenção!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                this.Close();
                FE.Show();

            }
        }

        private void btn_clear_cad_pac_Click(object sender, EventArgs e)
        {
            tb1_cadastro_enfer.Clear();
            tb2_cadastro_enfer.Clear();
            tb3_cadastro_enfer.Clear();
            tb4_cadastro_enfer.Clear();
            cb_cidade.ResetText();
            tb43_cadastro_enfer.Clear();
            tb44_cadastro_enfer.Clear();
            tb45_cadastro_enfer.Clear();
            tb5_cadastro_enfer.Clear();
            tb6_cadastro_enfer.Clear();
            tb7_cadastro_enfer.Clear();
            cb1_cadastro_enfer.ResetText();
            tb1_cadastro_enfer.Focus();
        }

        private void btn_conf_cad_pac_Click(object sender, EventArgs e)
        {
            if (tb1_cadastro_enfer.Text == "" || tb2_cadastro_enfer.Text == "" || tb3_cadastro_enfer.Text == "" || tb4_cadastro_enfer.Text == "" || cb_cidade.Text == "" || tb43_cadastro_enfer.Text == "" || tb44_cadastro_enfer.Text == "" || tb45_cadastro_enfer.Text == "" || tb5_cadastro_enfer.Text == "" || tb6_cadastro_enfer.Text == "" || tb7_cadastro_enfer.Text == "" || cb1_cadastro_enfer.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                comandosql = new MySqlCommand("INSERT INTO pessoa (cpf_pessoa, nome, endereco, telefone, email,id_cidade_pessoa) VALUES (?,?,?,?,?,?); insert into Enfermeiro (cpf_pessoa_enfer, sexo, formacao) values(?,?,?);", conexao);
                comandosql.Parameters.Add("@cpf_pessoa", MySqlDbType.VarChar, 11).Value = tb3_cadastro_enfer.Text;
                comandosql.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = tb1_cadastro_enfer.Text;
                comandosql.Parameters.Add("@endereco", MySqlDbType.VarChar, 200).Value = tb4_cadastro_enfer.Text;
                comandosql.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = tb5_cadastro_enfer.Text;
                comandosql.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = tb6_cadastro_enfer.Text;
                comandosql.Parameters.Add("@id_cidade_pessoa", MySqlDbType.Int32).Value = 2;
                comandosql.Parameters.Add("@cpf_pessoa_enfer", MySqlDbType.VarChar, 11).Value = tb3_cadastro_enfer.Text;
                comandosql.Parameters.Add("@sexo", MySqlDbType.VarChar, 15).Value = cb1_cadastro_enfer.Text;
                comandosql.Parameters.Add("@formacao", MySqlDbType.VarChar, 30).Value = tb7_cadastro_enfer.Text;
                comandosql.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
