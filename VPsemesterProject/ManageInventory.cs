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
    public partial class ManageInventory : Form
    {
        public ManageInventory()
        {
            InitializeComponent();
        }

        private void addcategorybutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            AddCategoryForm addcategory = new AddCategoryForm();
            addcategory.Show();
         
        }

        private void addbrandbutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            AddBrandForm addbrand = new AddBrandForm();
            addbrand.Show();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            AddItemForm additem = new AddItemForm();
            additem.Show();
        }

        private void EditCategorybutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            EditCategoryForm editcategory = new EditCategoryForm();
            editcategory.Show();
        }

        private void Editbrandbutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            EditBrandForm editbrand = new EditBrandForm();
            editbrand.Show();
        }

        private void Edititembutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            EditItemsForm edititem = new EditItemsForm();
            edititem.Show();
        }

        private void Deletecategorybutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            DeleteCategoryForm deletecategory = new DeleteCategoryForm();
            deletecategory.Show();
        }

        private void DeleteBrandbutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            DeleteBrandForm deletebrand = new DeleteBrandForm();
            deletebrand.Show();
        }

        private void DeleteItembutton_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            MessageBox.Show("Screen is loading");
            this.Hide();
            DeleteItemForm deleteitem = new DeleteItemForm();
            deleteitem.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
            MainMenu menu = new MainMenu();
            menu.Show();
            Visible = false;
           
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox3.Dispose();
            label1.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
