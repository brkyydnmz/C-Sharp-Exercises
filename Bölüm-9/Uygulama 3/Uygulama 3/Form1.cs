using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Papagan ppg = new Papagan();  //nesne yaptık
            ppg.tur = textBox1.Text;
            ppg.ayak = Convert.ToInt32(textBox2.Text);
            
            ppg.renk = textBox4.Text;
            ppg.isim = textBox5.Text;
            listBox1.Items.Add(ppg.tur + " " + ppg.ayak + " " + ppg.Sescikar() + " "+ppg.renk+" "+ppg.isim);  //yukarıda textbox3 te kendimiz yazmamıza gerek kalnmadı sesi 

        }
    }
}
