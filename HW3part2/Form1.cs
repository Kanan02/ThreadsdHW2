using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3part2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ex1btn_Click(object sender, EventArgs e)
        {
            Ex1 ex1 = new Ex1();
            ex1.ShowDialog();
        }

        private void ex2btn_Click(object sender, EventArgs e)
        {
            Ex2 ex2 = new Ex2();
            ex2.ShowDialog();
        }

        private void ex3btn_Click(object sender, EventArgs e)
        {
            Ex3 ex3 = new Ex3();
            ex3.ShowDialog();
        }

        private void ex4btn_Click(object sender, EventArgs e)
        {
            Ex4 ex4 = new Ex4(); 
            ex4.ShowDialog();
        }

        private void ex5btn_Click(object sender, EventArgs e)
        {
            Ex5 ex5 = new Ex5();
            ex5.ShowDialog();
        }
    }
}
