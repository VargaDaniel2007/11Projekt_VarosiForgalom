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
        public Kiiras Kiiras { get; } = new Kiiras();

        public Keresztezodes(List<Ut> utak)
        {
            this.Utak = utak;
        }

        public void AutoSpawn()
        {
            foreach (Ut ut in Utak)
            {
                foreach(Auto auto in ut.AutokUton)
                {
                    auto.TartozkodasiIdo += 1;
                }
                int szam = rand.Next(0, 2);
                if (szam > 0)
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
            //IrasPlaceholder("Lámpa átváltva");
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
            //IrasPlaceholder("Autósok áthaladnak");
            System.Threading.Thread.Sleep(3000);
        }

        /*
        public void IrasPlaceholder(string helyzet)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"0..Kilépés \t{helyzet}");
            Console.SetCursorPosition(0, Console.WindowHeight - this.Utak.Count - 2);
            Console.WriteLine("Lámpák gombjai:");
            for(int i = 0; i < this.Utak.Count; i++)
            {
                if (Utak[i].Lampa.Allithato != 2)
                    Console.WriteLine($"{i+1}.. {Utak[i].Nev}");
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i + 1}.. {Utak[i].Nev}");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;

            foreach (Ut ut in this.Utak)
            {
                Console.SetCursorPosition(ut.KiirasHelye[0], ut.KiirasHelye[1]);

                if (ut.Lampa.HaladasEngedely) Console.ForegroundColor = ConsoleColor.Green;
                else Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine(ut.Nev);
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(ut.KiirasHelye[0], ut.KiirasHelye[1] + 1);
                Console.WriteLine($"{ut.AutoSzam} autó {ut.kiirasIkon}");
                Console.SetCursorPosition(ut.KiirasHelye[0], ut.KiirasHelye[1] + 2);
                Console.WriteLine($"{ut.AutoSzamTavoz} autó {ut.kiirasIkonEllen}");
            }
        }
    
        */
    }
}
