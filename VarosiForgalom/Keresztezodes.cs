using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace VarosiForgalom
{
    public class Keresztezodes
    {
        Random rand = new Random();

        public List<Ut> Utak { get; set; } = new List<Ut>();    //Észak->Kelet->Dél->Nyugat
        public Kiiras Kiiras { get; }

        public Keresztezodes(List<Ut> utak, Kiiras kiiras)
        {
            this.Utak = utak;
            this.Kiiras = kiiras;
        }

        public void AutoSpawn()
        {
            foreach (Ut ut in Utak)
            {
                foreach(Auto auto in ut.AutokUton)
                {
                    auto.TartozkodasiIdo = auto.TartozkodasiIdo + 1;
                }
                int szam = rand.Next(0, 2);
                if (szam > 0 && ( ((ut.UtIrany == 'E' || ut.UtIrany == 'D') && ut.AutoSzam < 6) || ((ut.UtIrany == 'N' || ut.UtIrany =='K') && ut.AutoSzam < 12) ) )
                {
                    for( int i = 0; i < szam; i++)
                    {
                        ut.AutokUton.Add(new Auto(ut));
                    }
                }
            }
        }

        public void Haladas(int utIndex)
        {
            Ut ut = Utak[utIndex];

            if (ut.Lampa.Allithato == 2) throw new Exception("A Lámpa nem állítható");

            foreach(Ut u in this.Utak)
            {
                u.AutokTavoz.Clear();
                if(u.Lampa.Allithato == 2)
                {
                    u.Lampa.Allithato = 1;
                }
                else if(u.Lampa.Allithato == 1)
                {
                    u.Lampa.Allithato = 0;
                }
            }

            Ut athaladUt = Utak[(utIndex + Utak.Count/2) % Utak.Count];
            ut.Lampa.HaladasEngedely = true;
            Kiiras.TeljesKiiras(this.Utak, "Lámpa átváltva");
            System.Threading.Thread.Sleep(3000);
            int autoHalad = rand.Next(1, 5);
            if (ut.AutoSzam > autoHalad)
            {
                for(int i = 0; i < autoHalad; i++)
                {
                    athaladUt.AutokTavoz.Add(ut.AutokUton[i]);
                    ut.AutokUton.RemoveAt(i);
                }
            }
            else    //Kevesebb mint a randomolt érték mind átmegy
            {
                autoHalad = ut.AutoSzam;
                for (int i = 0; i < autoHalad; i++)
                {
                    athaladUt.AutokTavoz.Add(ut.AutokUton[0]);
                    ut.AutokUton.RemoveAt(0);
                }
            }
            ut.Lampa.HaladasEngedely = false;
            Kiiras.TeljesKiiras(this.Utak, "Autósok áthaladnak");
            System.Threading.Thread.Sleep(3000);
        }

    }
}
