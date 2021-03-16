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
    public partial class Tree : Form
    {
        public Tree()
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
            Fruits fr1 = new Fruits();
            fr1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Flower fl1 = new Flower();
            fl1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Vegetable v1 = new Vegetable();
            v1.ShowDialog();
        }
    }
}
