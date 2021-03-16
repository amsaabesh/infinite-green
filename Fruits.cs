using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Infinite_green
{
    public partial class Fruits : Form
    {
        public Fruits()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Mango m1 = new Mango();
            m1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Guava g1 = new Guava();
            g1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lemon l1 = new Lemon();
            l1.ShowDialog();
        }
    }
}
