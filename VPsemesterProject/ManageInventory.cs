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
            AddCategoryForm addcategory = new AddCategoryForm();
            addcategory.Show();
        }

        private void addbrandbutton_Click(object sender, EventArgs e)
        {
            AddBrandForm addbrand = new AddBrandForm();
            addbrand.Show();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {

            AddItemForm additem = new AddItemForm();
            additem.Show();
        }

        private void EditCategorybutton_Click(object sender, EventArgs e)
        {
            EditCategoryForm editcategory = new EditCategoryForm();
            editcategory.Show();
        }

        private void Editbrandbutton_Click(object sender, EventArgs e)
        {
            EditBrandForm editbrand = new EditBrandForm();
            editbrand.Show();
        }

        private void Edititembutton_Click(object sender, EventArgs e)
        {
            EditItemForm edititem = new EditItemForm();
            edititem.Show();
        }

        private void Deletecategorybutton_Click(object sender, EventArgs e)
        {
            DeleteCategoryForm deletecategory = new DeleteCategoryForm();
            deletecategory.Show();
        }

        private void DeleteBrandbutton_Click(object sender, EventArgs e)
        {

            DeleteBrandForm deletebrand = new DeleteBrandForm();
            deletebrand.Show();
        }

        private void DeleteItembutton_Click(object sender, EventArgs e)
        {
            DeleteItemForm deleteitem = new DeleteItemForm();
            deleteitem.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
