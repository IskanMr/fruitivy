using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MongoDB.Driver;

namespace fruitivy
{
    public partial class InformasiPage : Form
    {
        public InformasiPage()
        {
            InitializeComponent();

        }
        public async static void GetInfoList()
        {
            List<Informations> infos = new List<Informations>();
            string conString = "mongodb+srv://MainUser:1234@fruitivyinfos.mc2t2pj.mongodb.net/test";
            string dbName = "Fruitivy";
            string colName = "Infos";

            var client = new MongoClient(conString);
            var db = client.GetDatabase(dbName);
            var col = db.GetCollection<Informations>(colName);

            // var infoOne = new Informations { Title = "Test Satuuu", Description = "Descripsi bla bla bla", Type = "Sayur" };

            // await col.InsertOneAsync(infoOne);

            var results = await col.FindAsync(_ => true);
            foreach (var result in results.ToList())
            {
                infos.Add(result);
                Console.WriteLine(value: $"RESULTS: {result.Title}: {result.Description}: {result.Type}");
            }            
        }

        private void InformasiPage_Load(object sender, EventArgs e)
        {

        }
    }
}
