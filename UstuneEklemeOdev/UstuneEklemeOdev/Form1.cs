using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UstuneEklemeOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public int KısaYol(TextBox t1, TextBox t6, TextBox t11, TextBox t16, TextBox t21)
        {
            int ortayol = 0;
            try
            {
                int yazılı1 = Int32.Parse(t1.Text);
                int yazılı2 = Int32.Parse(t6.Text);
                int yazılı3 = Int32.Parse(t11.Text);
                int sozlu1 = Int32.Parse(t16.Text);
                int sozlu2 = Int32.Parse(t21.Text);

                ortayol = (yazılı1 + yazılı2 + yazılı3 + sozlu1 + sozlu2) / 5;
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI  İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            return ortayol;
        }
        //-------------------------------------------------------------------------------------------

        private void Hesaplama_Bır_Click_1(object sender, EventArgs e)
        {
            textBox27.Text = KısaYol(textBox1, textBox6, textBox11, textBox16, textBox21).ToString();
            Hesaplama_Bır.ForeColor = Color.DarkOrange;
        }

        private void Hesaplama_Ikı_Click_1(object sender, EventArgs e)
        {
            textBox28.Text = KısaYol(textBox2, textBox7, textBox12, textBox17, textBox22).ToString();
            Hesaplama_Ikı.ForeColor = Color.Fuchsia;
        }

        private void Hesaplama_uc_Click_1(object sender, EventArgs e)
        {
            textBox29.Text = KısaYol(textBox3, textBox8, textBox13, textBox18, textBox23).ToString();
            Hesaplama_uc.ForeColor = Color.DarkRed;
        }

        private void Hesaplama_Dort_Click_1(object sender, EventArgs e)
        {
            textBox30.Text = KısaYol(textBox4, textBox9, textBox14, textBox19, textBox24).ToString();
            Hesaplama_Dort.ForeColor = Color.Tan;
        }

        private void Hesaplama_Bes_Click_1(object sender, EventArgs e)
        {
            textBox31.Text = KısaYol(textBox5, textBox10, textBox15, textBox20, textBox25).ToString();
            Hesaplama_Bes.ForeColor = Color.HotPink;
        }

        private void Ortalama_Hesaplama_Click(object sender, EventArgs e)
        {
            textBox26.Text = OrtBulma(textBox27, textBox28, textBox29, textBox30, textBox31).ToString();
            Ortalama_Hesaplama.ForeColor = Color.YellowGreen;
        }
       
        //---------------------------------------------------------------------------------------------

        public int OrtBulma(TextBox t27, TextBox t28, TextBox t29, TextBox t30, TextBox t31)
        {
            int ortsonuc=0;
            try
            {
                int ort1 = Int32.Parse(t27.Text);
                int ort2 = Int32.Parse(t28.Text);
                int ort3 = Int32.Parse(t29.Text);
                int ort4 = Int32.Parse(t30.Text);
                int ort5 = Int32.Parse(t31.Text);

                
                textBox26.Text = ((ort1 + ort2 + ort3 + ort4 + ort5) / 5).ToString();
                ortsonuc = Int32.Parse(textBox26.Text);

                if ((ortsonuc >= 0) && (ortsonuc <= 24))
                {
                    textBox26.Text = ortsonuc + "(0)";
                }
                else if ((ortsonuc >= 25) && (ortsonuc <= 44))
                {
                    textBox26.Text = ortsonuc + "(1)";
                }
                else if ((ortsonuc >= 45) && (ortsonuc <= 54))
                {
                    textBox26.Text = ortsonuc + "(2)";
                }
                else if ((ortsonuc >= 55) && (ortsonuc <= 69))
                {
                    textBox26.Text = ortsonuc + "(3)";
                }
                else if ((ortsonuc >= 70) && (ortsonuc <= 84))
                {
                    textBox26.Text = ortsonuc + "(4)";
                }
                else if ((ortsonuc >= 85) && (ortsonuc <= 100))
                {
                    textBox26.Text = ortsonuc + "(5)";
                }
            }
            catch (Exception hata1)
            {
                MessageBox.Show("HATALI İŞLEM ");
                MessageBox.Show(hata1.Message);
            }
            finally
            {
                MessageBox.Show(" İYİ  DERSLER  =)");
            }
            return ortsonuc;
        }

       
       
        //---------------------------------------------SON----------------------------------------------

    }
}
