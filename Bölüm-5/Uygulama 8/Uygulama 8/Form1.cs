﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char takim;  //char tek tırnak ile belirtilir
            takim = Convert.ToChar(textBox1.Text);
            if(takim== 'g'|| takim == 'G')
            {
                label1.Text = "Galatasaray";
            }
            if (takim == 'f' || takim == 'F')
            {
                label1.Text = "Fenerbahçe";
            }
            if (takim == 'b' || takim == 'B')
            {
                label1.Text = "Beşiktaş";
            }
            else {
                label1.Text = "Hatalı";
            }
        }
    }
}
