using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mevsim = textBox1.Text;
            switch (mevsim)
            {
                case "ilkbahar":label1.Text = "Mart-Nisan-Mayıs";break;
                case "yaz":label1.Text = "Haziran-Temmuz-Ağustos";break;
                case "sonbahar":label1.Text = "Eylül-Ekim-Kasım";break;
                case "kış":label1.Text = "Aralık-Ocak-Şubat";break;
                default:label1.Text = "Hatalı Mevsim Girişi";break;
            }
        }
    }
}
