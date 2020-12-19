using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sicaklik;
            sicaklik = Convert.ToInt32(textBox1.Text);
            if (sicaklik <= 0)
            {
                label1.Text = "Katı";
            }if(sicaklik>0 && sicaklik < 100)
            {
                label1.Text = "Sıvı";
            }
            if (sicaklik >= 100)
            {
                label1.Text = "Gaz";
            }
            
        }
    }
}
