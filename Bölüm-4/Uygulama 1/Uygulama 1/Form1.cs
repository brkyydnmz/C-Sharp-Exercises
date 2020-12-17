using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,toplam;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            label1.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, fark;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            fark = sayi1 - sayi2;
            label2.Text = fark.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,carpim;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            carpim = sayi1 * sayi2;
            label3.Text = carpim.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2,bolum;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            bolum = sayi1 / sayi2;
            label4.Text = bolum.ToString();
        }

        int sayi3 = 5;
        private void button5_Click(object sender, EventArgs e)
        {
            sayi3++; //sayi3 değerini bir bir arttırır
            label5.Text = sayi3.ToString();
        }

        int sayi4 = 10;
        private void button6_Click(object sender, EventArgs e)
        {
            sayi4--; //sayi4 değerini bir bir azaltır
            label6.Text = sayi4.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            label7.Text = (sayi1 % 4).ToString();  //sayi1 in 4 e bölümünden kalanı göstermek içindir.
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int sayi1;
            sayi1 = Convert.ToInt32(textBox1.Text);
            label8.Text = (sayi1 % 3).ToString();  //sayi1 in 3 e bölümünden kalanı göstermek içindir.
        }
    }
}
