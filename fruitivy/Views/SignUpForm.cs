using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fruitivy
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=fishman14;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        private void btnMasuk_Click(object sender, EventArgs e)
        {
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
                cmd.Parameters.AddWithValue("_username", tbUsernameSignUp.Text);
                cmd.Parameters.AddWithValue("_password", tbPasswordSignUp.Text);
                cmd.Parameters.AddWithValue("_email", tbEmailSignUp.Text);
                cmd.Parameters.AddWithValue("_roleid", roleId);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Sign Up Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }

    }
}
