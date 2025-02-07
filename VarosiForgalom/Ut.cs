using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiForgalom
{
    public class Ut
    {
        public string Nev { get; set; }
        public Lampa Lampa { get; set; }
        public List<Auto> autokUton { get; set; } = new List<Auto>();
        public List<Gyalogos> gyalogosUton { get; set; } = new List<Gyalogos>();

        public Ut(string nev)
        {
            this.Nev = nev;
            this.Lampa = new Lampa();
        }
    }
}
