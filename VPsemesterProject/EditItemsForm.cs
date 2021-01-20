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
        ManageInventory previous;
        private DataTable table;
        public EditItemsForm(ManageInventory previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void SellItems_Load(object sender, EventArgs e)
        {
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "Leave the field empty to get all items");
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
        private void button1_Click(object sender, EventArgs e)
        {
           
                try
                {
                    table = Connection.search(textBox1.Text);
                    dataGridView1.DataSource = table;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                UpdateItemForm updt = new UpdateItemForm(table.Rows[e.RowIndex],this);
                updt.Show();
            }
            
        }
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }


        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                table = Connection.getItemsById();
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
