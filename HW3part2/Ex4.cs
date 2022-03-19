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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
            button1.Enabled = false;
        }
        void ReadFile()
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Text File";
            theDialog.Filter = "TXT files|*.txt";
            theDialog.InitialDirectory = @"C:\";
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            byte[] buf=new byte[myStream.Length];
                            myStream.Read(buf, 0, buf.Length);

                            SetLabelValue( $"In this file, this word repeated {CountWords(Encoding.UTF8.GetString(buf, 0, buf.Length), textBox1.Text)} times"); 
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        void SetLabelValue(string newValue)
        {
            lock (label2)
            {
                label2.Text = newValue;
            }
        }
        int CountWords(string content,string word)
        {
            int c = 0;
            string[]arr= content.Split(' ');
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
            Thread thread = new Thread(ReadFile);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
    }
}
