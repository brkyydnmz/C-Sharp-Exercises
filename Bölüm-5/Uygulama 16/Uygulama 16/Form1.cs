using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            switch (plaka)
            {
                case 1: label1.Text = "Adana";break;
                case 10: label1.Text = "Balıkesir";break;
                case 16:label1.Text = "Bursa";break;
                case 34:label1.Text = "İstanbul";break;
                case 35: label1.Text = "İzmir";break;
                default:label1.Text = "Henüz Bu Şehir Mevcut Değildir.";break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
