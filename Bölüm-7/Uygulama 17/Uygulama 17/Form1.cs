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

        int[] sayilar = { 1, 6, 8, 2, 4, 9, 7, 0, 3, 5 };  //arrayimiz
        int toplam = 0;  //toplama işleminin başlangıç değerini 0 aldık,
        int toplam2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox1.Items.Add(sayilar[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(int x in sayilar)
            {
                comboBox1.Items.Add(x);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 6, 8, 2, 4, 9, 7, 0, 3, 5 };
            Array.Sort(sayilar);  
            for (int i = 0; i < sayilar.Length; i++)
            {
                listBox2.Items.Add(sayilar[i]);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            foreach(int x in sayilar)
            {
                toplam = toplam + x;   //toplama işlemi yapar 0 dan başlattık değerimizi üstüne ekleyerek toplama yapar
            }
            label2.Text = "Sayılar Toplam: "+toplam.ToString(); //toplam sonucumuzu string halde label2 ye yazdırttık
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[] sayilar = { 1, 6, 8, 2, 4, 9, 7, 0, 3, 5 };
            Array.Sort(sayilar);
            foreach (int x in sayilar)
            {
                if(x %2 == 0) //2 ye bölümden kalan 0 sa yani çift sayılar
                {
                    listBox3.Items.Add(x);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach(int x in sayilar)
            {
                if(x % 2 == 0)
                {
                    toplam2 = toplam2 + x;
                }
            }
            MessageBox.Show("Çift Sayılar Toplam: " + toplam2);  //messageboxta çift sayılar toplamını gösterir
        }
    }
}
