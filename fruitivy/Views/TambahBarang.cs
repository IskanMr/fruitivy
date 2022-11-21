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
    public partial class TambahBarang : Form
    {

        private int _penjualId;
        private int PenjualId { get { return _penjualId; } set { _penjualId = value; } }
        public TambahBarang(int id)
        {
            InitializeComponent();
            PenjualId = id;
        }


        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;Username=postgres;Password=fishman14;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        private void btnUnggah_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                sqlQuery = @"select * from produk_c_pengguna(:_nama, :_harga, :_deskripsi, :_penggunaid)";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_nama", tbTambahNamaProduk.Text);
                cmd.Parameters.AddWithValue("_harga", int.Parse(tbTambahHargaProduk.Text));
                cmd.Parameters.AddWithValue("_deskripsi", tbTambahDeskripsiProduk.Text);
                cmd.Parameters.AddWithValue("_penggunaid", int.Parse(PenjualId.ToString()));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    ListItemPage listItemDijual = new ListItemPage(PenjualId);
                    listItemDijual.Show();
                    this.Hide();
                    MessageBox.Show("Produk berhasil ditambahkan!");
                }
                else
                {
                    MessageBox.Show("Produk gagal ditambahkan", "Gagal!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Produk gagal ditambahkan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TambahBarang_Load_1(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
        }
    }
}
