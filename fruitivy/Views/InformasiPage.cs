using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using fruitivy.Views;
using MongoDB.Driver;

namespace fruitivy
{
    public partial class InformasiPage : Form
    {
        public InformasiPage()
        {
            InitializeComponent();
        }
        private async Task<List<Information>> GetInfoList()
        {
            string conString = "mongodb+srv://MainUser:1234@fruitivyinfos.mc2t2pj.mongodb.net/test";
            string dbName = "Fruitivy";
            string colName = "Infos";

            var client = new MongoClient(conString);
            var db = client.GetDatabase(dbName);
            var col = db.GetCollection<Information>(colName);

            var results = await col.FindAsync(_ => true);
            return results.ToList();
        }

        private async void GenerateDynamicUserControl()
        {
            flowLayoutPanel1.Controls.Clear();

            var infos = await GetInfoList();

            InformationBox[] listInfos = new InformationBox[infos.Count];

            for (int i = 0; i < infos.Count; i++)
            {
                listInfos[i] = new InformationBox();

                listInfos[i].Title = infos[i].Title;
                listInfos[i].Type = infos[i].Type;
                listInfos[i].Description = infos[i].Description;

                flowLayoutPanel1.Controls.Add(listInfos[i]);

                listInfos[i].Click += new System.EventHandler(this.UserControl_Click);
            } 
        }

        void UserControl_Click(object sender, EventArgs e)
        {
            InformationBox obj = (InformationBox)sender;
            DetailInformasi detailInformasi = new DetailInformasi(obj.Title, obj.Type, obj.Description);
            detailInformasi.Show();
        }

        private async void InformasiPage_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}
