using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPsemesterProject
{
    public partial class SellItemsForm : Form
    {
        private DataTable table;
        public MainMenu previous;
        public SellItemsForm(MainMenu previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                table = Connection.search(textBox1.Text);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataRow row = table.Rows[e.RowIndex];
                if (row.Field<int>("quantity") <= 0)
                {
                    MessageBox.Show("Item out of stock!");
                }
                else
                {
                    if (Instance.cart.ids.Contains(row.Field<int>("id")))
                        MessageBox.Show("Item already present in cart.\n Go to cart to change amount");
                    else
                    {
                        Instance.cart.add(table.Rows[e.RowIndex]);
                        MessageBox.Show("Item added to cart!");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CartForm ctfm = new CartForm(this);
            ctfm.Show();
        }

        private void SellItemsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.BackColor = Color.LimeGreen;
            dataGridView1.ForeColor = Color.DarkGreen;
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                table = Connection.getItemsById();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
