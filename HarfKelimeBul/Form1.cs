using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //dosya .text işlemleri için sonradan referans edildi eklendi

namespace HarfKelimeBul
{
    public partial class Form1 : Form
    {
        Char[] harfler = { 'a', 'b', 'c','ç', 'd', 'e', 'f', 'g', 'ğ', 'h', 'ı', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'ö', 'p', 'r', 's', 'ş', 't', 'u', 'ü', 'v', 'y', 'z' };
        Char[] harf = new char[8];  //toplam 8 elemanlı karakter dizisi 

        public Form1()
        {
            InitializeComponent();
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            var nums = Enumerable.Range(0, 29).ToArray();
            var rnd = new Random();

          for (int i = 0; i < nums.Length; ++i) 
            {
                int randomIndex = rnd.Next(nums.Length); //
                int temp = nums[randomIndex];
                nums[randomIndex] = nums[i];
                nums[i] = temp;
            }
    

            for (int i = 0; i < 8; i++)   //oluşşturan rakamlar alfadeki sıra sayısı olrk kullanıldı
            {
                harf[i] = harfler[nums[i]]; //8 tane harf dizisine eklendi
               
            }

            textBox1.Text = harf[0].ToString(); //rastgele olusturulan harfler txbxtlara eklenir
            textBox2.Text = harf[1].ToString();
            textBox3.Text = harf[2].ToString();
            textBox4.Text = harf[3].ToString();
            textBox5.Text = harf[4].ToString();
            textBox6.Text = harf[5].ToString();
            textBox7.Text = harf[6].ToString();
            textBox8.Text = harf[7].ToString();

            textBox9.Clear();
            motor();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

            if(textBox1.Text==""){
                return;
            }
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            radioButton7.Visible = true;
            radioButton8.Visible = true;

            textBox1.BackColor = Color.Yellow;
            textBox2.BackColor = Color.Yellow;
            textBox3.BackColor = Color.Yellow;
            textBox4.BackColor = Color.Yellow;
            textBox5.BackColor = Color.Yellow;
            textBox6.BackColor = Color.Yellow;
            textBox7.BackColor = Color.Yellow;
            textBox8.BackColor = Color.Yellow;

            button3.Visible = true;
            button4.Visible = true;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;
            textBox8.ReadOnly = false;
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "VAZGEÇİLDİ";
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;

            button4.Visible = false;
            button3.Visible = false;
            textBox1.BackColor = Color.AntiqueWhite;
            textBox2.BackColor = Color.AntiqueWhite;
            textBox3.BackColor = Color.AntiqueWhite;
            textBox4.BackColor = Color.AntiqueWhite;
            textBox5.BackColor = Color.AntiqueWhite;
            textBox6.BackColor = Color.AntiqueWhite;
            textBox7.BackColor = Color.AntiqueWhite;
            textBox8.BackColor = Color.AntiqueWhite;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;
        }

      
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

      
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) //textboxlara sadece harf girme denetimi
                && !char.IsSeparator(e.KeyChar);
        }

        private void button4_Click(object sender, EventArgs e)
        {

            
            
            if(radioButton1.Checked){
                harf[0] = Convert.ToChar(textBox1.Text);
                motor();
                
            } else if (radioButton2.Checked){
                harf[1] = Convert.ToChar(textBox2.Text);
                motor();
            } else if(radioButton3.Checked) {
                harf[2] = Convert.ToChar(textBox3.Text);
                motor();
            }
            else if (radioButton3.Checked)
            {
                harf[3] = Convert.ToChar(textBox4.Text);
                motor();
            }
            else if (radioButton4.Checked) 
            {
                harf[4] = Convert.ToChar(textBox5.Text);
                motor();
            }
            else if (radioButton5.Checked)
            {
                harf[5] = Convert.ToChar(textBox6.Text);
                motor();
            }
            else if (radioButton6.Checked)
            {
                harf[6] = Convert.ToChar(textBox7.Text);
                motor();
            }
            else if (radioButton5.Checked)
            {
                harf[7] = Convert.ToChar(textBox8.Text);
                motor();
            }
            else { 
                MessageBox.Show("lütfen seçim yapın");
                return;
            }
            toolStripStatusLabel1.Text = "JOKER KULLANILDI";

            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            radioButton6.Visible = false;
            radioButton7.Visible = false;
            radioButton8.Visible = false;

            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;

            textBox1.BackColor = Color.AntiqueWhite;
            textBox2.BackColor = Color.AntiqueWhite;
            textBox3.BackColor = Color.AntiqueWhite;
            textBox4.BackColor = Color.AntiqueWhite;
            textBox5.BackColor = Color.AntiqueWhite;
            textBox6.BackColor = Color.AntiqueWhite;
            textBox7.BackColor = Color.AntiqueWhite;
            textBox8.BackColor = Color.AntiqueWhite;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        
        
        public void motor()
        {
            FileStream fs = new FileStream(Application.StartupPath + "\\metin.txt", FileMode.Open, FileAccess.Read);
            StreamReader sw = new StreamReader(fs);
            string yazi;
            int harfsayac=0;
            int vsay=0;
            while (true) //döngü şartsız başladı
            {
                vsay++;
                yazi = sw.ReadLine(); //.txt dosyası 1.satırı okundu
                if (yazi == null)  //döngüden çıkma şartı satır boş olunca döngü biter.
                {
                    vsay = 0; break;
                }
                //a = yazi.Contains(harf[0]);
                //b = yazi.Contains(harf[1]);
                //c = yazi.Contains(harf[2]);
                for (int r = 0; r < 7; r++) //toplam rastgele çıkan 8 harfi .txt satırdan okunan kelimeyle kontrol eder
                {
                    if (yazi.Contains(harf[r]))
                    {
                        harfsayac++;
                    }
                    if(harfsayac >= 3){
                        if (harfsayac == Convert.ToInt32(yazi.Length)) {

                            textBox9.Text = yazi;
                        }
                    } 
                   
                }
               
                harfsayac = 0;

            } vsay = 0;

            sw.Close();
        }

        
       
    }
}
