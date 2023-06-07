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
    public partial class formUpdateOrders : Form
    {
        int idOrder;
        public formUpdateOrders(int idO)
        {
            InitializeComponent();
            idOrder = idO;


        }

        private void formUpdateOrders_Load(object sender, EventArgs e)
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

            var cmd4 = new NpgsqlCommand($"select ordersid, productname, surname, status from orders, product, users, status  where orders.statusid = status.statusid orders.productid = product.productid and orders.usersid = users.usersid and ordersid = {idOrder}", Program.connection);
            NpgsqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                comboBoxProduct.Text = reader4.GetValue(1).ToString();
                comboBoxStatus.Text = reader4.GetValue(4).ToString();
                comboBoxUser.Text = reader4.GetValue(2).ToString();
                
            }
            cmd4.Cancel();
            reader4.Close();
        }

        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            
            var cmd = new NpgsqlCommand($"UPDATE   public.orders SET   productid = {comboBoxProduct.SelectedIndex+1},  statusid = {comboBoxStatus.SelectedIndex+1},  usersid = {comboBoxUser.SelectedIndex+1} WHERE   ordersid = {idOrder}", Program.connection);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Заказ изменен");
                ((formMenu)Tag).fillMainPanelOrders();
                this.Hide();
            }
        }

        private void buttonDeleteOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить заказ?", "удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var cmd1 = new NpgsqlCommand($"delete from orders where ordersid = {idOrder}", Program.connection);
                if (cmd1.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Заказ удален");
                    ((formMenu)Tag).fillMainPanelProduct();
                    this.Close();
                    cmd1.Cancel();

                }
            }
        }
}
