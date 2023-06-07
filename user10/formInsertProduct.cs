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
    public partial class formInsertProduct : Form
    {
        public formInsertProduct()
        {
            InitializeComponent();
        }

        private void formInsertProduct_Load(object sender, EventArgs e)
        {
            //заполнение выпадающего списка значениями
            var cmd = new NpgsqlCommand("select manufacturername from manufacturer", Program.connection);
            
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBoxManuf.Items.Add(reader["manufacturername"]);
            }
            cmd.Cancel();
            reader.Close();
        }

        private void buttonInsertProd_Click(object sender, EventArgs e)
        {
            //кнопка добавления
            if (textBoxCost.Text == "" || textBoxDesc.Text == "" || textBoxName.Text == "" || comboBoxManuf.Text == "" )
            {
                MessageBox.Show("Заполнены не все поля");
            }
            else
            {
                if (textBoxCost.Text.All(char.IsDigit))
                {
                    var cmd = new NpgsqlCommand($"INSERT INTO   public.product(productname,  description,  productcost,  manufacturer) VALUES ('{textBoxName.Text}', '{textBoxDesc.Text}', {textBoxCost.Text}, {comboBoxManuf.SelectedIndex + 1})", Program.connection);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Товар добавлен");
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
    }
}
