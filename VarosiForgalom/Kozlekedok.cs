using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosiForgalom
{
    public class Kozlekedok
    {
        public Ut tartozkodikUt { get; set; }
        public int tartozkodasiIdo { get; set; } = 0;
        public virtual void TulHosszuTartozkodas() { }
    }

    public class Auto: Kozlekedok
    {
        
    }
    public class Gyalogos: Kozlekedok
    {

    }
}
