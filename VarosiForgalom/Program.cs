using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace VarosiForgalom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WindowWidth = 200;  //Oszlop
            Console.WindowHeight = 50;  //Sor
            Console.CursorVisible = false;

            List<Ut> utak = new List<Ut>();

            utak.Add(new Ut("Utca1", [95, 2], "V", "T"));
            utak.Add(new Ut("Utca2", [190, 25], "<-", "->"));
            utak.Add(new Ut("Utca3", [95, 46], "T", "V"));
            utak.Add(new Ut("Utca4", [2, 25], "->", "<-"));

            Keresztezodes kereszt = new Keresztezodes(utak);

            //kereszt.IrasPlaceholder();
            //Console.ReadKey(true);
            int v = -1;
            while(v != 0)
            {
                kereszt.AutoSpawn();
                kereszt.IrasPlaceholder("Válasszon a Lámpa zölddé változtatása");
                v = Menu();
                switch (v)
                {
                    case 1:
                        kereszt.Haladas(v - 1);
                        break;
                    case 2:
                        kereszt.Haladas(v - 1);
                        break;
                    case 3:
                        kereszt.Haladas(v - 1);
                        break;
                    case 4:
                        kereszt.Haladas(v - 1);
                        break;
                }
            }

        }

        static int Menu()
        {
            char v;
            do
            {
                v = Console.ReadKey(true).KeyChar;

            }while (v < '0' || v > '4');
            return v - '0';

        }
    }
}
