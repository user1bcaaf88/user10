using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace user10
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
        int idRole = 0;
        int idUser = 0;

        private void formLogin_Load(object sender, EventArgs e)
        {
            Program.connection.Open();
            textBoxPass.UseSystemPasswordChar = true;
        }
        //авторизация пользователя по кнопке 
        private void buttonVhod_Click(object sender, EventArgs e)
        {
            var cmd = new NpgsqlCommand($"select * from users where log = '{textBoxLog.Text}' and passw = '{textBoxPass.Text}'", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    idUser = reader.GetInt32(0);
                    idRole = reader.GetInt32(6);
                }
                MessageBox.Show("Добро пожаловать!");
                formMenu form = new formMenu(idUser, idRole);
                Program.connection.Close();
                this.Hide();
                form.Show();
                cmd.Cancel();
                reader.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
                cmd.Cancel();
                reader.Close();
            }
        }

        private void formLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabelVhodBezLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Добро пожаловать!");
            formMenu form = new formMenu(idUser, idRole);
            Program.connection.Close();
            this.Hide();
            form.Show();
            
        }
    }
}
