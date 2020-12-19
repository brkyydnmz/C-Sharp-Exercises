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

        private void button1_Click(object sender, EventArgs e)
        {
            double fiyat, tutar;
            fiyat = Convert.ToDouble(textBox1.Text);
            if (radioButton1.Checked == true)
            {
                tutar = fiyat + fiyat * 0.08;
                label1.Text = tutar.ToString();
            }
            if (radioButton2.Checked == true)
            {
                tutar = fiyat + fiyat * 0.18;
                label1.Text = tutar.ToString();
            }
        }
    }
}
