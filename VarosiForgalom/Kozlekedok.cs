using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace VarosiForgalom
{
    public abstract class Kozlekedok
    {
        public Ut TartozkodikUt {  get; set; }
        private int tartozkodasiIdo = 0;
        public int TartozkodasiIdo
        {
            get => tartozkodasiIdo;
            set
            {
                if (value > 5) TulHosszuTartozkodas();
                else tartozkodasiIdo = value;
            }
        }
        public abstract void TulHosszuTartozkodas();
    }

    public class Auto: Kozlekedok
    {
        public Auto(Ut u)
        {
            this.TartozkodikUt = u;
        }
        public override void TulHosszuTartozkodas()
        {
            if (TartozkodikUt.Lampa.Allithato == 0)
            {
                this.TartozkodikUt.Lampa.Allithato = 2;
                throw new TimeoutException($"Az autós megrongálta a {TartozkodikUt.Nev} Lámpáját, a következő váltásnál nem használható");
            }
        }
    }

    /*
    public class Gyalogos: Kozlekedok
    {
        public override void TulHosszuTartozkodas() { throw new NotImplementedException(); }
    }
    */
}
