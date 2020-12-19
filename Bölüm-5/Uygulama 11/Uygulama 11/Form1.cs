using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked== true)  //checkbox true false (boolen) döndürür
            {
                label1.Text = "Aktif";
            }
            else
            {
                label1.Text = "Çevirimdışı";
            }
        }
    }
}
