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
    public partial class F_Pacientes_cadastro : Form
    {
        Form_Pacientes f;
        MySqlCommand comandosql;
        MySqlConnection conexao;


        public F_Pacientes_cadastro(MySqlConnection conexao, MySqlCommand comando ,Form_Pacientes fp)
        {
            InitializeComponent();
            f = fp;
            this.comandosql = comando;
            this.conexao = conexao;
           
        }
        
        private void btn_conf_cad_pac_Click(object sender, EventArgs e)
        {


            if (tb1_cadastro_pac.Text == "" || tb2_cadastro_pac.Text == "" || tb3_cadastro_pac.Text == "" || tb4_cadastro_pac.Text == "" || cb_cidade.Text == "" || tb43_cadastro_pac.Text == "" || tb44_cadastro_pac.Text == "" || tb45_cadastro_pac.Text == "" || tb5_cadastro_pac.Text == "" || cb_cadastro_sexo.Text == "")
            {
                MessageBox.Show("Existem campos em branco!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                 MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
 
                comandosql = new MySqlCommand("INSERT INTO pessoa (cpf_pessoa, nome, endereco, telefone, email,id_cidade_pessoa) VALUES (?,?,?,?,?,?); insert into paciente(cpf_pessoa_paciente, sexo) values(?,?);", conexao);
                comandosql.Parameters.Add("@cpf_pessoa", MySqlDbType.VarChar, 11).Value = tb3_cadastro_pac.Text;
                comandosql.Parameters.Add("@nome", MySqlDbType.VarChar, 100).Value = tb1_cadastro_pac.Text;
                comandosql.Parameters.Add("@endereco", MySqlDbType.VarChar, 200).Value = tb4_cadastro_pac.Text;
                comandosql.Parameters.Add("@telefone", MySqlDbType.VarChar, 15).Value = tb5_cadastro_pac.Text;
                comandosql.Parameters.Add("@email", MySqlDbType.VarChar, 50).Value = tb6_cadastro_pac.Text;
                comandosql.Parameters.Add("@id_cidade_pessoa", MySqlDbType.Int32).Value = 1;
                comandosql.Parameters.Add("@cpf_pessoa_paciente", MySqlDbType.VarChar, 11).Value = tb3_cadastro_pac.Text;
                comandosql.Parameters.Add("@sexo", MySqlDbType.VarChar, 15).Value = cb_cadastro_sexo.Text;
                comandosql.ExecuteNonQuery();


            }
        }

        private void btn_clear_cad_pac_Click(object sender, EventArgs e)
        {
            tb1_cadastro_pac.Clear();
            tb2_cadastro_pac.Clear();
            tb3_cadastro_pac.Clear();
            tb4_cadastro_pac.Clear();
            cb_cidade.ResetText();
            tb43_cadastro_pac.Clear();
            tb44_cadastro_pac.Clear();
            tb45_cadastro_pac.Clear();
            tb5_cadastro_pac.Clear();
            cb_cadastro_sexo.ResetText();
            tb1_cadastro_pac.Focus();
            
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
                f.Show();

            }
        }

        private void F_Pacientes_cadastro_Load(object sender, EventArgs e)
        {
            f.Hide();
        }

        private void F_Pacientes_cadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }
    }
    }

