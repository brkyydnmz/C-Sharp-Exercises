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
            if(textBox1.Text == "Berkay" && textBox2.Text == "Dönmez")
            {
                label1.Text = "Hoşgeldin " + textBox1.Text + " " + textBox2.Text;
            }
            else
            {
                label1.Text = "Hatalı kişi Güle Güle " + textBox1.Text + " " + textBox2.Text;
            }
        }
    }
}
