using Microsoft.VisualBasic.ApplicationServices;

namespace Calculator_v2._0
{
    public partial class HesapMakinesi : Form
    {
        int secim = 0;
        double sayi1, sayi2, sonuc;
        public HesapMakinesi()
        {
            InitializeComponent();
        }
        private bool isDarkTheme = false;

        private void ApplyDarkTheme()
        {
            // Formun arka plan rengini koyu gri yap
            this.BackColor = Color.FromArgb(45, 45, 48);

            // Form üzerindeki tüm kontrolleri döngüyle dolaþ
            foreach (Control control in this.Controls)
            {
                // Label, Button, TextBox, ListBox gibi kontroller için
                if (control is Label || control is Button || control is TextBox || control is ListBox)
                {
                    control.ForeColor = Color.White; // Açýk renk metin
                    control.BackColor = Color.FromArgb(28, 28, 28); // Daha koyu gri arka plan
                }

                // Eðer GroupBox veya Panel gibi kaplayýcý kontroller varsa
                if (control is GroupBox || control is Panel)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        childControl.ForeColor = Color.White;
                        childControl.BackColor = Color.FromArgb(28, 28, 28);
                    }
                }
            }
        }

        private void ApplyLightTheme()
        {
            // Formun arka plan rengini beyaz yap
            this.BackColor = Color.White;
           

            // Form üzerindeki tüm kontrolleri döngüyle dolaþ
            foreach (Control control in this.Controls)
            {
                // Label, Button, TextBox, ListBox gibi kontroller için
                if (control is Label || control is Button || control is TextBox || control is ListBox)
                {
                    control.ForeColor = Color.Black; // Siyah renk metin
                    control.BackColor = Color.White; // Beyaz arka plan
                }

                // Eðer GroupBox veya Panel gibi kaplayýcý kontroller varsa
                if (control is GroupBox || control is Panel)
                {
                    foreach (Control childControl in control.Controls)
                    {
                        childControl.ForeColor = Color.Black;
                        childControl.BackColor = Color.White;
                    }
                }
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlar = new Ayarlar();
            ayarlar.ShowDialog();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "1";
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "2";
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "3";
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "4";
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "5";
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "6";
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "7";
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "8";
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "9";
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text += "0";
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(guna2TextBox1.Text);
            secim = 1;
            label1.Text = guna2TextBox1.Text + "+";
            guna2TextBox1.Text = "0";
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = "";
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Text = guna2TextBox1.Text.Substring(0, guna2TextBox1.Text.Length - 1);
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(guna2TextBox1.Text);
            secim = 2;
            label1.Text = guna2TextBox1.Text + "-";
            guna2TextBox1.Text = "0";
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(guna2TextBox1.Text);
            secim = 3;
            label1.Text = guna2TextBox1.Text + "x";
            guna2TextBox1.Text = "0";
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            sayi1 = double.Parse(guna2TextBox1.Text);
            secim = 4;
            label1.Text = guna2TextBox1.Text + "/";
            guna2TextBox1.Text = "0";
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            sayi2 = double.Parse(guna2TextBox1.Text);
            if (secim == 1)
            {
                sonuc = sayi1 + sayi2;
            }
            guna2TextBox1.Text = sonuc.ToString();
            if (secim == 2)
            {
                sonuc = sayi1 - sayi2;
            }
            guna2TextBox1.Text = sonuc.ToString();
            if (secim == 3)
            {
                sonuc = sayi1 * sayi2;
            }
            guna2TextBox1.Text = sonuc.ToString();
            if (secim == 4)
            {
                sonuc = sayi1 / sayi2;
            }
            guna2TextBox1.Text = sonuc.ToString();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text.IndexOf(",") < 1)
            {
                guna2TextBox1.Text += ",";
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (guna2TextBox1.Text != "0")
            {
                if (guna2TextBox1.Text.StartsWith("-"))
                {
                    guna2TextBox1.Text = guna2TextBox1.Text.Replace("-", "");
                }
                else if (guna2TextBox1.Text.StartsWith(""))
                {
                    guna2TextBox1.Text = "-" + guna2TextBox1.Text;
                }

            }
        }

        private void guna2Button25_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(guna2TextBox1.Text);
            kare = Math.Pow(kare, 2);
            guna2TextBox1.Text = Convert.ToString(kare);
        }

        private void guna2Button24_Click(object sender, EventArgs e)
        {
            double karekok = Convert.ToDouble(guna2TextBox1.Text);
            karekok = Math.Sqrt(karekok);
            guna2TextBox1.Text = Convert.ToString(karekok);
        }

        private void guna2Button26_Click(object sender, EventArgs e)
        {
            double bolum = Convert.ToDouble(guna2TextBox1.Text);
            bolum = 1 / (bolum);
            guna2TextBox1.Text = Convert.ToString(bolum);
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {

            try
            {

                double sayi = double.Parse(guna2TextBox1.Text);
                double yuzde = 0.01 * sayi;


                guna2TextBox1.Text = yuzde.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen geçerli bir sayý girin. Hata: " + ex.Message);
            }
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            guna2TextBox1.Clear();
        }

        private void guna2Button27_Click(object sender, EventArgs e)
        {
            // Mevcut temaya göre koyu veya beyaz tema uygulama
            // Mevcut controlboxlarý, yazýlrý, çerçeve rengini, ýconcolorunu temaya uyarladým.
            if (isDarkTheme)
            {
                ApplyLightTheme();
                
                isDarkTheme = false;
                
                guna2ControlBox1.FillColor = Color.White;
                guna2ControlBox2.FillColor = Color.White;
                guna2ControlBox3.FillColor = Color.White;
                guna2ControlBox1.IconColor = Color.FromArgb(45, 45, 48);
                guna2ControlBox2.IconColor = Color.FromArgb(45, 45, 48);
                guna2ControlBox3.IconColor = Color.FromArgb(45, 45, 48);
                guna2TextBox1.FillColor = Color.White;
                guna2TextBox1.PlaceholderForeColor = Color.Black;
                guna2Button3.FillColor = Color.White;
                guna2Button4.FillColor = Color.White;
                guna2Button5.FillColor = Color.White;
                guna2Button8.FillColor = Color.White;
                guna2Button9.FillColor = Color.White;
                guna2Button10.FillColor = Color.White;
                guna2Button12.FillColor = Color.White;
                guna2Button13.FillColor = Color.White;
                guna2Button14.FillColor = Color.White;
                guna2Button16.FillColor = Color.White;
                guna2Button17.FillColor = Color.White;
                guna2Button18.FillColor = Color.White;
                guna2Button19.FillColor = Color.White;
                guna2Button20.FillColor = Color.White;
                guna2Button21.FillColor = Color.White;
                guna2Button22.FillColor = Color.White;
                guna2Button24.FillColor = Color.White;
                guna2Button25.FillColor = Color.White;
                guna2Button26.FillColor = Color.White;
                guna2Button3.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button4.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button5.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button6.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button7.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button9.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button8.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button10.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button11.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button12.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button13.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button14.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button15.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button16.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button17.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button18.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button19.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button20.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button21.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button22.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button23.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button24.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button25.ForeColor = Color.FromArgb(45, 45, 48);
                guna2Button26.ForeColor = Color.FromArgb(45, 45, 48);
                guna2TextBox1.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button3.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button4.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button5.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button7.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button8.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button9.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button10.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button11.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button12.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button13.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button14.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button15.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button16.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button17.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button18.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button19.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button20.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button21.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button22.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button23.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button24.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button25.BorderColor = Color.FromArgb(45, 45, 48);
                guna2Button26.BorderColor = Color.FromArgb(45, 45, 48);
                guna2TextBox1.ForeColor = Color.Black;
                label1.ForeColor = Color.OrangeRed;

            }
            else
            {
                ApplyDarkTheme();
               
                isDarkTheme = true;
                guna2ControlBox1.FillColor = Color.FromArgb(45, 45, 48);
                guna2ControlBox2.FillColor = Color.FromArgb(45, 45, 48);
                guna2ControlBox3.FillColor = Color.FromArgb(45, 45, 48);
                guna2ControlBox1.IconColor = Color.White;
                guna2ControlBox2.IconColor = Color.White;
                guna2ControlBox3.IconColor = Color.White;
                guna2TextBox1.FillColor = Color.FromArgb(45, 45, 48);
                guna2TextBox1.PlaceholderForeColor = Color.White;
                guna2Button3.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button4.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button5.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button8.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button9.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button10.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button12.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button13.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button14.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button16.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button17.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button18.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button19.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button20.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button21.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button22.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button24.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button25.FillColor = Color.FromArgb(45, 45, 48);
                guna2Button26.FillColor = Color.FromArgb(45, 45, 48);
                guna2TextBox1.BorderColor = Color.OrangeRed;
                guna2Button3.BorderColor = Color.OrangeRed;
                guna2Button4.BorderColor = Color.OrangeRed;
                guna2Button5.BorderColor = Color.OrangeRed;
                guna2Button6.BorderColor = Color.OrangeRed;
                guna2Button7.BorderColor = Color.OrangeRed;
                guna2Button8.BorderColor = Color.OrangeRed;
                guna2Button9.BorderColor = Color.OrangeRed;
                guna2Button10.BorderColor = Color.OrangeRed;
                guna2Button11.BorderColor = Color.OrangeRed;
                guna2Button12.BorderColor = Color.OrangeRed;
                guna2Button13.BorderColor = Color.OrangeRed;
                guna2Button14.BorderColor = Color.OrangeRed;
                guna2Button15.BorderColor = Color.OrangeRed;
                guna2Button16.BorderColor = Color.OrangeRed;
                guna2Button17.BorderColor = Color.OrangeRed;
                guna2Button18.BorderColor = Color.OrangeRed;
                guna2Button19.BorderColor = Color.OrangeRed;
                guna2Button20.BorderColor = Color.OrangeRed;
                guna2Button21.BorderColor = Color.OrangeRed;
                guna2Button22.BorderColor = Color.OrangeRed;
                guna2Button23.BorderColor = Color.OrangeRed;
                guna2Button24.BorderColor = Color.OrangeRed;
                guna2Button25.BorderColor = Color.OrangeRed;
                guna2Button26.BorderColor = Color.OrangeRed;
                guna2Button3.ForeColor = Color.White;
                guna2Button4.ForeColor = Color.White;
                guna2Button5.ForeColor = Color.White;
                guna2Button6.ForeColor = Color.White;
                guna2Button8.ForeColor = Color.White;
                guna2Button9.ForeColor = Color.White;
                guna2Button10.ForeColor = Color.White;
                guna2Button12.ForeColor = Color.White;
                guna2Button13.ForeColor = Color.White;
                guna2Button14.ForeColor = Color.White;
                guna2Button16.ForeColor = Color.White;
                guna2Button17.ForeColor = Color.White;
                guna2Button18.ForeColor = Color.White;
                guna2Button19.ForeColor = Color.White;
                guna2Button20.ForeColor = Color.White;
                guna2Button21.ForeColor = Color.White;
                guna2Button22.ForeColor = Color.White;
                guna2Button24.ForeColor = Color.White;
                guna2Button25.ForeColor = Color.White;
                guna2Button26.ForeColor = Color.White;
                guna2TextBox1.ForeColor = Color.White;
                label1.ForeColor = Color.OrangeRed;
                label1.BackColor = Color.FromArgb(45, 45, 48);
            }
        }
    }
}
