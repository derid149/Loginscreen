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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection cn;
        SqlCommand cmd;
        private void Login_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True");
            cn.Open();
            Lbltxt2.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 registration = new Form1();
            registration.ShowDialog();
        }

        private void Checkin_Click(object sender, EventArgs e)
        {

            if (Lbltxt2.Text != string.Empty || Lbltxt1.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from LoginTable where username='" + Lbltxt1.Text + "' and password='" + Lbltxt2.Text + "'", cn);
               SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Login Successfull!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Hide();
                    
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
           
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Lbltxt2.UseSystemPasswordChar = false;
            else
                Lbltxt2.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Lbltxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbltxt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
