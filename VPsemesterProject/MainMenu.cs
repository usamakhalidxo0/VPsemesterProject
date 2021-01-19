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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageInventory manageinventory = new ManageInventory(this);
            manageinventory.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SellItemsForm sellitem = new SellItemsForm(this);
            this.Hide();
            sellitem.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OutOfStockForm outstock = new OutOfStockForm(this);
            outstock.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AllSalesForm sales = new AllSalesForm(this);
            sales.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
