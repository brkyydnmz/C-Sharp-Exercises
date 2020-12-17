using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sayi;
            sayi = textBox1.Text;
            if (sayi == "1234")  //sayi eşittir(==) 1234 "" içine alma sebebimiz string olmasından dolayı
            {
                label1.Text = "Hoşgeldiniz Doğru Şifre";
            }
            if (sayi != "1234"){  // sayi eşit değildir(!=) 1234 e "" içine alma sebebimiz string olmasından dolayı
                label1.Text = "Hatalı şifre";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox2.Text);
            if (sayi < 5) //sayi 5 dan küçüktür(<) demek
            {
                label6.Text = "Sayı 5 ten küçüktür";
            }
            if(sayi > 5)  //sayi 5 dan büyüktür (>) demek
            {
                label6.Text = "Sayı 5 ten büyüktür";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox3.Text);
            if(sayi>= -7)  //sayi büyük eşittir(>=) demek
            {
                label8.Text = "Sayı -7 ye eşit yada büyüktür";
            }
            if(sayi<= -7)//sayi küçük eşittir(<=) demek
            {
                label8.Text = "Sayı -7 ye eşit yada küçüktür";
            }
        }
    }
}
