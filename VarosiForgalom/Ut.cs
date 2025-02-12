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
        public char UtIrany { get; set; }
        public Lampa Lampa { get; set; }
        public List<Auto> AutokUton { get; set; } = new List<Auto>();
        public List<Auto> AutokTavoz { get; set; } = new List<Auto>();
        public int AutoSzam { get {  return AutokUton.Count; } }
        public int AutoSzamTavoz { get { return AutokTavoz.Count; } }
        public List<Gyalogos> GyalogosUton { get; set; } = new List<Gyalogos>();
        public int GyalogosSzam { get { return GyalogosUton.Count; } }

        public int[] KiirasHelye { get; set; }
        public int[] AutokHelye { get; set; }
        public int AutoHossz {  get; set; }

        public Ut(string nev, char irany)
        {
            this.Nev = nev;
            this.UtIrany = irany;
            this.Lampa = new Lampa();

            switch (irany)
            {
                case 'E':
                    this.KiirasHelye = [100, 1];
                    this.AutokHelye = [93, 19];
                    this.AutoHossz = 3;
                    break;
                case 'K':
                    this.KiirasHelye = [198, 25];
                    this.AutokHelye = [111, 22];
                    this.AutoHossz = 7;
                    break;
                case 'D':
                    this.KiirasHelye = [100, 49];
                    this.AutokHelye = [103, 31];
                    this.AutoHossz = 3;
                    break;
                case 'N':
                    this.KiirasHelye = [1, 25];
                    this.AutokHelye = [90, 26];
                    this.AutoHossz = 7;
                    break;

            }
        }
    }
}
