using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(textBox1.Text);
            int sayi2 = Convert.ToInt32(textBox2.Text);
            char islem = Convert.ToChar(textBox3.Text);
            int sonuc;
            switch (islem)
            {
                case '+': sonuc = sayi1 + sayi2;
                    label1.Text = sonuc.ToString();
                    break;
                case '-':sonuc = sayi1 - sayi2;
                    label1.Text = sonuc.ToString();
                    break;
                case '*':sonuc = sayi1 * sayi2;
                    label1.Text = sonuc.ToString();
                    break;
                case '/':sonuc = sayi1 / sayi2;
                    label1.Text = sonuc.ToString();
                    break;
                default:label1.Text = "Hatalı İşlem Girişi";
                    break;
            }
        }
    }
}
