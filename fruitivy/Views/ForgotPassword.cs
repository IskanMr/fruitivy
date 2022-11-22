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

namespace fruitivy.Views
{
    public partial class ForgotPassword : Form
    {
        public ForgotPassword()
        {
            InitializeComponent();
        }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=fishman14;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        private void btnResetPass_Click(object sender, EventArgs e)
        {

            try
            {
                conn.Open();

                sqlQuery = @"select * from pengguna_u_forgetpassword(:_email, :_password)";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_email", tbEmailForgotPass.Text);
                cmd.Parameters.AddWithValue("_password", tbNewPass.Text);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    LoginForm login = new LoginForm();
                    login.Show();
                    this.Hide();
                    MessageBox.Show("Password berhasil diubah!");
                }
                else
                {
                    MessageBox.Show("Email tidak ditemukan!", "Reset Password Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Reset Password Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
