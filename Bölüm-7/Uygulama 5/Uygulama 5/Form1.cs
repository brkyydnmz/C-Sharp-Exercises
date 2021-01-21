using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double[] sayilar = new double[5];
            sayilar[0] = 1.85;
            sayilar[1] = 4.25;
            sayilar[2] = 5.33;
            sayilar[3] = 19.81;
            sayilar[4] = 22.83;
            for (int i = 0; i <= 4; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            } 
        }
    }
}
