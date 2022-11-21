using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruitivy.Models
{
    public class Produk
    {
        private int _id;
        private string _nama;
        private string _deskripsi;
        private int _harga;

        public int Id { get { return _id; } set { _id = value; } }
        public string Nama { get { return _nama; } set { _nama = value; } }
        public string Deskripsi { get { return _deskripsi; } set { _deskripsi = value; } }
        public int Harga { get { return _harga; } set { _harga = value; } }
    }
}
