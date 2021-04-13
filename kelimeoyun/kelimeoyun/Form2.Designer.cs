namespace kelimeoyun
{
     partial class Form2
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
               this.button1 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.button5 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.textBox3 = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.Transparent;
               this.button1.FlatAppearance.BorderSize = 0;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Location = new System.Drawing.Point(685, 445);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(75, 83);
               this.button1.TabIndex = 0;
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.Color.Transparent;
               this.button2.FlatAppearance.BorderSize = 0;
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button2.Location = new System.Drawing.Point(790, 445);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(75, 83);
               this.button2.TabIndex = 1;
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // textBox1
               // 
               this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
               this.textBox1.Location = new System.Drawing.Point(637, 282);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(300, 48);
               this.textBox1.TabIndex = 2;
               // 
               // button5
               // 
               this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.button5.FlatAppearance.BorderSize = 0;
               this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
               this.button5.Location = new System.Drawing.Point(923, -2);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(38, 44);
               this.button5.TabIndex = 20;
               this.button5.Text = "__";
               this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button4
               // 
               this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.button4.FlatAppearance.BorderSize = 0;
               this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
               this.button4.Location = new System.Drawing.Point(967, -2);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(38, 44);
               this.button4.TabIndex = 19;
               this.button4.Text = "X";
               this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // textBox3
               // 
               this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
               this.textBox3.Location = new System.Drawing.Point(635, 362);
               this.textBox3.Multiline = true;
               this.textBox3.Name = "textBox3";
               this.textBox3.Size = new System.Drawing.Size(300, 50);
               this.textBox3.TabIndex = 21;
               // 
               // Form2
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.ClientSize = new System.Drawing.Size(1003, 621);
               this.Controls.Add(this.textBox3);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button1);
               this.DoubleBuffered = true;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Form2";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form2";
               this.Load += new System.EventHandler(this.Form2_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
    }
}