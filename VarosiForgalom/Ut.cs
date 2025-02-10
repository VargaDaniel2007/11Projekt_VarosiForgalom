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
        public List<Auto> AutokUton { get; set; } = new List<Auto>();
        public int AutoSzam { get {  return AutokUton.Count; } }
        public List<Gyalogos> GyalogosUton { get; set; } = new List<Gyalogos>();
        public int GyalogosSzam { get { return GyalogosUton.Count; } }

        public Ut(string nev)
        {
            this.Nev = nev;
            this.Lampa = new Lampa();
        }
    }
}
