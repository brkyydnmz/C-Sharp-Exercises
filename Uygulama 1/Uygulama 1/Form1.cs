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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Berkay";
            label2.Text = "Dönmez";
            label3.Text = "Bandırma";
            textBox1.Text = "Buttona tıklayınca geldi bu yazı!";
            label1.Text = textBox1.Text;  //buton a tıklayınca TextBox a girilen veri label1 e yazdırıldı.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Hello World!";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Üstüme tıklarsan bu yazı çıkar";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
