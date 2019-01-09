using System;
using System.Collections.Generic;

namespace WindowsFormsApp
{
    public class SkorJSonModel
    {
        public struct Puanlama
        {
            public string   oyuncuAdi   { get; set; }
            public int      oyuncuSkor  { get; set; }
            public string   tarih       { get; set; }
        };
        public string Version { get; set; }
        public IList<Puanlama> BillLists { get; set; } = new List<Puanlama>();
    }
}
