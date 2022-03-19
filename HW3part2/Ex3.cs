using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3part2
{
    public partial class Ex3 : Form
    {
        public Ex3()
        {
            InitializeComponent();
        }

        void FibonachiSquence()
        {
            int n1 = 0, n2 = 1;
            textBox1.Text = $"{n1}; {n2}; ";
            Thread.Sleep(200);
            while (n1+n2<int.Parse(textBox2.Text))
            {
                int n3 = n1 + n2;
                textBox1.Text += $"{n3}; ";
                Thread.Sleep(200);
                n1 = n2;
                n2 = n3;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(FibonachiSquence);
            thread.Start();
        }
    }
}
