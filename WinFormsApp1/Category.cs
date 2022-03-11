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

namespace WinFormsApp1
{
    public partial class Category : Form
    {
        MySqlConnection connection =  new MySqlConnection("datasource =localhost;port=3306;username=root;password=");
      

        public Category()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String insertQuery = "INSERT INTO msc.category(name) VALUES('" + textBox1.Text+"')";
            connection.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, connection);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Date inserted!");
            }
            else
            {
                MessageBox.Show("Data Not inserted");
            }
            connection.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
