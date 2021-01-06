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
        MySqlConnection connection = new MySqlConnection("server=localhost;database=projectschema;port=3306;username=root;password=pakistan");
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = new MySqlCommand("insert into profile(Name,ID,Semester,Department)Values('" + textBox1.Text + "','" + Convert.ToInt32(textBox2.Text) + "','" + Convert.ToInt32(textBox3.Text) + "','" + textBox4.Text + "')", connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data saved");
            connection.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = connection.CreateCommand();

            cmd.CommandType = CommandType.Text;
            //+ "','"+textBox3.Text+"','"+textBox4.Text+"'   
            cmd.CommandText = "delete from profile where Name='" + textBox1.Text+"' ";
            connection.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data removed");
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update profile set Name='Usama' where Name= '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            connection.Close();
        }
        public void displayData()
        {
            connection.Open();
            MySqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from profile";
            cmd.ExecuteNonQuery();
            DataTable DT = new DataTable();
            MySqlDataAdapter DA = new MySqlDataAdapter(cmd);
            DA.Fill(DT);
            dataGridView1.DataSource = DT;
            connection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayData();
        }
    }
}
