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
    public partial class EditCategoryForm : Form
    {
        public EditCategoryForm()
        {
            InitializeComponent();
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow r in Connection.getCategories().Rows)
            {
                comboBox1.Items.Add(r.Field<string>("name"));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.updateCategory(comboBox1.Text, textBox1.Text);
            MessageBox.Show("Your Category has been updated!");
        }
    }
}
