using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;  //0 değerini vermezsek değer normalde null olur ve aritmatik işlem yapamayız hata alırız
            for(int i = 1; i <= 10; i++)
            {
                toplam = toplam + i;
            }
            label1.Text = "Toplam " + toplam.ToString();
        }
    }
}
