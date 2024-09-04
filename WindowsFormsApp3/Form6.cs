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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "INSERT INTO hospital.room VALUES(" + textBox1.Text + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + "," + "'" + textBox4.Text + "'" + ","+ textBox5.Text  + ")";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted sucessfully");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from hospital.room", "server = DESKTOP-E79HGFU; database = HMS; UID = sa; password = SZABIST@100");
            DataSet ds = new DataSet();
            da.Fill(ds, "hospital.room");
            dataGridView1.DataSource = ds.Tables["hospital.room"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "DELETE FROM hospital.room WHERE Roomno =" + "'" + textBox1.Text + "'";

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

                string q = "update hospital.room set Roomno='" + textBox1.Text + "',Pateint_name='" + textBox2.Text + "',Doctor_attending='" + textBox3.Text + "',room_type='" + textBox4.Text + "',room_charges='" + textBox5.Text + "' where roomno='" + textBox1.Text + "';";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Sucessfully");

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }
        public void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
          

        }
        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
    }
