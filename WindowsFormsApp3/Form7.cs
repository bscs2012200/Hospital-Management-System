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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "INSERT INTO hospital.appointment VALUES(" + textBox1.Text + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + "," + "'" + textBox4.Text + "'" + "," + "'" + textBox5.Text + "'" + "," + textBox6.Text + "," + textBox7.Text + ")";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted sucessfully");

            }
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from hospital.appointment", "server = DESKTOP-E79HGFU; database = HMS; UID = sa; password = SZABIST@100");
            DataSet ds = new DataSet();
            da.Fill(ds, "hospital.appointment");
            dataGridView1.DataSource = ds.Tables["hospital.appointment"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "DELETE FROM hospital.appointment WHERE Appt_id =" + "'" + textBox1.Text + "'";

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

                string q = "update hospital.appointment set Appt_id='" + textBox1.Text + "',Patient_name='" + textBox2.Text + "',Doctor_name='" + textBox3.Text + "',Date='" + textBox4.Text + "',Time='" + textBox5.Text + "',Doc_id='" + textBox6.Text + "',Pat_id='" + textBox7.Text + "' where Appt_id='" + textBox1.Text + "';";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Updated Sucessfully");

            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
