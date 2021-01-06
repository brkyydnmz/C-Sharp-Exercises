using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayac = 6;
            while (sayac <= 5)   //SAYAÇ 6 DAN BAŞLADIGI İÇİN BİZ ŞARTIMIZI 5 VE 5 TEN KÜÇÜK OLURKEN DEDİĞİMİZ İÇİN Bİ İŞLEM YAPMAZ
            {
                listBox1.Items.Add("Merhaba");
                sayac++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = 6;
            do
            {
                listBox2.Items.Add("Merhaba");
                sayac++;
            } while (sayac <= 5); //while döngü koşulları sağlanmasa bile do-while ile bir kere dener ve bize sonucu verir
        }
    }
}
