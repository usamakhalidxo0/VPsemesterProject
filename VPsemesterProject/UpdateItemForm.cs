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
    public partial class UpdateItemForm : Form
    {
        EditItemsForm previous;
        private DataRow item;
        public UpdateItemForm(DataRow row, EditItemsForm previous)
        {
            this.previous = previous;
            InitializeComponent();
            item = row;
            label1.Text = row.Field<int>("id").ToString();
            textBox1.Text = row.Field<string>("productname");
            foreach(DataRow r in Connection.getCategories().Rows)
            {
                comboBox1.Items.Add(r.Field<string>("name"));
            }
            comboBox1.Text = row.Field<string>("category");
            foreach (DataRow r in Connection.getBrands().Rows)
            {
                comboBox2.Items.Add(r.Field<string>("name"));
            }
            comboBox2.Text = row.Field<string>("brand");
            textBox2.Text = row.Field<int>("price").ToString();
            textBox3.Text = row.Field<int>("quantity").ToString();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((errorProvider1.GetError(textBox1) == "") && (errorProvider2.GetError(textBox2) == "") && (errorProvider3.GetError(textBox3) == ""))
            {
                item.SetField<string>("productname", textBox1.Text);
                item.SetField<string>("category", comboBox1.Text);
                item.SetField<string>("brand", comboBox2.Text);
                item.SetField<int>("price", Convert.ToInt32(textBox2.Text));
                item.SetField<int>("quantity", Convert.ToInt32(textBox3.Text));
                Connection.updateProduct(item.Field<int>("id"), item.Field<string>("productname"), item.Field<string>("category"), item.Field<string>("brand"), item.Field<int>("price"), item.Field<int>("quantity"));
                MessageBox.Show("Your product has been updated");
            }
            else
            {
                MessageBox.Show("Kindly enter all data in correct format");
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
        private void UpdateItemForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string str = textBox2.Text;
            if (txtEmptyStringIsValid(str) == false)
            {
                if (txtAlphaStringIsValid(str) == true)
                {
                    errorProvider2.SetError(textBox2, "");
                }
                else
                {
                    errorProvider2.SetError(textBox2, "Price should be in digit");
                }
            }
            else
            {
                errorProvider2.SetError(textBox2, "Provide Price");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string str = textBox3.Text;
            if (txtEmptyStringIsValid(str) == false)
            {
                if (txtAlphaStringIsValid(str) == true)
                {
                    errorProvider3.SetError(textBox3, "");
                }
                else
                {
                    errorProvider3.SetError(textBox3, "quantity should be in digit");
                }
            }
            else
            {
                errorProvider3.SetError(textBox3, "Provide quantity");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }
    }
}
