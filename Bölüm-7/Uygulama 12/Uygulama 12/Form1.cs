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
            int[] sayilar = { 1, 5, 2, 6, 3, 0, 7, 9, 8, 4 };
            Array.Reverse(sayilar);  //Reverse ile arrayi tersten okuruz yani 4 ten başlar
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
                label1.Text = "Eleman Sayımız: " + sayilar.Length.ToString();
            }
        }
    }
}
