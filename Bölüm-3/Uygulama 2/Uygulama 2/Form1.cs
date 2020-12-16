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
            string ad, soyad, meslek;
            ad = "Berkay";
            soyad = "Dönmez";
            meslek = "Öğrenci";
            label1.Text = ad;
            label2.Text = soyad;
            label3.Text = meslek;
        }
    }
}
