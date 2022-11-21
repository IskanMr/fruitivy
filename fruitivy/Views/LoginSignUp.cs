using Npgsql;
using System.Data;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruitivy
{
    public partial class LoginSignUp : Form
    {
        public LoginSignUp()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sign Up berhasil!");
            try
            {
                conn.Open();
                int roleId = 0;
                if (rbPembeliSignUp.Checked)
                    roleId = 1;
                else
                    roleId = 2;

                sqlQuery = @"select * from pengguna_c_signup(:_username, :_password, :_email, :_roleid)";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_username", tbUsernamSignUp.Text);
                cmd.Parameters.AddWithValue("_password", tbPasswordSignUp.Text);
                cmd.Parameters.AddWithValue("_email", tbEmailSignUp.Text);
                cmd.Parameters.AddWithValue("_roleid", roleId);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    Login login = new Login();
                    login.Show();
                    this.Hide();
                }
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Sign Up Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginSignUp_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);

        }
    }
}