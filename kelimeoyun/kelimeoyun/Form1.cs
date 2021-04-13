using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kelimeoyun
{
     public partial class Form1 : Form
     {
          public Form1()
          {
               InitializeComponent();
          }
         public static string k_adi;
        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

          private void button1_Click(object sender, EventArgs e)
          {
               Form2 frm = new Form2();
               frm.Show();  // form2 göster diyoruz
               this.Hide();
              
          }


          private void button3_Click(object sender, EventArgs e)
          {
               k_adi = textBox1.Text;
             

               oyun frm = new oyun();
               frm.Show();  // form2 göster diyoruz
               this.Hide();

              
          }

          private void button4_Click(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void button5_Click(object sender, EventArgs e)
          {
               this.WindowState = FormWindowState.Minimized;
          }

          private void Form1_Load(object sender, EventArgs e)
          {

          }

          private void button2_Click(object sender, EventArgs e)
          {
               sıralama frm= new sıralama();
               frm.Show();  // form2 göster diyoruz
               this.Hide();

             
          }
     }
}
