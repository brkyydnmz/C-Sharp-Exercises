using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sıra;
        string[] isim = { "Ali", "Berkay", "Hasan", "Akif", "Kutay", "Emre" };
        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0; i < isim.Length; i++)
            {
                listBox1.Items.Add(isim[i]);
            }    
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sıra = Array.IndexOf(isim,"Berkay");   //Berkay (arrayden) index no sorgulama
            label1.Text = "Berkay index sırası: "+sıra.ToString();
        }
    }
}
