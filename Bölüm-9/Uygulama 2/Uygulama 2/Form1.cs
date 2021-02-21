using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci ogr = new Ogrenci();  //ogr nesnsini ürettik class ı newleyerek
            ogr.ADI = textBox1.Text;
            ogr.SOYADI = textBox2.Text;
            ogr.KULUBU = textBox3.Text;  //değişkenlerimizi private yaptığımız için değişkenlere değil de property kısmındaki adlara ulaşabiliriz ve o adları kullandık(ADI,SOYADI..)

            Notlar ntl = new Notlar();  //Notlar class ı nı newleyerek ntl adında nesne oluşturduk
            ntl.sinav1 = Convert.ToInt32(textBox4.Text);
            ntl.sinav2 = Convert.ToInt32(textBox5.Text);
            ntl.sinav3 = Convert.ToInt32(textBox6.Text);
            ntl.Ortalama = (ntl.sinav1 + ntl.sinav2 + ntl.sinav3) / 3;
            textBox7.Text = ntl.Ortalama.ToString();

            listBox1.Items.Add(ogr.ADI + " " + ogr.SOYADI + " " + ogr.KULUBU + " Ortalama: " + ntl.Ortalama);
        }
    }
}
