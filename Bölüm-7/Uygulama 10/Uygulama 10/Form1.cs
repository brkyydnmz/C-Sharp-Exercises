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
            int[] dizi = { 5, 48, 36, 12, 55, 3, 14, 96, 71, 9 };

            int enKucukSayı = dizi[0];

            for(int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] < enKucukSayı)
                {
                    enKucukSayı = dizi[i];
                }
            }
            label2.Text = enKucukSayı.ToString();
        }
    }
}
