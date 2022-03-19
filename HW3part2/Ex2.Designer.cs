namespace HW3part2
{
    partial class Ex2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.horse1 = new System.Windows.Forms.ProgressBar();
            this.horse2 = new System.Windows.Forms.ProgressBar();
            this.horse3 = new System.Windows.Forms.ProgressBar();
            this.horse4 = new System.Windows.Forms.ProgressBar();
            this.horse5 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // horse1
            // 
            this.horse1.Location = new System.Drawing.Point(144, 115);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(100, 23);
            this.horse1.TabIndex = 1;
            // 
            // horse2
            // 
            this.horse2.Location = new System.Drawing.Point(144, 158);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(100, 23);
            this.horse2.TabIndex = 2;
            // 
            // horse3
            // 
            this.horse3.Location = new System.Drawing.Point(144, 199);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(100, 23);
            this.horse3.TabIndex = 3;
            // 
            // horse4
            // 
            this.horse4.Location = new System.Drawing.Point(144, 243);
            this.horse4.Name = "horse4";
            this.horse4.Size = new System.Drawing.Size(100, 23);
            this.horse4.TabIndex = 4;
            // 
            // horse5
            // 
            this.horse5.Location = new System.Drawing.Point(144, 287);
            this.horse5.Name = "horse5";
            this.horse5.Size = new System.Drawing.Size(100, 23);
            this.horse5.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(395, 115);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(309, 180);
            this.listBox1.TabIndex = 6;
            // 
            // Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.horse5);
            this.Controls.Add(this.horse4);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.button1);
            this.Name = "Ex2";
            this.Text = "Ex2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ProgressBar horse1;
        private System.Windows.Forms.ProgressBar horse2;
        private System.Windows.Forms.ProgressBar horse3;
        private System.Windows.Forms.ProgressBar horse4;
        private System.Windows.Forms.ProgressBar horse5;
        private System.Windows.Forms.ListBox listBox1;
    }
}