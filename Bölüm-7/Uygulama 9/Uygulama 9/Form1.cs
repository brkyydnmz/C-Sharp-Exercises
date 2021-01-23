using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_9
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

            int enBuyukSayi = dizi[0]; //ilk indexten başlaması için 0 dan başlattık

            for(int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] > enBuyukSayi)  //48 5 ten büyük olunca dizinin i si 48 deki oldu mesela dizi[1] oldu sırayla büyük olanı bulana kadar dener  //48 den büyük olan var mı diye diziyi taradı ve buldu o en büyük oldu
                {
                    enBuyukSayi = dizi[i]; 
                }
            }
            label2.Text = enBuyukSayi.ToString();
        }
    }
}
