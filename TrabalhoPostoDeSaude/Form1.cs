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
    public partial class Form1 : Form
    {
        MySqlConnection conexao;
        MySqlCommand comando;
        MySqlDataReader reader;
        string login;
        string senha;
        public Form1()
        {
           
            InitializeComponent();
            

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

       

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tb1_login.Focus();


            var strConexao = "server=localhost;uid=root;pwd=Braickvpe123;database=Trabalho";
            conexao = new MySqlConnection(strConexao);
            conexao.Open();



            string sql = "SELECT * from usuario;";
            comando = new MySqlCommand(sql, conexao);
            reader = comando.ExecuteReader();



            while (reader.Read())
            {
                 login = reader.GetString(0);
                 senha = reader.GetString(1);

            }
            reader.Close();


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
        
        }

      

        private void tb2_login_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb1_login.Text == login && tb2_login.Text == senha)
            {
                
                Form_Menu form_menu = new Form_Menu(conexao, this);
                this.Hide();
                form_menu.ShowDialog();
                
            }
                
            
        }

    }
    }

