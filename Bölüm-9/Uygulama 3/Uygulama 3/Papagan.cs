using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_3
{
    class Papagan:Kuslar //Papagan class ı Kuslar calss ın dan miras aldı ve kusların özelliklerine fonksiyonlarına sahip oldu
    {
        public string renk;
        public string isim;
        public override string Sescikar()  // kuslardaki virtualli sescikar ı buraya getirirken override kullandık. //Override geçersiz kılar.Metoddan önce yaılır.
        {
            return "cik cik";  //return ile de papağanımızın ötüş sesinin cik cik olduğunu belirttik
        }
    }
}
