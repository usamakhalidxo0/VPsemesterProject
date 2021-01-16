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
    public partial class SearchResultsSale : Form
    {
        DataTable results;
        public SearchResultsSale(DataTable results)
        {
            this.results = results;
            InitializeComponent();
        }

        public SearchResultsSale()
        {
            InitializeComponent();
        }

        private void SearchResultsSale_Load(object sender, EventArgs e)
        {
            listView1.Groups[0].Items.Add("jfdsjf");
            listView1.Groups[0].Items.Add("jfdsjf");
            listView1.Groups[1].Items.Add("jfdsjf");
            listView1.Groups[1].Items.Add("jfdsjf");

        }
    }
}
