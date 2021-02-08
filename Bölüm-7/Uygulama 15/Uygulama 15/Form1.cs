using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] dizi = new int[2, 2];  //matrix dizi için [,] kullanırız
            dizi[0, 0] = 25;
            dizi[0, 1] = 36;
            dizi[1, 0] = 85;
            dizi[1, 1] = 74;

            label1.Text = dizi[1, 0].ToString(); //85 i verir
        }
    }
}
