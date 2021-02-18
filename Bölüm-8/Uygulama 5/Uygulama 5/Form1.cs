using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Listele(string parametre)  //parametre değerini aldığını belirttik string olarak altta da bunu kullandık 
        {
            for(int i = 1; i <= 5; i++)
            {
                listBox1.Items.Add(parametre);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Listele("Merhaba");  //parametre değeri olarak string bir değer yazdık ve butona bastığımızda eyleme geçirttik
        }
    }
}
