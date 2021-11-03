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

namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        private void Checkin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            con.Open();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Lbltxt2.UseSystemPasswordChar = false;
                Lbltxt3.UseSystemPasswordChar = false;
            }
            else
            {
                Lbltxt2.UseSystemPasswordChar = true;
                Lbltxt3.UseSystemPasswordChar = true;
            }
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Lbltxt3.Text != string.Empty || Lbltxt2.Text != string.Empty || Lbltxt1.Text != string.Empty)
            {
                if (Lbltxt2.Text == Lbltxt3.Text)
                {
                    cmd = new SqlCommand("select * from LoginTable where username='" + Lbltxt1.Text + "'", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dr.Close();
                        cmd = new SqlCommand("insert into LoginTable values(@username,@password)", con);
                        cmd.Parameters.AddWithValue("username", Lbltxt1.Text);
                        cmd.Parameters.AddWithValue("password", Lbltxt2.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Login login = new Login();
                        this.Hide();
                        login.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both password same ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
