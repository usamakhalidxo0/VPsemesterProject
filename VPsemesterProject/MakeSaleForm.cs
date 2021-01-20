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
    public partial class MakeSaleForm : Form
    {
        DataTable table;
        string salesid;
        public CartForm previous;
        public MakeSaleForm(DataTable data, CartForm previous)
        {
            this.previous = previous;
            this.table = data.Copy();
            this.salesid = "salesid " + DateTime.Now.ToString().Replace(':', '_');

            table.Columns.Add("total", typeof(int));
            int grandtotal = 0;
            foreach (DataRow r in table.Rows)
            {
                int total = r.Field<int>("price") * r.Field<int>("amount");
                grandtotal += total;
                r.SetField<int>("total", total);
                     
            }
            DataRow last = table.NewRow();
            last.SetField<int>("total", grandtotal);
            last.SetField<string>("productname", salesid);
            table.Rows.Add(last);
            InitializeComponent();
            dataGridView1.DataSource = this.table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int recievedAmount;
            try
            {
                recievedAmount = Convert.ToInt32(textBox1.Text);
                if (recievedAmount <= 0)
                {
                    throw new Exception(" amount less or equal to zero cant be accepted");
                }
                int bill = table.Rows[table.Rows.Count - 1].Field<int>("total");
                if (bill <= recievedAmount)
                {
                    Instance.cart.makeSale(table, salesid,bill,recievedAmount);
                    MessageBox.Show("Sale Successful!");
                    this.previous.previous.previous.Show();
                    this.previous.previous.Close();
                    this.previous.Close();
                    this.Close();
                }
                else
                {
                    if(MessageBox.Show("Are you sure you want to continue?", "Recieved amount entered is less than bill!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        Instance.cart.makeSale(table, salesid, bill, recievedAmount);
                        MessageBox.Show("Sale Successful!");
                        this.previous.previous.previous.Show();
                        this.previous.previous.Close();
                        this.previous.Close();
                        this.Close();
                    }
                }
            }
            catch(FormatException ex)
            {
                MessageBox.Show("Enter a valid number for amount!",ex.Message);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            previous.Show();
            this.Close();
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
        private void MakeSaleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
