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
            Kiiras kr = new Kiiras();

            utak.Add(new Ut("Utca1", 'E'));
            utak.Add(new Ut("Utca2", 'K'));
            utak.Add(new Ut("Utca3", 'D'));
            utak.Add(new Ut("Utca4", 'N'));

            Keresztezodes kereszt = new Keresztezodes(utak, kr);
            
            kereszt.AutoSpawn();
            kr.TeljesKiiras(kereszt.Utak, "Válasszon a Lámpa zölddé változtatásához");
            int v = -1;
            while(v != 0)
            {
                v = Menu();
                try
                {
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
                    kereszt.AutoSpawn();
                    kr.TeljesKiiras(kereszt.Utak, "Válasszon a Lámpa zölddé változtatásához");
                }
                catch (Exception e) {
                    kr.TeljesKiiras(kereszt.Utak, e.Message);
                    System.Threading.Thread.Sleep(4000);
                    kr.TeljesKiiras(kereszt.Utak, "Válasszon a Lámpa zölddé változtatásához");
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
