using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 20; i++)
            {
                if(i % 2 == 0)  //mod aldık sayı 2 ye bölümünden kalan 0 ise yazdırır
                {
                    listBox1.Items.Add(i);
                }
            }
        }
    }
}
