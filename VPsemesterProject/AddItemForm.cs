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
    public partial class AddItemForm : Form
    {
        public AddItemForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.addProduct(textBox1.Text, comboBox2.Text, comboBox1.Text, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox3.Text));
                MessageBox.Show("Product added successfully!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddItemForm_Load(object sender, EventArgs e)
        {
            DataTable categories = Connection.getCategories();
            foreach (DataRow row in categories.Rows)
            {
                comboBox1.Items.Add(row.Field<string>("name"));
            }
            DataTable brands = Connection.getBrands();
            foreach (DataRow row in brands.Rows)
            {
                comboBox2.Items.Add(row.Field<string>("name"));
            }
        }
    }
}
