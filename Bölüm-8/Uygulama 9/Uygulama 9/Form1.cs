﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int Hesapla(int sayi)  // heryerde kullanılabilir metod publictir //sayi değerini nerde alacağını altta belirttik
        {
            int sonuc = sayi * sayi;
            return sonuc;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Hesapla(Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}
