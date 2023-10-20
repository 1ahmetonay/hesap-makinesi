namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        double ilk_sayi;
        bool Etemizle;
        char islem;
        public Form1()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "1";
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "2";
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "3";
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "4";
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "5";
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "6";
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "7";
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "8";
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (Etemizle)
            {
                lblsonuc.Text = "";
                Etemizle = false;
            }
            if (lblsonuc.Text == "0")
            {
                lblsonuc.Text = "";
            }
            lblsonuc.Text += "9";
        }

        /*  private void btndlt_Click(object sender, EventArgs e)
          {
              int basamak = 0;
              double sayi =Convert.ToDouble(lblsonuc.Text);

              while (sayi!=0)
              {
                  sayi /= 10;
                  ++basamak;
              }
              if (basamak > 0)
              {
                  // Label'daki metni al
                  int boyut = basamak;

                  // Son karakteri sil
                  boyut = boyut.Remove(boyut - 1);

                  // Metni label'a geri yaz
                  lblsonuc.Text = boyut.ToString();
              }
          }*/

        private void btnmod_Click(object sender, EventArgs e)
        {
            Etemizle = true;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = '%';
        }

        private void btnkup_Click(object sender, EventArgs e)
        {
            Etemizle = false;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = '3';
        }

        private void btnac_Click(object sender, EventArgs e)
        {
            lblsonuc.Text = "0";
        }

        private void btnksr_Click(object sender, EventArgs e)
        {
            Etemizle = true;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = 'k';
        }

        private void btnkare_Click(object sender, EventArgs e)
        {
            Etemizle = false;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = '2';
        }

        private void btnkok_Click(object sender, EventArgs e)
        {
            Etemizle = false;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = '√';
        }

        private void btnblm_Click(object sender, EventArgs e)
        {
            Etemizle = true;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = '÷';
        }

        private void btncrp_Click(object sender, EventArgs e)
        {
            Etemizle = true;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = 'x';
        }

        private void btnckr_Click(object sender, EventArgs e)
        {
            Etemizle = true;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = '-';
        }

        private void btntpl_Click(object sender, EventArgs e)
        {
            Etemizle = true;
            ilk_sayi = Convert.ToDouble(lblsonuc.Text);
            islem = '+';
        }

        private void btnesit_Click(object sender, EventArgs e)
        {
            double ikinci_sayi = Convert.ToDouble(lblsonuc.Text);
            double sonuc = 0;

            switch (islem)
            {
                case '%':
                    sonuc = ilk_sayi % ikinci_sayi; break;

                case '3':
                    sonuc = ilk_sayi * ilk_sayi * ilk_sayi; break;

                case 'k':

                    double sayi = Convert.ToDouble(lblsonuc.Text);
                    if (sayi != 0)
                    {
                        // Sayının tersini al
                        double tersSayi = 1 / sayi;

                        // Sayıyı "1/x" formatında yazdır
                        sonuc = tersSayi;
                    }
                    else
                    {
                        MessageBox.Show("Sıfırın tersi tanımsızdır.");
                    }
                    break;

                case '2':
                    sonuc = ilk_sayi * ilk_sayi; break;

                case '√':
                    sonuc = Math.Sqrt(ilk_sayi); break;

                case '÷':
                    sonuc = ilk_sayi / ikinci_sayi; break;

                case 'x':
                    sonuc = ilk_sayi * ikinci_sayi; break;

                case '-':
                    sonuc = ilk_sayi - ikinci_sayi; break;

                case '+':
                    sonuc = ilk_sayi + ikinci_sayi; break;
                default:
                    break;
            }
            lblsonuc.Text = Convert.ToString(sonuc);
        }
    }
}