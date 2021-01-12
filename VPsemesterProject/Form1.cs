using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
namespace VPsemesterProject
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=test2;port=3306;username=root;password=pakistan");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            MySqlCommand cmd = new MySqlCommand("insert into mytable1(ID,name,Sur_Name,Age)Values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved");
            connection.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from mytable1 where ID=12";
            connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data removed");
            connection.Close();
        }
        public void displayData()
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from test2.mytable1";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update test2.mytable1 set Sur_Name='" + textBox3.Text + "'where Sur_Name='" + textBox2.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            connection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CartForm cartform = new CartForm();
            cartform.Show();
        }
    }
}

