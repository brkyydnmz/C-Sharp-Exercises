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

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1,sayi2,sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text); //TextBox1 e girdiğimiz değeri integer a dönüştürdük.
            sayi2 = Convert.ToInt32(textBox2.Text);
            sonuc = sayi1 + sayi2;  //sayi1 ve sayi2 integer a döndüğü için burada bi dönüşüm yapmadık
            label1.Text = sonuc.ToString();  //yukardaki sayi1 ve 2 integer oldugu için (ilk satırda) label integer almadığından ToString() ile string e dönüştürdük
        }
    }
}
