using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conditional_Operators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int PrviBroj;
            int DrugiBroj;

            PrviBroj = int.Parse(textBox1.Text);
            DrugiBroj = int.Parse(textBox2.Text);


            if (PrviBroj > DrugiBroj) {

                MessageBox.Show("Prvi broj je veći od drugog broja");
            }

            else if (PrviBroj<DrugiBroj) {
            
                MessageBox.Show("Drugi broj je veći od prvog broja:");
            }

            else if (PrviBroj == DrugiBroj) {
                MessageBox.Show("Brojevi su jednaki");
            }
        }
    }
}
