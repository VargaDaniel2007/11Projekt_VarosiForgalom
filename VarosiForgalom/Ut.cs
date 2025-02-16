using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiForgalom
{
    public class Ut
    {
        public string Nev { get; set; }
        public char UtIrany { get; set; }
        public char TavozoIrany { get; set; }
        public Lampa Lampa { get; set; }
        public List<Auto> AutokUton { get; set; } = new List<Auto>();
        public List<Auto> AutokTavoz { get; set; } = new List<Auto>();
        public int AutoSzam { get {  return AutokUton.Count; } }
        public int AutoSzamTavoz { get { return AutokTavoz.Count; } }

        /*
        public List<Gyalogos> GyalogosUton { get; set; } = new List<Gyalogos>();
        public int GyalogosSzam { get { return GyalogosUton.Count; } }
        */

        public int[] KiirasHelye { get; set; }
        public int[] LampaHelye {  get; set; }      //Mindenkinek Console szerint nézve bal felső sarok
        public int[] AutokHelye { get; set; }
        public int[] TavozoAutokHelye { get; set; }
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
                    this.LampaHelye = [82, 13];
                    this.AutokHelye = [93, 19];
                    this.TavozoAutokHelye = [104, 2];
                    this.TavozoIrany = 'D';
                    this.AutoHossz = 3;
                    break;
                case 'K':
                    this.KiirasHelye = [198, 25];
                    this.LampaHelye = [117, 16];
                    this.AutokHelye = [111, 22];
                    this.TavozoAutokHelye = [198, 26];
                    this.TavozoIrany = 'N';
                    this.AutoHossz = -7;
                    break;
                case 'D':
                    this.KiirasHelye = [100, 49];
                    this.LampaHelye = [113, 32];
                    this.AutokHelye = [104, 31];
                    this.TavozoAutokHelye = [93, 48];
                    this.TavozoIrany = 'E';
                    this.AutoHossz = -3;
                    break;
                case 'N':
                    this.KiirasHelye = [1, 25];
                    this.LampaHelye = [75, 32];
                    this.AutokHelye = [90, 26];
                    this.TavozoAutokHelye = [1, 22];
                    this.TavozoIrany = 'K';
                    this.AutoHossz = 7;
                    break;

            }
        }
    }
}
