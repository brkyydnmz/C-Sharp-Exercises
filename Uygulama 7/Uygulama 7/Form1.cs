using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Bilgiler.Items.Add("Ad Soyad: " + textBox1.Text 
                + "  Tc No: " + maskedTextBox2.Text
                + "  Telefon: " + maskedTextBox1.Text
                + "  Yaş: " + textBox2.Text
                + "  Şehir: " + textBox3.Text
                + "  Bölüm: " + textBox4.Text
                + "  Doğum Tarihi: " + maskedTextBox3.Text
                + "  Cinsiyet: " + comboBox1.Text
                );

        }


    }
}
