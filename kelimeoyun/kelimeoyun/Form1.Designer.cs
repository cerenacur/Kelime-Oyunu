namespace kelimeoyun
{
     partial class Form1
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.button1 = new System.Windows.Forms.Button();
               this.button3 = new System.Windows.Forms.Button();
               this.button4 = new System.Windows.Forms.Button();
               this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
               this.button5 = new System.Windows.Forms.Button();
               this.button2 = new System.Windows.Forms.Button();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.SuspendLayout();
               // 
               // button1
               // 
               this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
               this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
               this.button1.FlatAppearance.BorderSize = 4;
               this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.button1.Location = new System.Drawing.Point(23, 601);
               this.button1.Name = "button1";
               this.button1.Size = new System.Drawing.Size(211, 45);
               this.button1.TabIndex = 2;
               this.button1.Text = "KELİME ÖNER";
               this.button1.UseVisualStyleBackColor = false;
               this.button1.Click += new System.EventHandler(this.button1_Click);
               // 
               // button3
               // 
               this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
               this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
               this.button3.FlatAppearance.BorderSize = 0;
               this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.button3.Location = new System.Drawing.Point(680, 499);
               this.button3.Name = "button3";
               this.button3.Size = new System.Drawing.Size(134, 38);
               this.button3.TabIndex = 1;
               this.button3.Text = "START";
               this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               this.button3.UseVisualStyleBackColor = false;
               this.button3.Click += new System.EventHandler(this.button3_Click);
               // 
               // button4
               // 
               this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
               this.button4.FlatAppearance.BorderSize = 0;
               this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
               this.button4.Location = new System.Drawing.Point(967, 2);
               this.button4.Name = "button4";
               this.button4.Size = new System.Drawing.Size(38, 44);
               this.button4.TabIndex = 17;
               this.button4.Text = "X";
               this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
               this.button4.UseVisualStyleBackColor = false;
               this.button4.Click += new System.EventHandler(this.button4_Click);
               // 
               // button5
               // 
               this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.button5.FlatAppearance.BorderSize = 0;
               this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
               this.button5.Location = new System.Drawing.Point(923, -8);
               this.button5.Name = "button5";
               this.button5.Size = new System.Drawing.Size(38, 44);
               this.button5.TabIndex = 18;
               this.button5.Text = "__";
               this.button5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
               this.button5.UseVisualStyleBackColor = false;
               this.button5.Click += new System.EventHandler(this.button5_Click);
               // 
               // button2
               // 
               this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
               this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(45)))), ((int)(((byte)(80)))));
               this.button2.FlatAppearance.BorderSize = 4;
               this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.button2.Location = new System.Drawing.Point(23, 548);
               this.button2.Name = "button2";
               this.button2.Size = new System.Drawing.Size(211, 53);
               this.button2.TabIndex = 19;
               this.button2.Text = "PUAN TABLOSU";
               this.button2.UseVisualStyleBackColor = false;
               this.button2.Click += new System.EventHandler(this.button2_Click);
               // 
               // textBox1
               // 
               this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
               this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
               this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(231)))), ((int)(((byte)(232)))));
               this.textBox1.Location = new System.Drawing.Point(655, 431);
               this.textBox1.Multiline = true;
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(181, 45);
               this.textBox1.TabIndex = 20;
               this.textBox1.Text = "Kullanıcı Adınızı Giriniz";
               this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
               // 
               // Form1
               // 
               this.AcceptButton = this.button3;
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
               this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
               this.CancelButton = this.button4;
               this.ClientSize = new System.Drawing.Size(1003, 666);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.button2);
               this.Controls.Add(this.button5);
               this.Controls.Add(this.button4);
               this.Controls.Add(this.button3);
               this.Controls.Add(this.button1);
               this.DoubleBuffered = true;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.Load += new System.EventHandler(this.Form1_Load);
               this.ResumeLayout(false);
               this.PerformLayout();

          }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}