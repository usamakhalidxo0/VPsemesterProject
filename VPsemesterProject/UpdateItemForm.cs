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
        private DataRow item;
        public UpdateItemForm()
        {
            InitializeComponent();
        }
        public UpdateItemForm(DataRow row)
        {
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            item.SetField<string>("productname",textBox1.Text);
            item.SetField<string>("category", comboBox1.Text);
            item.SetField<string>("brand", comboBox2.Text);
            item.SetField<int>("price", Convert.ToInt32(textBox2.Text));
            item.SetField<int>("quantity", Convert.ToInt32(textBox3.Text));
            Connection.updateProduct(item.Field<int>("id"), item.Field<string>("productname"), item.Field<string>("category"), item.Field<string>("brand"), item.Field<int>("price"), item.Field<int>("quantity"));
            MessageBox.Show("Your product has been updated");
        }
    }
}
