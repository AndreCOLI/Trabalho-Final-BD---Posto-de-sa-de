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
    public partial class Form_Menu : Form
    {
        Form1 form1;
        MySqlConnection conexao;
        public Form_Menu(MySqlConnection conexao, Form1 form1)
        {
            this.form1 = form1;
            this.conexao = conexao;
            InitializeComponent();
        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            string message = "Você deseja finalizar a sessão?";
            string caption = "Atenção!";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;


            result = MessageBox.Show(this, message, caption, buttons,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1,
                MessageBoxOptions.RightAlign);

            if (result == DialogResult.Yes)
            {
                form1.Close();
                
            }
        }

        private void bt_Pacientes_Form_Click(object sender, EventArgs e)
        {
            Form_Pacientes form_Pacientes = new Form_Pacientes(conexao, form1);
            form_Pacientes.ShowDialog();
        }

        private void bt_Enfer_Form_Click(object sender, EventArgs e)
        {
            Form_Enfermeiros form_Enfermeiros = new Form_Enfermeiros(conexao, form1);
            form_Enfermeiros.ShowDialog();
        }

        private void bt_Medicos_Form_Click(object sender, EventArgs e)
        {
            Form_Medicos form_Medicos = new Form_Medicos(conexao, form1);
            form_Medicos.ShowDialog();
        }

        private void bt_Ajuda_Form_Click(object sender, EventArgs e)
        {
            F_Ajuda f_Ajuda = new F_Ajuda();
            f_Ajuda.ShowDialog();
        }

        private void Form_Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                    
                }
                else
                    form1.Close();
            }
        }

        private void Form_Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            conexao.Close();
        }
    }

    
}
