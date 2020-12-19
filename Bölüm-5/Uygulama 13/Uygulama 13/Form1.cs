using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked == true)
            {
                sonuc = sayi1 + sayi2;
                label1.Text = sonuc.ToString();
            }
            if (radioButton2.Checked == true)
            {
                sonuc = sayi1 - sayi2;
                label1.Text = sonuc.ToString();
            }
            if (radioButton3.Checked == true)
            {
                sonuc = sayi1 * sayi2;
                label1.Text = sonuc.ToString();
            }
            if (radioButton4.Checked == true)
            {
                sonuc = sayi1 / sayi2;
                label1.Text = sonuc.ToString();
            }
        }
    }
}
