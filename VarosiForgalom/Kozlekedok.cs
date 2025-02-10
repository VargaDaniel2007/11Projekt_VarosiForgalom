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
        private int tartozkodasiIdo = 0;
        public int TartozkodasiIdo
        {
            get => tartozkodasiIdo;
            set
            {
                if (tartozkodasiIdo + value > 4) TulHosszuTartozkodas();
                else tartozkodasiIdo += value;
            }
        }
        public abstract void TulHosszuTartozkodas();
    }

    public class Auto: Kozlekedok
    {
        public override void TulHosszuTartozkodas() { throw new NotImplementedException(); }
    }
    public class Gyalogos: Kozlekedok
    {
        public override void TulHosszuTartozkodas() { throw new NotImplementedException(); }
    }
}
