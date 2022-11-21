using MongoDB.Driver;
using System;
using Npgsql;
using System.Windows.Forms;
using fruitivy.Views;

namespace fruitivy
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();                  
        }


        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=2022;Username=postgres;Password=informatika;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                int roleId = 0;
                if (rbPembeliLogin.Checked)
                    roleId = 1;
                else
                    roleId = 2;

                sqlQuery = @"select * from pengguna_r_login(:_username, :_password, :_roleid)";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_username", tbUsernameLogin.Text);
                cmd.Parameters.AddWithValue("_password", tbPasswordLogin.Text);
                cmd.Parameters.AddWithValue("_roleid", roleId);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    // listItemUser = new ListItemUser();
                    //listItemUser.Show();
                    //this.Hide();
                    MessageBox.Show("Login berhasil!");
                }
                else
                {
                    MessageBox.Show("Username dan Password tidak valid!", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            ForgotPassword forgotPass = new ForgotPassword();
            forgotPass.Show();
            this.Hide();
        }

        private void lblDaftar_Click_1(object sender, EventArgs e)
        {
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
