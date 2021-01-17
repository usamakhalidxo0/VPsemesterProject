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
    public partial class DeleteBrandForm : Form
    {
        public DeleteBrandForm()
        {
            InitializeComponent();
        }

        private void DeleteBrandForm_Load(object sender, EventArgs e)
        {
            foreach (DataRow r in Connection.getBrands().Rows)
            {
                comboBox1.Items.Add(r.Field<string>("name"));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connection.getItemsInBrand(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.deleteBrand(comboBox1.Text);
        }
    }
}
