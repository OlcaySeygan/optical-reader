using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OptikOkuyucu
{
    public partial class formOptik : Form
    {
        Bitmap resim;
        string[] alfabe = new string[] { " ", "A", "B", "C", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        int[] sayilar = new int[] { 10,0,1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] siklar = new string[] { " ", "A", "B", "C", "D", "E" };
        char[] dizi = new char[] { '-', 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        public formOptik()
        {
            InitializeComponent();
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            DialogResult form = ofOptikForm.ShowDialog();
            if (form == DialogResult.OK) 
            {
                picOptikForm.Image = Image.FromFile(ofOptikForm.FileName);
                resim = new Bitmap(Image.FromFile(ofOptikForm.FileName));
            }
            
        }
        private void btnTara_Click(object sender, EventArgs e)
        {
            CepTefononuTara();
            soyadiniTara();
            SubeTara();
            GSMTara();
            adiniTara();
            KurumKodunuTara();
            SınıfıTara();
            SubeTara();
            OgrenciTara();
            KitapçıkTara();
            TürkçeTara();
            TemelMatematikTara();
            SosyalBilimlerTara();
            FenBilimleriTara();
        }

        private void CepTefononuTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 351; x <= 413; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 148; y <= 238; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtCepTelefoNo.Text = txtCepTelefoNo.Text + sayilar[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void SınıfıTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 434; x <= 454; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 288; y <= 378; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtSinifi.Text = txtSinifi.Text + sayilar[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void KurumKodunuTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 434; x <= 484; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 148; y <= 238; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtKurumKodu.Text = txtKurumKodu.Text + sayilar[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void adiniTara() 
        {
            int satir = 0;
            int sutun = 0;

            
            for (int x = 51; x <= 161; x += 10) 
            {
                satir++;
                sutun = 0;
                
                for (int y = 59; y <= 348; y += 10) 
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtAdi.Text = txtAdi.Text + dizi[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void KitapçıkTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 459; x <= 469; x += 6)
            {
                satir++;
                sutun = 0;

                for (int y = 559; y <= 589; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtKitapcik.Text = txtKitapcik.Text + dizi[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void GSMTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 312; x <= 342; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 148; y <= 238; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtGSM.Text = txtGSM.Text + sayilar[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void SubeTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 454; x <= 484; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 288; y <= 378; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtSube.Text = txtSube.Text + dizi[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void TCTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 181; x <= 281; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 148; y <= 238; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtTC.Text = txtTC.Text + sayilar[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }


        private void OgrenciTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 434; x <= 484; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 428; y <= 518; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtOgenciNo.Text = txtOgenciNo.Text + sayilar[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void soyadiniTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 51; x <= 161; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 378; y <= 658; y += 10)
                {
                    sutun++;
                    int say = 0;
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtSoyadi.Text = txtSoyadi.Text + dizi[sutun].ToString();
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            for (int ky = 0; ky <= 8; ky++)
                            {
                                resim.SetPixel(x + kx, y + ky, Color.Gold);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void TürkçeTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int y = 267; y <= 657; y += 10)
            {
                sutun++;
                satir = 0;

                for (int x = 191; x <= 231; x += 10)
                {
                    satir++;
                    int say = 0;
                    for (int ky = 0; ky <= 12; ky++)
                    {
                        for (int kx = 0; kx <= 12; kx++)
                        {
                            if (resim.GetPixel(x + kx,y + ky ).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtTurkce.Text = txtTurkce.Text + siklar[satir].ToString() + " ";
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            for (int kx = 0; kx <= 8; kx++)
                            {
                                resim.SetPixel(x + ky,y + kx , Color.Green);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void TemelMatematikTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int y = 267; y <= 657; y += 10)
            {
                sutun++;
                satir = 0;

                for (int x = 251; x <= 291; x += 10)
                {
                    satir++;
                    int say = 0;
                    for (int ky = 0; ky <= 12; ky++)
                    {
                        for (int kx = 0; kx <= 12; kx++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtMatematik.Text = txtMatematik.Text + siklar[satir].ToString() + " ";
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            for (int kx = 0; kx <= 8; kx++)
                            {
                                resim.SetPixel(x + ky, y + kx, Color.Purple);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void SosyalBilimlerTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int y = 267; y <= 657; y += 10)
            {
                sutun++;
                satir = 0;

                for (int x = 311; x <= 351; x += 10)
                {
                    satir++;
                    int say = 0;
                    for (int ky = 0; ky <= 12; ky++)
                    {
                        for (int kx = 0; kx <= 12; kx++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtSosyal.Text = txtSosyal.Text + siklar[satir].ToString() + " ";
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            for (int kx = 0; kx <= 8; kx++)
                            {
                                resim.SetPixel(x + ky, y + kx, Color.Red);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void FenBilimleriTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int y = 267; y <= 657; y += 10)
            {
                sutun++;
                satir = 0;

                for (int x = 371; x <= 411; x += 10)
                {
                    satir++;
                    int say = 0;
                    for (int ky = 0; ky <= 12; ky++)
                    {
                        for (int kx = 0; kx <= 12; kx++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > 20)
                    {
                        txtFen.Text = txtFen.Text + siklar[satir].ToString() + " ";
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            for (int kx = 0; kx <= 8; kx++)
                            {
                                resim.SetPixel(x + ky, y + kx, Color.Blue);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }

        private void picOptikForm_MouseClick(object sender, MouseEventArgs e)
        {
            Koordinatlar.Items.Add("X: " + e.X + " " + "Y: " + e.Y + " " + "Renk: " + resim.GetPixel(e.X,e.Y));
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < resim.Width; x++) 
            {
                for (int y = 0; y < resim.Height; y++) 
                {
                    int renkler = resim.GetPixel(x, y).R + resim.GetPixel(x, y).B + resim.GetPixel(x, y).G;
                    if (renkler > 150)
                    {
                        resim.SetPixel(x, y, Color.White);
                    }
                    else 
                    {
                        resim.SetPixel(x, y, Color.Black);
                    }
                }
            }
            picOptikForm.Image = resim;
        }
    }
}
