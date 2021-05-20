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

namespace Time_Table_Management_System
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=us-cdbr-east-03.cleardb.com;Database=heroku_bcf68a92068cc8d;Uid=b4c4846ae4a54f;Pwd=8d771c56;";
        int idWorking_dayshourst ;
    
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                mysqlCon.Open();
                MySqlCommand mysqlCmd = new MySqlCommand("Add_Workingdayshours", mysqlCon);
                mysqlCmd.CommandType = CommandType.StoredProcedure;

                mysqlCmd.Parameters.AddWithValue("_Manage_time_slot;" , idWorking_dayshours);
                mysqlCmd.Parameters.AddWithValue("_start_time_h", textBox1.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_start_time_m", textBox4.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_Duration", textBox2.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_end_time_h", textBox3.Text.Trim());
                mysqlCmd.Parameters.AddWithValue("_end_time_m", textBox5.Text.Trim());

                mysqlCmd.ExecuteNonQuery();
                MessageBox.Show("Submitted Successfully!!");


            }

            Clear();
        }
        void Clear()
        {
            textBox1.Text = textBox4.Text = textBox2.Text = textBox3.Text = textBox5.Text ="";


            idWorking_dayshours = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
