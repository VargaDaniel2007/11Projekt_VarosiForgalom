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
        public List<Auto> AutokTavoz { get; set; } = new List<Auto>();
        public int AutoSzam { get {  return AutokUton.Count; } }
        public int AutoSzamTavoz { get { return AutokTavoz.Count; } }
        public List<Gyalogos> GyalogosUton { get; set; } = new List<Gyalogos>();
        public int GyalogosSzam { get { return GyalogosUton.Count; } }

        public int[] kiirasHelye { get; set; }
        public string kiirasIkon {  get; set; }
        public string kiirasIkonEllen {  get; set; }

        public Ut(string nev, int[] koordinata, string kiirasIkon, string kiirasIkonEllen)
        {
            this.Nev = nev;
            this.kiirasHelye = koordinata;
            this.Lampa = new Lampa();
            this.kiirasIkon = kiirasIkon;
            this.kiirasIkonEllen = kiirasIkonEllen;
        }
    }
}
