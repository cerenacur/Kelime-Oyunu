using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace kelimeoyun
{
     public partial class Form2 : Form
     {
          public Form2()
          {
               InitializeComponent();
          }
          sql baglanti = new sql();
          private void button1_Click(object sender, EventArgs e)
        {
          
                    SqlCommand ekle = new SqlCommand("insert into soru(sorular,kelime) values (@sorular, @kelime)", baglanti.con);
                    
                    ekle.Parameters.AddWithValue("@kelime", textBox3.Text);
                    ekle.Parameters.AddWithValue("@sorular", textBox1.Text);

                    ekle.ExecuteNonQuery();
                    baglanti.con.Close();
                    MessageBox.Show("Katkılarınızdan Dolayı Teşekkürler Soru ve Kelime başarı İle eklendi.");
               


          }

          private void Form2_Load(object sender, EventArgs e)
          {
               baglanti.baglan();
          }

          private void button2_Click(object sender, EventArgs e)
          {
               Form1  frm = new Form1();
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
     }
     }

