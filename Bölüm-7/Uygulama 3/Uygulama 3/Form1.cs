using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] sayilar = new int[8]; //8 elemanlı integer döndüren bir array oluşturduk alt tarafa da elemanları yazacağız.
            sayilar[0] = 24;
            sayilar[1] = 04;
            sayilar[2] = 20;
            sayilar[3] = 12;
            sayilar[4] = 10;
            sayilar[5] = 16;
            sayilar[6] = 34;
            sayilar[7] = 76;
            label1.Text = sayilar[6].ToString();  //labeller integer döndürmediği için string hale döndürdük
        }
    }
}
