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
        MainMenu previous;
        public ManageInventory(MainMenu previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void addcategorybutton_Click(object sender, EventArgs e)
        {
           
           
            this.Hide();
            AddCategoryForm addcategory = new AddCategoryForm(this);
            addcategory.Show();
         
        }

        private void addbrandbutton_Click(object sender, EventArgs e)
        {
         
            this.Hide();
            AddBrandForm addbrand = new AddBrandForm(this);
            addbrand.Show();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            AddItemForm additem = new AddItemForm(this);
            additem.Show();
        }

        private void EditCategorybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCategoryForm editcategory = new EditCategoryForm(this);
            editcategory.Show();
        }

        private void Editbrandbutton_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            EditBrandForm editbrand = new EditBrandForm(this);
            editbrand.Show();
        }

        private void Edititembutton_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            EditItemsForm edititem = new EditItemsForm(this);
            edititem.Show();
        }

        private void Deletecategorybutton_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            DeleteCategoryForm deletecategory = new DeleteCategoryForm(this);
            deletecategory.Show();
        }

        private void DeleteBrandbutton_Click(object sender, EventArgs e)
        {
         
           
            this.Hide();
            DeleteBrandForm deletebrand = new DeleteBrandForm(this);
            deletebrand.Show();
        }

        private void DeleteItembutton_Click(object sender, EventArgs e)
        {
           
         
            this.Hide();
            DeleteItemForm deleteitem = new DeleteItemForm(this);
            deleteitem.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            this.previous.Show();
            this.Close();
           
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
        private void ManageInventory_Load(object sender, EventArgs e)
        {
            
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
         
          
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
