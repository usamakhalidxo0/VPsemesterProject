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
    public partial class AddBrandForm : Form
    {
        public AddBrandForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((errorProvider1.GetError(textBox1) == ""))
            {
                try
                {
                    Connection.addBrand(textBox1.Text);
                    MessageBox.Show("Brand Added Successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else { MessageBox.Show("Kindly first enter data in correct format"); }
        }
        private bool txtEmptyStringIsValid(string str)
        {

            if (str == string.Empty)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool txtAlphaStringIsValid(string str)
        {

            // test each character in the textbox
            char[] testArr = str.ToCharArray();
            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {
                if (!char.IsLetter(testArr[i]))
                {
                    testBool = true;
                }
                else { testBool = false; }
            }

            return testBool;
        }

       
        private void AddBrandForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

            string str = textBox1.Text;
            if (txtEmptyStringIsValid(str) == false)
            {
                if (txtAlphaStringIsValid(str) == false)
                {
                    errorProvider1.SetError(textBox1, "");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "Name should be letter");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Provide Name");
            }

        }

        private void addcategorybutton_Click(object sender, EventArgs e)
        {
          
            this.Hide();
            AddCategoryForm addcategory = new AddCategoryForm();
            addcategory.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageInventory manageinventory = new ManageInventory();
            manageinventory.Show();
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
    }
}
