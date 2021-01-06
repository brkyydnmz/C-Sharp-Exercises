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
            int faktoriyel = 1;  //0 dan başlatırsak sonuç hep 0 olur
            for(int i = 1; i <= 5; i++)
            {
                faktoriyel *= i;
            }
            label1.Text = "Sonuç " + faktoriyel.ToString();
        }
    }
}
