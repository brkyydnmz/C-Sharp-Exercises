using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] sehir = new string[5];
        int sayac = 0;
        
        private void button1_Click(object sender, EventArgs e)
        {
            sehir[sayac] = textBox1.Text;  //her yazdığımızı eklediğimizde arraye bir eleman ekleyecek 1 1 artacak
            sayac++;
            label2.Text = "Arraydeki eleman sayısı: " + Convert.ToString(sayac);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 5; i++)  //5 elemanlı array için i yi sınırladık
            {
                listBox1.Items.Add(sehir[i]);
            }
        }
    }
}
