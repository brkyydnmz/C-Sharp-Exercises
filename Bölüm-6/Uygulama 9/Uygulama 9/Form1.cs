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
            
            int number_one = Convert.ToInt32(textBox1.Text);
            int number_two = Convert.ToInt32(textBox2.Text);
            int toplam = 0;
            
            while(number_one <= number_two)
            {
                toplam += number_one;
                number_one++;
            }
            MessageBox.Show("Toplam: " + toplam.ToString());
        }
    }
}
