using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)  //radiobutton true false döndürür
            {
                label1.Text = "Erkek";
            }
            if (radioButton2.Checked == true)
            {
                label1.Text = "Kadın";
            }
        }
    }
}
