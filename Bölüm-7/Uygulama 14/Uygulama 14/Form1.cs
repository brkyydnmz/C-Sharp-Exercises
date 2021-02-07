using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] sayilar = {874,232,823211,213,1,2,5,7,3,8,4,53,23,645,6754,23,34,9789,976432,232,563};
        private void button1_Click(object sender, EventArgs e)
        {
            
                for (int i = 0; i < sayilar.Length; i++)
                {
                    listBox1.Items.Add(sayilar[i]);
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = sayilar.Max().ToString(); //sayıların en büyüğünü getirir
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = sayilar.Min().ToString(); //sayıların en küçüğünü getirir
        }
    }
}
