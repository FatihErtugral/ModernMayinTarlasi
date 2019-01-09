using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class SkorForm : MetroFramework.Forms.MetroForm
    {
        public SkorForm()
        {
            InitializeComponent();
        }

        AnaForm ownerPointer;
        private void SkorForm_Load(object sender, EventArgs e)
        {
            ownerPointer = (AnaForm)this.Owner;
            if(File.Exists(Application.StartupPath + "\\Skor\\Skor.json"))
            {
                var model = JsonConvert.DeserializeObject<SkorJSonModel>(
                File.ReadAllText(Application.StartupPath + "\\Skor\\Skor.json"));

                metroGrid1.DataSource = model.BillLists;
                //metroGrid1.Sort(metroGrid1.Columns[1], ListSortDirection.Descending);
             }
        }
    }
}
