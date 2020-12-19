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
            int sayi = Convert.ToInt32(textBox1.Text);
            
            switch (sayi)
            {
                case 1: label1.Text = "Ocak";break;  //break ile case durdurulur  //1 dememizin sebebi integer olması 1 dediğimizde ocak gelir bu yüzden
                case 2: label1.Text = "Şubat";break;
                case 3: label1.Text = "Mart";break;
                case 4: label1.Text = "Nisan";break;
                case 5: label1.Text = "Mayıs";break;
                case 6:label1.Text = "Haziran";break;
                case 7:label1.Text = "Temmuz";break;
                case 8:label1.Text = "Ağustos";break;
                case 9:label1.Text = "Eylül";break;
                case 10: label1.Text = "Ekim"; break;
                case 11:label1.Text = "Kasım";break;
                case 12:label1.Text = "Aralık";break;
                default: label1.Text = "Hatalı Giriş"; break;  //default caselerin olmadığı durumlar için kullanılır.
            }
        }
    }
}
