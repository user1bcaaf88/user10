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
    public partial class formInsertOrders : Form
    {
        public formInsertOrders()
        {
            InitializeComponent();
        }

        private void formInsertOrders_Load(object sender, EventArgs e)
        {
            var cmd = new NpgsqlCommand("select productname from product", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxProduct.Items.Add(reader["productname"]);
            }
            cmd.Cancel();
            reader.Close();

            var cmd2 = new NpgsqlCommand("select surname from users where rolesid = 3", Program.connection);
            NpgsqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                comboBoxUser.Items.Add(reader2["surname"]);
            }
            cmd2.Cancel();
            reader2.Close();

            var cmd3 = new NpgsqlCommand("select status from status", Program.connection);
            NpgsqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                comboBoxStatus.Items.Add(reader3["status"]);
            }
            cmd3.Cancel();
            reader3.Close();
        }

        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.Text == "" || comboBoxStatus.Text == "" || comboBoxUser.Text == "")
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else
            {
                if (comboBoxUser.Text.All(char.IsLetter) && comboBoxStatus.Text.All(char.IsLetter))
                {
                    var cmd = new NpgsqlCommand($"INSERT INTO  public.orders(  productid,  statusid,  usersid) VALUES ({comboBoxProduct.SelectedIndex+1},{comboBoxStatus.SelectedIndex+1}, {comboBoxUser.SelectedIndex+1} );", Program.connection);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Заказ добавлен");
                        ((formMenu)Tag).fillMainPanelOrders();
                        this.Close();
                        cmd.Cancel();

                    }
                }
                else
                {
                    MessageBox.Show("Некорректные данные");
                }

            }
        }
    }
}
