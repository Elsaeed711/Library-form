using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_form
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\HqNw\\Desktop\\vs\\Library-form\\Library form\\Database1.mdf\";Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM libra WHERE name = '" + textBox2.Text + "' and id = " + textBox3.Text + "";
            SqlCommand command = new SqlCommand(query, conn);

            conn.Open();
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            string name = reader["name"].ToString();
            string price = reader["price"].ToString();
            bool available = Convert.ToBoolean(reader["available"]);
            conn.Close();

            string labe = "name: " + name + "\nprice: " + price + "\navailable: " + available;

            label1.Text = labe;
            //
        }
    }
}
