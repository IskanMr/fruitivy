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
    public partial class ListItemPage : Form
    {

        private int _penjualId;
        private int PenjualId { get { return _penjualId; }set { _penjualId = value; } }
        List<Produk> listItem = new List<Produk>();
        public ListItemPage(int id)
        {
            InitializeComponent();
            PenjualId = id;
        }

        private NpgsqlConnection conn;
        private string connstring = "Host=localhost;Port=5432;Username=postgres;Password=fishman14;Database=FruitivyTest2;";
        private string sqlQuery = "";
        public static NpgsqlCommand cmd;

        private async void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            try
            {
                conn.Open();

                sqlQuery = @"select * from produk_r_penjual(:_penggunaId)";
                cmd = new NpgsqlCommand(sqlQuery, conn);
                cmd.Parameters.AddWithValue("_penggunaId", PenjualId);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                if (rd.HasRows)
                {
                    while (rd.Read())
                    {
                        Produk p = new Produk();
                        p.Id = Convert.ToInt32(rd[0]);
                        p.Nama = Convert.ToString(rd[1]);
                        p.Harga = Convert.ToInt32(rd[2]);
                        p.Deskripsi = Convert.ToString(rd[3]);

                        listItem.Add(p);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Produk gagal ditambahkan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ItemBox[] listItems = new ItemBox[listItem.Count()];

            for (int i = 0; i < listItem.Count(); i++)
            {
                listItems[i] = new ItemBox();

                listItems[i].Nama = listItem[i].Nama;
                listItems[i].Harga = listItem[i].Harga;
                listItems[i].Id = listItem[i].Id;

                flowLayoutPanel1.Controls.Add(listItems[i]);
            }
        }

        private void ListItemPage_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            GenerateDynamicUserControl();
        }
    }
}
