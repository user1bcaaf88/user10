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
    public partial class formBuy : Form
    {
        int idUser = 0;
        public formBuy(int idU)
        {
            InitializeComponent();
            idUser = idU;

        }

        private void formBuy_Load(object sender, EventArgs e)
        {
            fillMainPanelProduct();
        }

        public void fillMainPanelProduct()
        {
            mainPanel.Controls.Clear();

            var cmd = new NpgsqlCommand($"select ordersid, productname, productcost from orders, product where orders.productid = product.productid and orders.usersid = {idUser} and statusid=1", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Name = reader.GetValue(0).ToString();
                panel.Size = new Size(417,93);
                panel.Cursor = Cursors.Hand;
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label labelName = new Label();
                labelName.Name = reader.GetValue(1).ToString();
                labelName.Location = new Point(21,37);
                labelName.Size = new Size(110, 20);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.Text = $"{reader.GetValue(1).ToString()}";
                panel.Controls.Add(labelName);

                
                Label labelCost = new Label();
                labelCost.Name = reader.GetValue(2).ToString();
                labelCost.Location = new Point(153,37);
                labelCost.Size = new Size(110,20);
                labelCost.Font = new Font("Microsoft Sans Serif", 10);
                labelCost.Text = $"{reader.GetValue(2).ToString()}";
                panel.Controls.Add(labelCost);

                Button button = new Button();
                button.Name = reader.GetValue(0).ToString();
                button.Location = new Point(310, 37);
                button.Size = new Size(98, 31);
                button.Text = "Оформить";
                panel.Controls.Add(button);
                

                mainPanel.Controls.Add(panel);

                button.Click += Button_Click;
                
            }
            cmd.Cancel();
            reader.Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int idOrder = Convert.ToInt32(((Button)sender).Name);
            var cmd = new NpgsqlCommand($"UPDATE  public.orders SET   statusid = 2  WHERE   ordersid = {idOrder}", Program.connection);
            if (cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("Товар оформлен");
                fillMainPanelProduct();
                
            }
        }
    }
}
