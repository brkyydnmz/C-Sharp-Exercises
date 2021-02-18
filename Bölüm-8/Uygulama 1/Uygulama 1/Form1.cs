using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Yaz()  //Geriye değer döndürmeyen metottur 
        {
            label1.Text = "Merhaba";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yaz(); //metodumuzu çağırarak burada kullandık.
        }
    }
}
