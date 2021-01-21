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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] renkler = new string[5];  //5 elemanlı string olan bir dizi oluşturduk
            renkler[0] = "Sarı";
            renkler[1] = "Mavi";
            renkler[2] = "Beyaz";
            renkler[3] = "Turuncu";
            renkler[4] = "Kırmızı";

            label1.Text = renkler[2];
        }
    }
}
