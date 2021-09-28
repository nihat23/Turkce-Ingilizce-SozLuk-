using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;// access ıcın kutuphanemızı eklıyoruz...

namespace Sözlük_Yapımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglantim = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\vt_sozluk.accdb");

        OleDbCommand komut;

        OleDbDataReader oku;

        private void bilgilergoster()
        {
            listBox1.Items.Clear();
            baglantim.Open();
            komut = new OleDbCommand("select * from sozluk", baglantim);
            oku = komut.ExecuteReader();
            while (oku.Read())
            {
                listBox1.Items.Add(oku["ingilizce"].ToString() + " : " + oku["turkce"].ToString());
            }
            baglantim.Close();

        }

        private void button1ekle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    int siraNo = listBox1.Items.IndexOf(textBox1.Text);

                    if (siraNo == -1)
                    {
                        baglantim.Open();
                        komut = new OleDbCommand("insert into sozluk (ingilizce,turkce) values('" + textBox1.Text + "','" + textBox2.Text + "')", baglantim);
                        komut.ExecuteNonQuery();
                        baglantim.Close();
                        label4hata.Text = "Sözcük veri tabanına eklendi..";

                        
                        textBox1.Clear();
                        textBox2.Clear();
                        label4Toplam.Text = listBox1.Items.Count.ToString();
                    }
                   
                   
                }
                else
                {
                    label4hata.Text = "Kelimelerı karşıtı  yazınız..!";
                }


            }
            catch (Exception)
            {
                label4hata.Text = textBox1.Text + " Listede Zaten var..";
                baglantim.Close();
            }



        }

        private void textBox1_Click(object sender, EventArgs e)
        {

            label4hata.Text = "__";

        }

        private void button3guncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    baglantim.Open();
                    komut = new OleDbCommand("update sozluk set turkce='" + textBox2.Text + "' where ingilizce='" + textBox1.Text + "'", baglantim);
                    komut.ExecuteNonQuery();
                    baglantim.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    label4hata.Text = "Sözcuk Güncelledi..";
                }
                else
                {
                    label4hata.Text = " Güncelleme istediginiz kelimeleri yazınız.!";
                }

            }
            catch (Exception)
            {

                label4hata.Text = "Hata oluştu..!";
                baglantim.Close();
            }


        }

        private void button2sil_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" || textBox2.Text != "")
                {
                    baglantim.Open();
                    komut = new OleDbCommand("delete from sozluk where ingilizce='" + textBox1.Text + "'", baglantim);
                    komut.ExecuteNonQuery();
                    baglantim.Close();
                    label4hata.Text = "Sözcük silindi..!";
                  
                    textBox1.Clear();
                    textBox2.Clear();
                    label4Toplam.Text = listBox1.Items.Count.ToString();
                }
                else
                {
                    label4hata.Text = " Silmek istediginiz ing kelimeyi yazınız.!";
                }
            }
            catch (Exception)
            {


                label4hata.Text = "Hata oluştu..!";
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                baglantim.Open();
                komut = new OleDbCommand("select * from sozluk where ingilizce like '" + textBox1.Text + "%'", baglantim);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku["ingilizce"].ToString() + " : " + oku["turkce"].ToString());
                }
                baglantim.Close();

            }
            catch (Exception)
            {

                label4hata.Text = "ürün bulumadım";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();
                baglantim.Open();
                komut = new OleDbCommand("select * from sozluk where turkce like '" + textBox2.Text + "%'", baglantim);
                oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    listBox1.Items.Add(oku["ingilizce"].ToString() + " : " + oku["turkce"].ToString());
                }
                baglantim.Close();

            }
            catch (Exception)
            {

                label4hata.Text = "ürün bulumadım";
            }
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
        }

        private void textBox2_DoubleClick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
         
        }

        private void button4YaziDegis_Click(object sender, EventArgs e)
        {
            FontDialog yazim = new FontDialog();
            yazim.ShowColor = true;
            if (yazim.ShowDialog() == DialogResult.OK)
            {
                listBox1.Font = yazim.Font;
                listBox1.ForeColor = yazim.Color;

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/n.beyi");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bilgilergoster();

            label4Toplam.Text = listBox1.Items.Count.ToString();

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
