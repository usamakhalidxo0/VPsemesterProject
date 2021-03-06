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
    public partial class AddCategoryForm : Form
    {
        ManageInventory previous;
        public AddCategoryForm(ManageInventory previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if ((errorProvider1.GetError(textBox1) == ""))
            {
                try
                {
                    Connection.addCategory(textBox1.Text);
                    MessageBox.Show("Category added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Kindly first enter data in correct format");
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
        private void AddCategoryForm_Load(object sender, EventArgs e)
        {

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
	
	            for (int i = 0; i<testArr.Length; i++)
	            {
	                if (!char.IsLetter(testArr[i]))
	                {
	                    testBool = true;
	                }else { testBool = false; }
	            }
	
	            return testBool;
	        }

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }
    }
}
