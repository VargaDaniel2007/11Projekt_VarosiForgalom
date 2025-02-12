using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiForgalom
{
    public class Kiiras
    {
        public void TeljesKiiras(List<Ut> utak)
        {
            KeresztRajz();
            UtcaNevek(utak);
        }

        public void KeresztRajz()
        {
            //Console.WriteLine("═════");
            //Console.WriteLine("█████ ║");

            for (int i = 0; i < 20; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.Write("█         ║         █"); //21
            }
            Console.SetCursorPosition(0, 20);
            for (int j = 0; j <= 90; j++)
            {
                Console.Write("█");
            }
            Console.SetCursorPosition(110, 20);
            for (int j = 0; j < 90; j++)
            {
                Console.Write("█");
            }

            Console.SetCursorPosition(0, 25);
            for (int j = 0; j <= 90; j++)
            {
                Console.Write("═");
            }
            Console.SetCursorPosition(110, 25);
            for (int j = 0; j < 90; j++)
            {
                Console.Write("═");
            }

            Console.SetCursorPosition(0, 30);
            for (int j = 0; j <= 90; j++)
            {
                Console.Write("█");
            }
            Console.SetCursorPosition(110, 30);
            for (int j = 0; j < 90; j++)
            {
                Console.Write("█");
            }

            for (int i = 31; i < 50; i++)
            {
                Console.SetCursorPosition(90, i);
                Console.Write("█         ║         █"); //21
            }
        }

        public void UtcaNevek(List<Ut> utak)
        {
            foreach(Ut u in utak)
            {
                int hossz = u.Nev.Length;
                if(u.UtIrany == 'E' || u.UtIrany == 'D')
                {
                    Console.SetCursorPosition(u.KiirasHelye[0] - hossz / 2, u.KiirasHelye[1]);
                    Console.Write(u.Nev);
                }
                else if(u.UtIrany == 'K')
                {
                    Console.SetCursorPosition(u.KiirasHelye[0] - hossz, u.KiirasHelye[1]);
                    Console.Write(u.Nev);
                }
                else
                {
                    Console.SetCursorPosition(u.KiirasHelye[0], u.KiirasHelye[1]);
                    Console.Write(u.Nev);
                }
            }
        }

        public void Auto(char irany, int[] koordinata, ConsoleColor szin)
        {
            int x = koordinata[0];
            int y = koordinata[1];
            ConsoleColor regiszin = Console.ForegroundColor;
            Console.ForegroundColor = szin;
            switch (irany)
            {
                case 'E':
                    //X,Y Bal alul
                    Console.SetCursorPosition(x, y - 2);
                    Console.Write("|¯¯|");
                    Console.SetCursorPosition(x, y - 1);
                    Console.Write("|__|");
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ▼▼ ");
                    /*
                        |¯¯|
                        |__|
                         ▼▼ 
                     */
                    break;

                case 'K':
                    //X,Y bal fent
                    Console.SetCursorPosition(x, y);
                    Console.Write("  ____ ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("◄|____|");
                    //Console.SetCursorPosition(x, y + 2);
                    //Console.Write("  ¯¯¯¯ ");
                    /*
                     *  ____ 
                     *◄|    |
                        ¯¯¯¯  
                     * 
                     */

                    
                    break;

                case 'D':
                    //X,y Bal fent
                    Console.SetCursorPosition(x, y);
                    Console.Write(" ▲▲ ");
                    Console.SetCursorPosition(x, y + 1);
                    Console.Write("|¯¯|");
                    Console.SetCursorPosition(x, y + 2);
                    Console.Write("|__|");

                    /*
                     ▲▲ 
                    |¯¯|
                    |__|
                     */
                    break;

                case 'N':
                    //X, Y Jobb Fent
                    Console.SetCursorPosition(x - 7, y);
                    Console.Write(" ____  ");
                    Console.SetCursorPosition(x - 7, y + 1);
                    Console.Write("|____|►");
                    /*  ____  
                     * |    |►
                        ¯¯¯¯  
                     */
                    break;
            }

            Console.ForegroundColor = regiszin;
        }
    }
}
