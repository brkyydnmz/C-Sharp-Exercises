using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if(sayi>10 && sayi % 2 == 0)  // && VE ANLAMINA GELİR
            {
                label1.Text = "Doğru";
            }
            else
            {
                label1.Text = "Yanlış";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi=Convert.ToInt32(textBox2.Text);
            if(sayi>12 || sayi % 2 == 1)  //   || veya operatörüdür
            {
                label6.Text = "Doğru";
            }
            else
            {
                label6.Text = "Yanlış";
            }
        }

        int sayi1;
        
        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt32(textBox3.Text);
            sayi1 += 4;  // += atama yapar burda 4 ekledi   //tüm aritmatik işlemler ( +,-,*,/) için gecerli
            label9.Text = sayi1.ToString();
        }
    }
}
