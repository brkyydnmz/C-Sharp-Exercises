using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Toplam(int sayi1,int sayi2)   //void dışında tüm metodlar (int gibi) geriye değer döndüren metoddur.
        {
            int sonuc = sayi1 + sayi2;
            return sonuc; //Geriye Değer Döndüren Metodlarda return eklememiz gerekmektedir.   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text=Toplam(18, 81).ToString();
        }
    }
}
