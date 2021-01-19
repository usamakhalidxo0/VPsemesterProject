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
    public partial class EditItemsForm : Form
    {
        private DataTable table;
        public EditItemsForm()
        {
            InitializeComponent();
        }

        private void SellItems_Load(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "Leave the field empty to get all items");
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
                UpdateItemForm updt = new UpdateItemForm(table.Rows[e.RowIndex]);
                updt.Show();
            }
            
        }
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MainMenu menu = new MainMenu();
            menu.Show();
            Visible = false;
        }

        private void addcategorybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCategoryForm addcategory = new AddCategoryForm();
            addcategory.Show();
        }

        private void addbrandbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddBrandForm addbrand = new AddBrandForm();
            addbrand.Show();
        }

        private void additembutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddItemForm additem = new AddItemForm();
            additem.Show();
        }

        private void EditCategorybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditCategoryForm editcategory = new EditCategoryForm();
            editcategory.Show();
        }

        private void Editbrandbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditBrandForm editbrand = new EditBrandForm();
            editbrand.Show();
        }

        private void Edititembutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditItemsForm edititem = new EditItemsForm();
            edititem.Show();
        }

        private void Deletecategorybutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteCategoryForm deletecategory = new DeleteCategoryForm();
            deletecategory.Show();
        }

        private void DeleteBrandbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteBrandForm deletebrand = new DeleteBrandForm();
            deletebrand.Show();
        }

        private void DeleteItembutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteItemForm deleteitem = new DeleteItemForm();
            deleteitem.Show();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
          
        }
    }
}
