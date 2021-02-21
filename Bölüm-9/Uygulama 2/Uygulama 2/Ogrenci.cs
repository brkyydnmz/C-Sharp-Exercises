using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uygulama_2
{
    class Ogrenci
    {
        private string ad;
        private string soyad;
        private string kulup;

        public string ADI  //ADI isminde bir property oluşturduk   //Kapsülleme olayı property+get+set ile oluşur  //manual olarak bu şekilde direkt yazarak yaparız
            {
            get { return ad; }  // get döndüreceği değeri belirtir
            set { ad = value.ToLower();}  //set kısıtlamayı istenilen formatta sağlar  //.ToLowe tüm harfleri küçük yapar
            }

        public string SOYADI { get => soyad; set => soyad = value.ToUpper(); }  // yukarıdaki soyad ın üstüne gelip refactorings e tıklayıp encapsulate field a basarsak otomatik üstte yaptığımızın aynısını yapar  //ToUpper büyük harf yapar
        public string KULUBU { get => kulup; set => kulup = value; }
    }

    
}


