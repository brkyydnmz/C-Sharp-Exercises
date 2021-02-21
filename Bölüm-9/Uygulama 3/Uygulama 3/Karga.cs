using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_3
{
    class Karga:Kuslar //kuslardan mirasladık
    {
        public string renk;
        public int hiz;

        public override string Sescikar()
        {
            return "gak gak";  //karganın sesini belirttik
        }
    }
}
