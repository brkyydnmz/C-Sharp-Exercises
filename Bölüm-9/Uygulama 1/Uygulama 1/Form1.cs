using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ev evsınıf = new Ev();  //ev.cs deki Ev classını kullanmak için bunu yazdık newledik   //evsınıf ta nesne adımızdır (nesne ürettik class ı kullanıp)
            evsınıf.renk = "Mavi";
            evsınıf.kat = "5";
            evsınıf.yakıt = 'D';
            evsınıf.fiyat = 780000;

            label1.Text = "Renk: " + evsınıf.renk;
            label2.Text = "Kat: " + evsınıf.kat;
            label3.Text = "Yakıt Türü: " + evsınıf.yakıt.ToString();
            label4.Text = "Fiyat: " + evsınıf.fiyat.ToString();

        }
    }
}
