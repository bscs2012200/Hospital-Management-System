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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "INSERT INTO hospital.patient VALUES(" + textBox1.Text + "," + "'" + textBox2.Text + "'" + "," + "'" + textBox3.Text + "'" + "," + "'" + textBox4.Text + "'" + "," + "'" + textBox5.Text + "'" + "," + "'" + textBox6.Text + "'" + ")";

                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Inserted sucessfully");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from hospital.patient", "server = DESKTOP-E79HGFU; database = HMS; UID = sa; password = SZABIST@100");
            DataSet ds = new DataSet();
            da.Fill(ds, "hospital.patient");
            dataGridView1.DataSource = ds.Tables["hospital.patient"].DefaultView;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-E79HGFU;Initial Catalog=HMS;Integrated Security=True");
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {

                string q = "DELETE FROM hospital.patient WHERE Patient_id =" + "'" + textBox1.Text + "'";

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

                string q = "update hospital.patient set Patient_id='" + textBox1.Text + "',First_name='" + textBox2.Text + "',Last_name='" + textBox3.Text + "',Disease='" + textBox4.Text + "',Room_no='" + textBox5.Text + "',Admission_date='" + textBox6.Text + "' where patient_id='" + textBox1.Text + "';";

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
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}