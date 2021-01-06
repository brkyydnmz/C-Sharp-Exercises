using System;
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
            string metin;
            metin = textBox1.Text;
            int sayac = 1;
            while (sayac <= 10)
            { 
                listBox1.Items.Add(metin);
                sayac++;  //bunu belirtmezsek döngü sonsuza kadar devam eder
            }
        }
    }
}
