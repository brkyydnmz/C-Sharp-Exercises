using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] firmalar = new string[5];
            firmalar[0] = "Apple";
            firmalar[1] = "Microsoft";
            firmalar[2] = "Amazon";
            firmalar[3] = "IBM";
            firmalar[4] = "Google";
            for(int i = 0; i <= 4; i++)
            {
                listBox1.Items.Add(firmalar[i]);
            }
        }
    }
}
