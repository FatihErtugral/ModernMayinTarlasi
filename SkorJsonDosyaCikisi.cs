using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace WindowsFormsApp
{
    class SkorJsonDosyaCikisi
    {
        FileStream      fs;
        SkorJSonModel   model;
        
        public SkorJsonDosyaCikisi()
        {
            // Klasör yoksa klasörü oluştur.
            if (!Directory.Exists(Application.StartupPath + "\\Skor"))
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\Skor");

            // Skor.json yoksa veya silindiyse yenisini oluştur.
            if (!File.Exists(Application.StartupPath + "\\Skor\\Skor.json"))
            {
                fs = File.Create(Application.StartupPath + "\\Skor\\Skor.json");
                fs.Close();
                var model = new SkorJSonModel
                {
                    Version = "1.0.0123",
                    BillLists = {}
                };
                var serializerSettings              = new JsonSerializerSettings();
                serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                var json                            = JsonConvert.SerializeObject(model, serializerSettings);
                File.WriteAllText(Application.StartupPath + @"\\Skor\\Skor.json", json);
                
            }
            // Dosyayı oku model nesnesine yerleştir hafızaya al
            model = JsonConvert.DeserializeObject<SkorJSonModel>
                    (
                        File.ReadAllText(Application.StartupPath + "\\Skor\\Skor.json")
                    );
        }

        public void Ekle(string oyuncuIsmi, int skor)
        {
            // Skor tabelasını 4 ile sınırla, listenin üstünten silip alttan ekle.
            if( model.BillLists.Count >= 4 && model.BillLists[3].oyuncuAdi != null )
            {
                model.BillLists.RemoveAt(0);
            }
            
            model.BillLists.Add(new SkorJSonModel.Puanlama {
                oyuncuAdi   = oyuncuIsmi,
                oyuncuSkor  = skor,
                tarih       = DateTime.Now.ToString("MMMM dd, yyyy"), 
            });
            
            // Dosyaya yazma işlemleri ve json formatına çevirim.
            var serializerSettings              = new JsonSerializerSettings();
            serializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            var json                            = JsonConvert.SerializeObject(model, serializerSettings);
            File.WriteAllText(Application.StartupPath + @"\\Skor\\Skor.json", json);
        }
    }
}
