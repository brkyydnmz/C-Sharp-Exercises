using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] semboller = { '+', '-', '*', '/' };
            for(int i = 0; i < semboller.Length; i++)  //length uzunluğu demektir  <= diyemeyiz hata verir hep < yada > olarak kullanılır
            {
                listBox1.Items.Add(semboller[i]);
            }
        }
    }
}
