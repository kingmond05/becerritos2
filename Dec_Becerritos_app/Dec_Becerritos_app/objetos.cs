using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dec_Becerritos_app
{
    public class objetos
    {
        public string id { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string descripcion { get; set; }
        public resultado result { get; set; }
        public string source { get; set; }
        public string link { get; set; }
    }

    public class resultado
    {
        public List<array> fArray { get; set; }
        public int fRows { get; set; }
        public int fCols { get; set; }
        public string fType { get; set; }
        public int fTimestamp { get; set; }
    }

    public class array
    {
        public string fStr { get; set; }
        public string fType { get; set; }
    }

}