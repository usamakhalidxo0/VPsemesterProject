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
        ManageInventory previous;
        public DeleteBrandForm(ManageInventory previous)
        {
            this.previous = previous;
            InitializeComponent();
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
        private void DeleteBrandForm_Load(object sender, EventArgs e)
        {

            foreach (DataRow r in Connection.getBrands().Rows)
            {
                comboBox1.Items.Add(r.Field<string>("name"));
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Connection.getItemsInBrand(comboBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Connection.deleteBrand(comboBox1.Text);

                MessageBox.Show("Brand succcessfully deleted");
                comboBox1.Items.Clear();
                foreach (DataRow r in Connection.getBrands().Rows)
                {
                    comboBox1.Items.Add(r.Field<string>("name"));
                }
                comboBox1.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while deleting brand", ex.Message);
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }
    }
}
