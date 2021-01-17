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
    public partial class EditItemsForm : Form
    {
        private DataTable table;
        public EditItemsForm()
        {
            InitializeComponent();
        }

        private void SellItems_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                table = Connection.search(textBox1.Text);
                dataGridView1.DataSource = table;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                UpdateItemForm updt = new UpdateItemForm(table.Rows[e.RowIndex]);
                updt.Show();
            }
            
        }
    }
}
