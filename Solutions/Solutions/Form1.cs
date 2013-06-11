using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solutions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnIntegers_Click(object sender, EventArgs e)
        {
            int MojInteger;
            MojInteger = 25;
            MessageBox.Show(MojInteger.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float MyFloat;
            MyFloat = 0.42F;
            MessageBox.Show(MyFloat.ToString());
        }
    }
}
