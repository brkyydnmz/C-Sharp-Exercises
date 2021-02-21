using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_3
{
    class Kuslar
    {
        public string tur;
        public int ayak;
        public virtual string Sescikar() //virtaul kalıtım alınan sınıfta içerik değiştirmek için kullanılır. Zorunludur 
        {
            return "buraya ses yazılacak";
        }
    }
}
