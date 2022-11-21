using fruitivy.Models;
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
    public partial class ItemBox : UserControl
    {
        public ItemBox()
        {
            InitializeComponent();
        }
        private Image _img;
        private string _nama;
        private int _harga;
        private int _id;
        private int _idP;

        public Image Img { get { return _img; } set { _img = value; } }
        public string Nama { get { return _nama; } set { _nama = value; lblNama.Text = value; } }
        public int Harga { get { return _harga; } set { _harga = value; lblHarga.Text = value.ToString(); } }
        public int Id { get { return _id;} set { _id =value;} }
        public int IdPenjual { get { return _idP; } set { _idP = value; } }

        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=fishman14;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        private void lblEdit_Click(object sender, EventArgs e)
        {
            EditBarang editB = new EditBarang(Id, IdPenjual);
            editB.Show();
        }

        private void lblHapus_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sqlQuery = @"select * from produk_d_pengguna(:_id )";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_id", (Id));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    this.Hide();
                    MessageBox.Show("Produk berhasil dihapus!");
                }
                else
                {
                    MessageBox.Show("Produk Gagal Dihapus", "Coba Lagi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Produk Gagal Dihapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ItemBox_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
