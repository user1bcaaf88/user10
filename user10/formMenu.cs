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
    public partial class formMenu : Form
    {
        int idRole = 0;
        int idUser = 0;

        public formMenu(int idU, int idR)
        {
            InitializeComponent();
            idRole = idR;
            idUser = idU;
        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            Program.connection.Open();
            
            if (idRole == 0 || idRole == 3)
            {
                buttonInsertProduct.Visible = false;
                tabControlMenu.TabPages.Remove(tabPageOrders);
            }
            else if (idRole == 2)
            {
                buttonBuy.Visible = false;
                tabControlMenu.TabPages.Remove(tabPageProduct);

            }
            else if (idRole == 1)
            {
                buttonBuy.Visible = false;
                buttonInsertOrder.Visible = false;
            }
            fillMainPanelProduct();
            fillMainPanelOrders();
        }

        public void fillMainPanelProduct()
        {
            panelProduct.Controls.Clear();

            var cmd = new NpgsqlCommand("select *, manufacturername from product, manufacturer where product.manufacturer = manufacturer.manufacturerid ", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Panel panel = new Panel();
                panel.Name = reader.GetValue(0).ToString();
                panel.Size = new Size(700, 185);
                panel.Cursor = Cursors.Hand;
                panel.BorderStyle = BorderStyle.FixedSingle;

                Label labelName = new Label();
                labelName.Name = reader.GetValue(1).ToString();
                labelName.Location = new Point(11, 25);
                labelName.Size = new Size(165, 31);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.Text = $"{reader.GetValue(1).ToString()}";
                panel.Controls.Add(labelName);

                Label labelManuf = new Label();
                labelManuf.Name = reader["manufacturer"].ToString();
                labelManuf.Location = new Point(11,76);
                labelManuf.Size = new Size(165, 31);
                labelManuf.Font = new Font("Microsoft Sans Serif", 10);
                labelManuf.Text = $"Производитель: {reader["manufacturername"].ToString()}";
                panel.Controls.Add(labelManuf);

                Label labelDesc = new Label();
                labelDesc.Name = reader.GetValue(2).ToString();
                labelDesc.Location = new Point(204,25);
                labelDesc.Size = new Size(240,82);
                labelDesc.Font = new Font("Microsoft Sans Serif", 10);
                labelDesc.Text = $"{reader.GetValue(2).ToString()}";
                panel.Controls.Add(labelDesc);

                Label labelCost = new Label();
                labelCost.Name = reader.GetValue(3).ToString();
                labelCost.Location = new Point(558, 25);
                labelCost.Size = new Size(98,31);
                labelCost.Font = new Font("Microsoft Sans Serif", 10);
                labelCost.Text = $"{reader.GetValue(3).ToString()}";
                panel.Controls.Add(labelCost);

                Button button = new Button();
                button.Name = reader.GetValue(0).ToString();
                button.Location = new Point(558, 76);
                button.Size = new Size(98, 31);
                button.Text = "В корзину";
                if (idRole == 0 || idRole == 3)
                {
                    panel.Controls.Add(button);
                }

                panelProduct.Controls.Add(panel);

                button.Click += Button_Click;
                panel.Click += Panel_Click;
                
                    
            }
            cmd.Cancel();
            reader.Close();
        }

        public void fillMainPanelOrders()
        {
            panelOrdersBig.Controls.Clear();

            var cmd = new NpgsqlCommand("select ordersid, productname, surname, productcost from orders, product, users  where orders.productid = product.productid and orders.usersid = users.usersid and statusid=2", Program.connection);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Panel panelOrders = new Panel();
                panelOrders.Name = reader.GetValue(0).ToString();
                panelOrders.Size = new Size(700, 185);
                panelOrders.Cursor = Cursors.Hand;
                panelOrders.BorderStyle = BorderStyle.FixedSingle;

                Label labelName = new Label();
                labelName.Name = reader.GetValue(1).ToString();
                labelName.Location = new Point(18,25);
                labelName.Size = new Size(165, 31);
                labelName.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                labelName.Text = $"{reader.GetValue(1).ToString()}";
                panelOrders.Controls.Add(labelName);

                Label labelCost = new Label();
                labelCost.Name = reader.GetValue(3).ToString();
                labelCost.Location = new Point(18,75);
                labelCost.Size = new Size(98, 31);
                labelCost.Font = new Font("Microsoft Sans Serif", 10);
                labelCost.Text = $"{reader.GetValue(3).ToString()}";
                panelOrders.Controls.Add(labelCost);

                Label labelUser = new Label();
                labelUser.Name = reader.GetValue(2).ToString();
                labelUser.Location = new Point(310,52);
                labelUser.Size = new Size(92,20);
                labelUser.Font = new Font("Microsoft Sans Serif", 10);
                labelUser.Text = $"{reader.GetValue(2).ToString()}";
                panelOrders.Controls.Add(labelUser);


                panelOrdersBig.Controls.Add(panelOrders);


                panelOrders.Click += PanelOrders_Click;


            }
            cmd.Cancel();
            reader.Close();
        }

        private void PanelOrders_Click(object sender, EventArgs e)
        {
            foreach (var control in panelOrdersBig.Controls)
            {
                ((Panel)control).BackColor = Color.White;
            }
            if (idRole == 1 || idRole == 3 || idRole == 0)
            {

            }
            else
            {
                int idOrder = Convert.ToInt32(((Panel)sender).Name);
                ((Panel)sender).BackColor = Color.Gray;
                if (Application.OpenForms["formUpdateOrders"] == null)
                {
                    formUpdateOrders form = new formUpdateOrders(idOrder);
                    form.Tag = this;
                    form.Show();
                }
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            foreach (var control in panelProduct.Controls)
            {
                ((Panel)control).BackColor = Color.White;
            }
            if (idRole == 2 || idRole == 3 || idRole == 0)
            {

            }
            else
            {
                int idProd = Convert.ToInt32(((Panel)sender).Name);
                ((Panel)sender).BackColor = Color.Gray;
                if (Application.OpenForms["formUpdateProduct"] == null)
                {
                    formUpdateProduct form = new formUpdateProduct(idProd);
                    form.Tag = this;
                    form.Show();
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int idProd = Convert.ToInt32(((Button)sender).Name);
            string filtr = "";
            if (idUser == 0)
            {
                filtr = $") values ({idProd}, 1)";
            }
            else
            {
                filtr = $", usersid) values ({idProd}, 1, {idUser}) ";
            }
            var cmd = new NpgsqlCommand($"insert into orders (productid, statusid" + filtr, Program.connection);
            if (cmd.ExecuteNonQuery()>0 )
            {
                MessageBox.Show("Товар добавлен в корзину");
            }
        }

        private void formMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formLogin form = new formLogin();
                Program.connection.Close();
                this.Hide();
                form.Show();
            }
        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                formLogin form = new formLogin();
                Program.connection.Close();
                this.Hide();
                form.Show();
            }
        }

        private void buttonInsertProduct_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["formInsertProduct"] == null)
            {
                formInsertProduct form = new formInsertProduct();
                form.Tag = this;
                form.Show();
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            formBuy form = new formBuy(idUser);
            form.Show();
        }

        private void buttonInsertOrder_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["formInsertOrders"] == null)
            {
                formInsertOrders form = new formInsertOrders();
                form.Tag = this;
                form.Show();
            }
        }
    }
}
