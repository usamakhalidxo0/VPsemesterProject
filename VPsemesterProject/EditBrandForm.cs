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
    public partial class EditBrandForm : Form
    {
        ManageInventory previous;
        public EditBrandForm(ManageInventory previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void EditBrandForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow r in Connection.getBrands().Rows)
            {
                comboBox1.Items.Add(r.Field<string>("name"));
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((errorProvider1.GetError(textBox1) == ""))
            {
                Connection.updateBrand(comboBox1.Text, textBox1.Text);
                MessageBox.Show("Your Brand has been updated!");
                comboBox1.Items.Clear();
                foreach (DataRow r in Connection.getBrands().Rows)
                {
                    comboBox1.Items.Add(r.Field<string>("name"));
                }
                comboBox1.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Kindly first enter data in correct format");

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

        private void label2_Click(object sender, EventArgs e)
        {

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
