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
    public partial class F_Medico_Cadastro : Form
    {
        Form_Medicos FM;
        MySqlCommand comandosql;
        MySqlConnection conexao;

        public F_Medico_Cadastro(MySqlConnection conexao, MySqlCommand comando, Form_Medicos FM)
        {
            InitializeComponent();
            this.FM = FM;
            comandosql = comando;
            this.conexao = conexao;
        }

        private void btn_conf_cad_pac_Click(object sender, EventArgs e)
        {

            if (tb1_cadastro_med.Text == "" || tb2_cadastro_med.Text == "" || tb3_cadastro_med.Text == "" || tb4_cadastro_med.Text == "" || cb_cidade.Text == "" || tb43_cadastro_med.Text == "" || tb44_cadastro_med.Text == "" || tb45_cadastro_med.Text == "" || tb5_cadastro_med.Text == "" || cb_cadastro_sexo.Text == "" || tb7_cadastro_med.Text == "" || tb8_cadastro_med.Text == "" || tb9_cadastro_med.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {

                comandosql = new MySqlCommand("INSERT INTO pessoa (cpf_pessoa, nome, endereco, telefone, email,id_cidade_pessoa) VALUES (?,?,?,?,?,?); insert into Medico (cpf_pessoa_medico, crm, especialidade) values(?,?,?);", conexao);
                comandosql.Parameters.Add("@cpf_pessoa", MySqlDbType.VarChar, 11).Value = tb3_cadastro_med.Text;
                comandosql.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = tb1_cadastro_med.Text;
                comandosql.Parameters.Add("@endereco", MySqlDbType.VarChar, 200).Value = tb4_cadastro_med.Text;
                comandosql.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = tb5_cadastro_med.Text;
                comandosql.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = tb7_cadastro_med.Text;
                comandosql.Parameters.Add("@id_cidade_pessoa", MySqlDbType.Int32).Value = 7;
                comandosql.Parameters.Add("@cpf_pessoa_medico", MySqlDbType.VarChar, 11).Value = tb3_cadastro_med.Text;
                comandosql.Parameters.Add("@crm", MySqlDbType.VarChar, 7).Value = tb9_cadastro_med.Text;
                comandosql.Parameters.Add("@especialidade", MySqlDbType.VarChar, 100).Value = tb8_cadastro_med.Text;
                comandosql.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }








        }

        private void btn_canc_cad_med_Click(object sender, EventArgs e)
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
                FM.Show();

            }
        }

        private void btn_clear_cad_med_Click(object sender, EventArgs e)
        {
            tb1_cadastro_med.Clear();
            tb2_cadastro_med.Clear();
            tb3_cadastro_med.Clear();
            tb4_cadastro_med.Clear();
            cb_cidade.ResetText();
            tb43_cadastro_med.Clear();
            tb44_cadastro_med.Clear();
            tb45_cadastro_med.Clear();
            tb5_cadastro_med.Clear();
            cb_cadastro_sexo.ResetText();
            tb7_cadastro_med.Clear();
            tb8_cadastro_med.Clear();
            tb9_cadastro_med.Clear();
            tb1_cadastro_med.Focus();
        }
    }
}
