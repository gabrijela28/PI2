using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string Ime;
            string messageText;

            messageText = "Tvoje ime je:";

            Ime = textBox1.Text;
            //MessageBox.Show(messageText + Ime);
            label1.Text = messageText + Ime;
            textBox2.Text = messageText + Ime;
        }
    }
}
