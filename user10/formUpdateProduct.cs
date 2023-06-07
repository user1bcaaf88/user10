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
    public partial class formUpdateProduct : Form
    {
        int idProduct;
        public formUpdateProduct(int idP)
        {
            InitializeComponent();
            idProduct = idP;
        }

        private void formUpdateProduct_Load(object sender, EventArgs e)
        {
            var cmd = new NpgsqlCommand("select manufacturername from manufacturer", Program.connection);

            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxManuf.Items.Add(reader["manufacturername"]);
            }
            cmd.Cancel();
            reader.Close();


            var cmd2 = new NpgsqlCommand("select *, manufacturername from product, manufacturer where product.manufacturer = manufacturer.manufacturerid", Program.connection);

            NpgsqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                textBoxCost.Text = reader2.GetValue(3).ToString();
                textBoxDesc.Text = reader2.GetValue(2).ToString();
                textBoxName.Text = reader2.GetValue(1).ToString();
                comboBoxManuf.Text = reader2.GetValue(6).ToString();
            }
            cmd2.Cancel();
            reader2.Close();



        }

        private void buttonUpdateProd_Click(object sender, EventArgs e)
        {
            if (textBoxCost.Text == "" || textBoxDesc.Text == "" || textBoxName.Text == "" || comboBoxManuf.Text == "")
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else
            {
                if (textBoxCost.Text.All(char.IsDigit))
                {
                    var cmd = new NpgsqlCommand($"UPDATE  public.product SET   productname = '{textBoxName.Text}',  description = '{textBoxDesc.Text}',  productcost = @cost,  manufacturer = {comboBoxManuf.SelectedIndex+1} WHERE   productid = {idProduct}", Program.connection);
                    cmd.Parameters.AddWithValue("@cost", Convert.ToDecimal(textBoxCost.Text));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Товар изменен");
                        ((formMenu)Tag).fillMainPanelProduct();
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

        private void buttonDeleteProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить товар?", "удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var cmd = new NpgsqlCommand($"select * from orders where productid = {idProduct}", Program.connection);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Невозможно удалить товар, тк он присутствует в заказе");
                }
                else
                {
                    var cmd1 = new NpgsqlCommand($"delete from product where productid = {idProduct}", Program.connection);
                    if (cmd1.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Товар удален");
                        ((formMenu)Tag).fillMainPanelProduct();
                        this.Close();
                        cmd1.Cancel();

                    }
                }
               
            }
        }
    }
}
