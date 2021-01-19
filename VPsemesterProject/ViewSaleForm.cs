using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Attributes;
using ClosedXML.Excel;
using ClosedXML.Utils;

namespace VPsemesterProject
{
    public partial class ViewSaleForm : Form
    {
        AllSalesForm previous;
        public ViewSaleForm(string file, AllSalesForm previous)
        {
            this.previous = previous;
            InitializeComponent();
            XLWorkbook workBook = new XLWorkbook("reciepts\\" + file + ".xlsx");
            IXLWorksheet workSheet = workBook.Worksheet(1);

            DataTable dt = new DataTable();

            for(int i=0; i<workSheet.Rows().Count(); i++)
            {
                if (i == 0)
                {
                    foreach(IXLCell cell in workSheet.Row(i+1).Cells())
                    {
                        dt.Columns.Add(cell.Value.ToString());
                    }
                }
                else
                {
                    dt.Rows.Add();
                    for (int j=0; j< 7; j++)
                    {
                        dt.Rows[i-1][j] = workSheet.Row(i+1).Cell(j+1).Value.ToString();
                    }
                }
            }

            //bool firstRow = true;
            //foreach (IXLRow row in workSheet.Rows())
            //{
            //    if (firstRow)
            //    {
            //        foreach (IXLCell cell in row.Cells())
            //        {
            //            dt.Columns.Add(cell.Value.ToString());
            //        }
            //        firstRow = false;
            //    }
            //    else
            //    {
            //        dt.Rows.Add();
            //        int i = 0;
            //        foreach (IXLCell cell in row.Cells())
            //        {
            //            dt.Rows[dt.Rows.Count - 1][i] = cell.Value.ToString();
            //            i++;
            //        }
            //    }
            //}
            dataGridView1.DataSource = dt;
        }

        private void ViewSaleForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.previous.Show();
            this.Close();
        }
    }
}
