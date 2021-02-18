﻿using System;
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

        void Yazdir()
        {
            textBox1.Text = "Berkay";
            textBox2.Text = "Dönmez";
            textBox3.Text = "Bandırma";
        }

        void Temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yazdir(); //Yazdir metodunu çağırdık
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temizle();
        }
    }
}
