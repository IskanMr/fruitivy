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
    public partial class EditBarang : Form
    {
        private int _idBarang { get; set; }
        private int _idPenjual { get; set; }
        public EditBarang(int idB, int idP )
        {
            InitializeComponent();
            _idBarang = idB;
            _idPenjual = idP;
        }

        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=fishman14;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        public void EditBarang_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            GetItemInfo();
        }

        private void GetItemInfo()
        {
            try
            {
                conn.Open();
                sqlQuery = @"select * from produk_r_produkid(:_id)";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_id", _idBarang);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {                        
                        tbEditNamaProduk.Text = Convert.ToString(rd[0]);
                        tbEditHargaProduk.Text = Convert.ToString(rd[1]);
                        tbEditDeskripsiProduk.Text = Convert.ToString(rd[2]);
                    }
                }                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpanPerubahan_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                sqlQuery = @"select * from produk_u_pengguna(:_nama, :_harga, :_deskripsi, :_id)";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_nama", tbEditNamaProduk.Text);
                cmd.Parameters.AddWithValue("_harga", int.Parse(tbEditHargaProduk.Text));
                cmd.Parameters.AddWithValue("_deskripsi", tbEditDeskripsiProduk.Text);
                cmd.Parameters.AddWithValue("_id", _idBarang);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    ListItemPage listIP = new ListItemPage(_idPenjual);
                    listIP.Show();
                    MessageBox.Show("Barang berhasil diedit", "Edit Barang Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Masukkan Nilai Sesuai Kolom", "Edit Barang Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Fail!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
