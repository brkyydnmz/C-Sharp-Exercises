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

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)  //integer i değerini 1 den başlattık i 10dan küçük yada eşit olana kadar devam edicek dedik i yi 1 1 arttırdık
            {
                listBox1.Items.Add(i); 
            }
        }
    }
}
