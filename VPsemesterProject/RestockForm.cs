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
        DataRow item;
        public RestockForm()
        {
            InitializeComponent();
        }
        public RestockForm(DataRow row)
        {
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
            int quantiy = Convert.ToInt32(textBox1.Text);
            if (quantiy > 0)
            {
                Connection.updateProduct(item.Field<int>("id"), item.Field<string>("productname"), item.Field<string>("category"), item.Field<string>("brand"), item.Field<int>("price"), quantiy);
                item.Delete();
                MessageBox.Show("Item has been restocked!");
            }
            else MessageBox.Show("Stock is still empty!");
        }
    }
}
