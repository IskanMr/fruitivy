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

        public Image Img { get { return _img; } set { _img = value; } }
        public string Nama { get { return _nama; } set { _nama = value; lblNama.Text = value; } }
        public int Harga { get { return _harga; } set { _harga = value; lblHarga.Text = value.ToString(); } }
        public int Id { get { return _id;} set { _id =value;} }

        private void lblEdit_Click(object sender, EventArgs e)
        {

        }

        private void lblHapus_Click(object sender, EventArgs e)
        {

        }
    }
}
