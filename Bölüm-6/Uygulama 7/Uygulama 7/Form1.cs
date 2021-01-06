using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bakteri = 1;
            for(int i = 1; i <= 24; i++)
            {
                bakteri *= 2;
            }
            label1.Text = "Sonuç " + bakteri.ToString();
        }
    }
}
