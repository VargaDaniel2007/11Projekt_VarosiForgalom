using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiForgalom
{
    public class Keresztezodes
    {
        Random rand = new Random();

        public List<Ut> Utak { get; set; } = new List<Ut>();    //Észak->Kelet->Dél->Nyugat

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
                int szam = rand.Next(0, 4);
                if (szam > 0)
                {
                    for( int i = 0; i < szam; i++)
                    {
                        ut.AutokUton.Add(new Auto());
                    }
                }
            }
        }

        public void IrasPlaceholder()
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            Console.Write("0..Kilépés\t\t1..Autó randomizálás");

            Console.SetCursorPosition(95, 2);
            Console.WriteLine("Utca1");
            Console.SetCursorPosition(95, 3);
            Console.WriteLine($"{Utak[0].AutoSzam} autó");

            Console.SetCursorPosition(190, 25);
            Console.WriteLine("Utca2");
            Console.SetCursorPosition(190, 26);
            Console.WriteLine($"{Utak[1].AutoSzam} autó");

            Console.SetCursorPosition(95, 47);
            Console.WriteLine("Utca3");
            Console.SetCursorPosition(95, 48);
            Console.WriteLine($"{Utak[2].AutoSzam} autó");

            Console.SetCursorPosition(2, 25);
            Console.WriteLine("Utca4");
            Console.SetCursorPosition(2, 26);
            Console.WriteLine($"{Utak[3].AutoSzam} autó");
        }
    }
}
