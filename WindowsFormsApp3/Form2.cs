using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "INSERT INTO hospital.doctor VALUES(" + textBox1.Text + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + "," + "'" + textBox4.Text + "'" + ")";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted sucessfully");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from hospital.doctor", "server = DESKTOP-E79HGFU; database = HMS; UID = sa; password = SZABIST@100");
            DataSet ds = new DataSet();
            da.Fill(ds, "hospital.doctor");
            dataGridView1.DataSource = ds.Tables["hospital.doctor"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "DELETE FROM hospital.doctor WHERE ID =" + "'" + textBox1.Text + "'";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data deleted sucessfully");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "update hospital.doctor set ID='" + textBox1.Text + "',First_name='" + textBox2.Text + "',Last_name='" + textBox3.Text + "',Speciality='" + textBox4.Text + "' where id='" + textBox1.Text + "';";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated sucessfully");
            }
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}