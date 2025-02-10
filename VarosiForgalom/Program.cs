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

            List<Ut> utak = new List<Ut>();

            for(int i = 1; i <= 4; i++)
            {
                utak.Add(new Ut($"Utca{i}"));
            }
            Keresztezodes kereszt = new Keresztezodes(utak);

            kereszt.IrasPlaceholder();
            Console.ReadKey(true);
            int v = 1;
            while(v != 0)
            {
                kereszt.AutoSpawn();
                kereszt.IrasPlaceholder();
                v = Kilepes();
            }

        }

        static int Kilepes()
        {
            char v;
            do
            {
                v = Console.ReadKey(true).KeyChar;

            }while (v < '0' || v > '1');
            return v - '0';

        }
    }
}
