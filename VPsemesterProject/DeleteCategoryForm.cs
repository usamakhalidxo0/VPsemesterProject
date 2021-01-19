﻿using System;
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
    public partial class DeleteCategoryForm : Form
    {
        public DeleteCategoryForm()
        {
            InitializeComponent();
        }

        private void DeleteCategoryForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow r in Connection.getCategories().Rows)
            {
                comboBox1.Items.Add(r.Field<string>("name"));
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connection.getItemsInCategory(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.deleteCategory(comboBox1.Text);

                MessageBox.Show("category succcessfully deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting category", ex.Message);
            }
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
    }
}
