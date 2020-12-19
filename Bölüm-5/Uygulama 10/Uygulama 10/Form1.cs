using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "Apple")
            {
                label1.Text = "Elma";
            }
            if (comboBox1.Text == "Melon")
            {
                label1.Text = "Kavun";
            }
            if (comboBox1.Text == "Orange")
            {
                label1.Text = "Turuncu";
            }
            if (comboBox1.Text == "Banana")
            {
                label1.Text = "Muz";
            }
            if (comboBox1.Text == "Peach")
            {
                label1.Text = "Şeftali";
            }
        }
    }
}
