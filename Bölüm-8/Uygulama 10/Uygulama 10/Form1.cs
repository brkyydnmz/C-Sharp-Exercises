using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Faktoriyel(int a)
        {
            if (a == 0)
                return 1;  // 0 faktoriyel 1 e eşit olduğu için 1 döndürüyor 
            return a * Faktoriyel(a - 1);   // a=0 a ulaşana kadar azalarak çarpma yapar 1 er 1 er azalır    //bu durumda yinelenen metod oluyor buna rekürsif metod denir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = Faktoriyel(Convert.ToInt32(textBox1.Text)).ToString();
        }
    }
}
