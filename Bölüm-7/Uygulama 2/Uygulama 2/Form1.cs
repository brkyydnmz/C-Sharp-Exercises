using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] iller = new string[4];
            iller[0] = "Ankara";
            iller[1] = "Balıkesir";
            iller[2] = "İstanbul";
            iller[3] = "İzmir";
            label1.Text = iller[1];
        }
    }
}
