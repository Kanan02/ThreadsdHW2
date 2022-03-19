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

    
    public partial class Ex1 : Form
    {
        public Ex1()
        {
            InitializeComponent();
        }
        private List<ProgressBar> bars=new List<ProgressBar>();
        Thread[] threads;
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                ProgressBar bar = new ProgressBar();
                bar.Name= $"bar{i+1}";
                bars.Add(bar);
                bar.Location = new System.Drawing.Point(90, 55*(i+1));
                Controls.Add(bar);
                bar.Maximum = 100;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            threads=new Thread[bars.Count];
            
            for (int i = 0;i < threads.Length; i++)
            {
                threads[i]=new Thread(new ParameterizedThreadStart(DanceProgressBar));
                threads[i].Start(bars[i]);
            }

        }
        void DanceProgressBar(object bar)
        {
            while (true)
            {
                (bar as ProgressBar).Value=RandomNumber().Result;
                Thread.Sleep(500);
            }
        }
        Random rnd = new Random();
        private async Task<int> RandomNumber()
        {
            var selected = 0;

            await Task.Run(() => {
                selected = rnd.Next(1, 100);
            });

            return selected;
        }

        private void Ex1_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (var item in threads)
            {
                item.Abort();
            }
        }
    }
}
