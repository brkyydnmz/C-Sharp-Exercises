using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = Convert.ToDouble(textBox1.Text);
            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sayi;
            sayi = 24.03;    //Kodlarken double ı nokta ile gösterilririz formda(uygulamada) virgül ile yazarız
            label2.Text = sayi.ToString();
        }
    }
}
