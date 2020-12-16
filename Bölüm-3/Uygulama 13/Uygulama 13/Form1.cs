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
            char harf;   //Char tek bir harf alır
            harf = Convert.ToChar(textBox1.Text);  
            label1.Text = harf.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char harf;
            harf = 'D';  //Stringten farkı Char da tek tırnak kullanılır
            label2.Text = harf.ToString();
        }
    }
}
