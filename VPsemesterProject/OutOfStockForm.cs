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
    public partial class OutOfStockForm : Form
    {
        private DataTable table;
        public OutOfStockForm()
        {
            InitializeComponent();
        }

        private void OutOfStockForm_Load(object sender, EventArgs e)
        {
            table = Connection.getOutOfStock();
            dataGridView1.DataSource = table;
            if (table.Rows.Count==0)
                MessageBox.Show("No Results Found!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                RestockForm rstk = new RestockForm(table.Rows[e.RowIndex]);
                rstk.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu menu = new MainMenu();
            menu.Show();
        }
    }
}
