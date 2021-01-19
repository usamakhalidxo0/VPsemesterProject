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
    public partial class RestockForm : Form
    {
        OutOfStockForm previous;
        DataRow item;
        public RestockForm(DataRow row, OutOfStockForm previous)
        {
            this.previous = previous;
            InitializeComponent();
            item = row;
            label1.Text = row.Field<int>("id").ToString();
            label2.Text = row.Field<string>("productname");
            label3.Text = row.Field<string>("brand");
            label4.Text = row.Field<string>("category");
            label5.Text = row.Field<int>("price").ToString();
            textBox1.Text = row.Field<int>("quantity").ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((errorProvider1.GetError(textBox1) == ""))
            {
                int quantiy = Convert.ToInt32(textBox1.Text);
                if (quantiy > 0)
                {
                    Connection.updateProductQuantity(item.Field<int>("id"), quantiy);
                    item.Delete();
                    MessageBox.Show("Item has been restocked!");
                    this.previous.Show();
                    this.Close();
                }
                else MessageBox.Show("Stock is still empty!");
            }
            else
            {
                MessageBox.Show("Kindly enter correct quantity");
            }
        }

        private void RestockForm_Load(object sender, EventArgs e)
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            if (txtEmptyStringIsValid(str) == false)
            {
                if (txtAlphaStringIsValid(str) == true)
                {
                    errorProvider1.SetError(textBox1, "");
                }
                else
                {
                    errorProvider1.SetError(textBox1, "Quantity should be in digits");
                }
            }
            else
            {
                errorProvider1.SetError(textBox1, "Provide quantity");
            }
        }
    }
}
