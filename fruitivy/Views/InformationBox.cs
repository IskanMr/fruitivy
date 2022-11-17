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
    public partial class InformationBox : UserControl
    {
        public InformationBox()
        {
            InitializeComponent();
        }

        private string _title;
        private string _type;
        private string _description;

        public string Title { get { return _title; } set { _title = value; lblInfoTitle.Text = value; } }
        public string Type { get { return _type; } set { _type = value; lblInfoType.Text = value;  } }
        public string Description { get { return _description; } set { _description = value; } }

        private void linkInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DetailInformasi detailInformasi = new DetailInformasi(Title, Type, Description);
            detailInformasi.Show();
        }
    }
}
