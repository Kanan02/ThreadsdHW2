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
    public partial class Ex2 : Form
    {
        List<ProgressBar> bars = new List<ProgressBar>();
        Thread[] threads=new Thread[5];
        Random rnd = new Random();
        
        public Ex2()
        {
            InitializeComponent();
            bars.Add(horse1);
            bars.Add(horse2);
            bars.Add(horse3);
            bars.Add(horse4);
            bars.Add(horse5);
            foreach (var item in bars)
            {
                item.Maximum = 100;
                item.Value = 0;
             //   item.
            }
           
        }
        Thread checkingThread;
        void CheckValue()
        {
            bool found = false;
            while (!found)
            {
                foreach (var bar in bars )
                {
                    if (bar.Value == 100)
                    {
                        LoadListBox();
                        found = true;
                        break;
                    }
                }
            }
        }
        void LoadListBox()
        {
            foreach (var item in bars)
            {
                listBox1.Items.Add($"{item.Name}: {item.Value}");
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            checkingThread=new Thread(new ThreadStart(CheckValue));
            checkingThread.Start();
            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ParameterizedThreadStart(IncrementBar));
                threads[i].Start(bars[i]);
            }

        }
        void IncrementBar(object bar)
        {
            while ((bar as ProgressBar).Value < 100)
            {
                // (bar as ProgressBar).Value+=RandomNumber().Result;
                int n = (RandomNumber().Result);
                if ((bar as ProgressBar).Value + n >= 100)
                {
                    (bar as ProgressBar).Value = 100;
                    break;
                }
                else
                {
                    SetValue(n, bar as ProgressBar);
                    Thread.Sleep(100);
                }
            }
            

        }
        delegate void SetTextCallback(int val,ProgressBar bar);

        private void SetValue(int val,ProgressBar bar)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
           
            if (bar.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetValue);
                this.Invoke(d, new object[] { val,bar });
            }
            else
            {
                bar.Value += val;
            }

            
        }
        private async Task<int> RandomNumber()
        {
            var selected = 0;

            await Task.Run(() => {
                selected = rnd.Next(1, 8);
            });

            return selected;
        }
    }
}
