using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] kitaplar = { "Fareler ve İnsanlar", "Beyaz Geceler", "Şeker Portakalı", "Yüzbaşının Kızı" };
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 0; i< kitaplar.Length; i++)
            {
                listBox1.Items.Add(kitaplar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(string k in kitaplar)  //foreach string türünde kitaplar dizisini dolaşacak k değerimiz ve yazdıracak
            {
                listBox2.Items.Add(k);
            }
        }
    }
}
