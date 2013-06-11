using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace For_petlja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int multiply = 10;
            int loopStart;
            int loopEnd;
            int odgovor = 0;

            loopStart = int.Parse(textBox1.Text);
            loopEnd = int.Parse(textBox2.Text);

            for (int i = loopStart; i < loopEnd; i++)
            {

                odgovor = multiply * i;
                listBox1.Items.Add(i+" puta " + multiply+"="+odgovor.ToString());
            }
            MessageBox.Show(odgovor.ToString());
        }
        
    }
}
