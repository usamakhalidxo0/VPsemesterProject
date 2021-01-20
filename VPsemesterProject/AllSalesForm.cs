
﻿using System;
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
    public partial class AllSalesForm : Form
    {
        MainMenu previous;
        DataTable sales;
        public AllSalesForm(MainMenu previous)
        {
            this.previous = previous;
            InitializeComponent();
        }

        private void AllSalesForm_Load(object sender, EventArgs e)
        {
            sales = Connection.getAllSales();
            dataGridView1.DataSource = sales;
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                ViewSaleForm receipt = new ViewSaleForm(sales.Rows[e.RowIndex].Field<string>("salesid"),this);
                receipt.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
