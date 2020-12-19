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
            int sinav1, sinav2, ortalama;
            sinav1 = Convert.ToInt32(textBox1.Text);
            sinav2 = Convert.ToInt32(textBox2.Text);
            ortalama = (sinav1 + sinav2) / 2;
            label1.Text = ortalama.ToString();
            if(ortalama>0 && ortalama <= 40)
            {
                label2.Text = "Kötü";
            }
            if(ortalama>40 && ortalama<= 60)
            {
                label2.Text = "Orta";
            }
            if(ortalama>60 && ortalama <= 75)
            {
                label2.Text = "İyi";
            }
            if (ortalama > 75)
            {
                label2.Text = "Çok iyi";
            }
        }
    }
}
