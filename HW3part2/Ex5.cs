using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW3part2
{
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
           
        }
        async void ReadFiles(object file)
        {
            string content = File.ReadAllText(file as string);
            int num=await CountWords(content, textBox2.Text);
            SetLabelValue($"Filename: {file as string}  Number Of Words: {num} \n");
        }
        void SetLabelValue(string newValue)
        {
            lock (listBox1)
            {
                listBox1.Items.Add( newValue);
              //  label2.Text
            }
        }
        async Task<int> CountWords(string content, string word)
        {
            int c = 0;
            string[] arr = content.Split(' ');
            foreach (var item in arr)
            {
                if (item.Contains(word))
                {
                    c++;
                }
            }
            return c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (string file in Directory.EnumerateFiles(textBox1.Text, "*.txt"))
            {
                Thread thread=new Thread(new ParameterizedThreadStart(ReadFiles));
                thread.Start(file);
             

            }
        }
    }
}
