using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte sayi = 255; //0-255 arası değer gelir
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sbyte sayi = -14;  //  -128 ile 127 arası sayı alır
            label2.Text = sayi.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            short sayi1 = 1440;  //short -32768 ile 32767 arası tam değer alır
            short sayi2 = 2562;
            label3.Text = (sayi1 + sayi2).ToString(); //toplamayı bir değişkende yapamayız Byte ve Sbyte da da bu durum vardır   // toplam = sayi1 + sayi2; BU YAPILAMAZ 

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ushort sayi = 54627;  //ushort 0 ile 65535 arası tam değerleri alır
            label4.Text = sayi.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            float sayi = 24.09f; //Floatlarda sayı sonuna f konur //float ın ondalık hassasiyeti 7 basamaklıdır
            label5.Text = sayi.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            decimal sayi = 19.1923m;  //Decimal sayı sonuna m konur //decimal in ondalık hassasiyeti 29 basamaklıdır // bellekte en çok yer kaplayan budur
            label6.Text = sayi.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool durum = false;   //true false döner Boolean
            label7.Text = durum.ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
