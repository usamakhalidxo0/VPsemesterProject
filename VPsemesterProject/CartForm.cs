using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace VPsemesterProject
{
    public partial class CartForm : Form
    {
        public SellItemsForm previous;
        public CartForm(SellItemsForm previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                Instance.cart.remove(e.RowIndex);
            }
            if (e.ColumnIndex == 1)
            {
                try
                {
                    string input = Interaction.InputBox("Enter new amount", "Change Amount", Instance.cart.data.Rows[e.RowIndex]["amount"].ToString());
                    if (input != "")
                    {
                        int amount = Convert.ToInt32(input);
                        if (amount <= 0)
                            MessageBox.Show("Cannot set to zero or less. Use remove button to remove from cart!");
                        else
                            Instance.cart.changeAmount(e.RowIndex, amount);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private const int WS_SYSMENU = 0x80000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style &= ~WS_SYSMENU;
                return cp;
            }
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            dataGridView1.BackColor = Color.LimeGreen;
            dataGridView1.ForeColor = Color.DarkGreen;
            dataGridView1.Font = new Font("Microsoft Sans Serif", 11, FontStyle.Regular, GraphicsUnit.Point);
            dataGridView1.DataSource = Instance.cart.data;
            if (Instance.cart.data.Rows.Count==0)
                MessageBox.Show("No Items in cart");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Instance.cart.checkOut(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
        }
    }
}
