using MongoDB.Driver;
using System;
using Npgsql;
using System.Windows.Forms;
using fruitivy.Views;
using System.Data;

namespace fruitivy
{
    public partial class LoginForm : Form
    {
        private int id { get; set; }
        public LoginForm()
        {
            InitializeComponent();                  
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=fishman14;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

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

                NpgsqlDataReader rd = cmd.ExecuteReader();

                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        id = Convert.ToInt32(rd[0]);
                    }
                }


                if (id != 0)
                {
                    ListItemPage listItemUser = new ListItemPage(id);
                    listItemUser.Show();
                    this.Hide();
                    MessageBox.Show("Login berhasil!");
                }
                else
                {
                    LoginForm log = new LoginForm();
                    log.Show();
                    this.Hide();
                    MessageBox.Show("Username dan/atau Password serta/atau role tidak valid!", "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                LoginForm log = new LoginForm();
                log.Show();
                this.Hide();
                conn.Close();
                MessageBox.Show("Error:" + ex.Message, "Login Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
