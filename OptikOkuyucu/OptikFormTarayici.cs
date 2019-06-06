using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web;
using System.Data.OleDb;

namespace OptikOkuyucu
{
    public partial class formOptik : Form
    {
        /*
        char(65) = E 
        char(66) = D
        char(67)  = C
        char(68)  = B
        char(69)  = A
        */
        Bitmap resim;
        Boolean bul = false;
        string[] alfabe = new string[] { " ", "A", "B", "C", "D", "E", "F", "G", "Ğ", "H", "I", "İ", "J", "K", "L", "M", "N", "O", "Ö", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
        int[] sayilar = new int[] { 10, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        string[] ops = new string[] { " ", "A", "B", "C", "D", "E" };
        char[] dizi = new char[] { '-', 'A', 'B', 'C', 'Ç', 'D', 'E', 'F', 'G', 'Ğ', 'H', 'I', 'İ', 'J', 'K', 'L', 'M', 'N', 'O', 'Ö', 'P', 'R', 'S', 'Ş', 'T', 'U', 'Ü', 'V', 'Y', 'Z' };
        int baslangicX = 0;
        int baslangicY = 0;
        int sens = 23;//hassasiyet ayarı..
        string sinavKodu = "";
        string kitapcik = "";
        string adi = "";
        string tcNo = "";
        string sinifi = "";
        int dogruTR = 0, dogruMAT = 0, dogruSOS = 0, dogruFEN = 0;
        int yanlisTR = 0, yanlisMAT = 0, yanlisSOS = 0, yanlisFEN = 0;
        int bosTR = 0, bosMAT = 0, bosSOS = 0, bosFEN = 0;

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
                picOptikForm.Size = new System.Drawing.Size(510, 702);
            }
            btnTemizle.Enabled = true;

        }

        public void baslangicNoktasiTespiti() 
        {
            int maxX = 30;
            for (int x = 0; x <= maxX; x++ )
            {
                for (int y = 0; y <= 50; y++)
                {
                    if (resim.GetPixel(x, y).R == 0)
                    {
                        int ilkPosX = x;
                        int sonPosX = x;
                        int sayac = 0;
                        while ((sayac + x) < maxX)
                        { 
                            sayac++;
                            if(resim.GetPixel(x + sayac, y).R != 0)
                            {
                                sonPosX = x + sayac;
                                break;
                            }                         
                        }
                        if ((sonPosX - ilkPosX) > 5) {
                            int newX =(int)((sonPosX - ilkPosX) / 2) + ilkPosX;
                            resim.SetPixel(newX, y,Color.Red);
                            baslangicX = newX;
                            baslangicY = y;
                            y = 100;
                            x = 100;
                        }
                    }
                }
            }
            picOptikForm.Image = resim;
        }

        private void btnTara_Click(object sender, EventArgs e)
        {
/*            CepTefononuTara();
            soyadiniTara();
            SubeTara();
            GSMTara();
            adiniTara();
 */
            KurumKodunuTara();
/*            SınıfıTara();
            SubeTara();
            OgrenciNoTara();
*/
            KitapçıkTara();

            cevaplariTara(1);
            cevaplariTara(2);
            cevaplariTara(3);
            cevaplariTara(4);
            dogrulariYukle();
            karsilastir();
            sonucuKaydet();
        }

        public void sonucuKaydet()
        {
            string vt = Directory.GetParent(Application.ExecutablePath).ToString() + "/optikokuyucu.accdb";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + vt);
            baglanti.Open();

            string sqlStr = "insert into sonuclar (adi, tcno, sinavkodu, sinifi";
            sqlStr += ", tr_d,tr_y,tr_b,mat_d,mat_y,mat_b,sos_d,sos_y,sos_b,fen_d,fen_y,fen_b)";
            sqlStr += " values('"+adi+"','"+tcNo+"','"+sinavKodu+"','"+sinifi;
            sqlStr += "',"+ dogruTR.ToString() + "," + yanlisTR.ToString() + "," + bosTR.ToString();
            sqlStr += "," + dogruMAT.ToString() + "," + yanlisMAT.ToString() + "," + bosMAT.ToString();
            sqlStr += "," + dogruSOS.ToString() + "," + yanlisSOS.ToString() + "," + bosSOS.ToString();
            sqlStr += "," + dogruFEN.ToString() + "," + yanlisFEN.ToString() + "," + bosFEN.ToString();
            sqlStr += ")";

            OleDbCommand sorgu = new OleDbCommand(sqlStr, baglanti);
            sorgu.ExecuteNonQuery();
            baglanti.Close();
            
        }

        public void karsilastir()
        {
            //Türkçe
            for (int i = 0; i < 40; i++)
            {
                if (txtCvpTR.Text.Substring(i, 1) == textBox5.Text.Substring(i, 1))
                {
                    dogruTR++;
                }
                else
                {
                    if (txtCvpTR.Text.Substring(i, 1) == "0")
                    {
                        bosTR++;
                    }
                    else
                    {
                        yanlisTR++;
                    }
                }
            }
            //Matematik
            for (int i = 0; i < 40; i++)
            {
                if (txtCvpMAT.Text.Substring(i, 1) == textBox1.Text.Substring(i, 1))
                {
                    dogruMAT++;
                }
                else
                {
                    if (txtCvpMAT.Text.Substring(i, 1) == "0")
                    {
                        bosMAT++;
                    }
                    else
                    {
                        yanlisMAT++;
                    }
                }
            }
            //Sosyal
            for (int i = 0; i < 40; i++)
            {
                if (txtCvpSOS.Text.Substring(i, 1) == textBox2.Text.Substring(i, 1))
                {
                    dogruSOS++;
                }
                if (txtCvpSOS.Text.Substring(i, 1) == "0")
                {
                    bosSOS++;
                }
                else if (txtCvpSOS.Text.Substring(i, 1) != textBox2.Text.Substring(i, 1))
                {
                    yanlisSOS++;
                }
            }
            //Fen
            for (int i = 0; i < 40; i++)
            {
                if (txtCvpFEN.Text.Substring(i, 1) == textBox3.Text.Substring(i, 1))
                {
                    dogruFEN++;
                }
                if (txtCvpFEN.Text.Substring(i, 1) == "0")
                {
                    bosFEN++;
                }
                else if (txtCvpFEN.Text.Substring(i, 1) != textBox3.Text.Substring(i, 1))
                {
                    yanlisFEN++;
                }
            }

            MessageBox.Show("Türkçe \t\tDoğru : " + dogruTR.ToString() + " \tYanlış : " + yanlisTR.ToString() + " \tBoş : " + bosTR.ToString() + "\n"
                + "Matematik \tDoğru : " + dogruMAT.ToString() + " \tYanlış : " + yanlisMAT.ToString() + " \t\tBoş : " + bosMAT.ToString() + "\n"
                + "Sosyal \t\tDoğru : " + dogruSOS.ToString() + " \tYanlış : " + yanlisSOS.ToString() + " \tBoş : " + bosSOS.ToString() + "\n"
                + "Fen Bilimleri \tDoğru : " + dogruFEN.ToString() + " \tYanlış : " + yanlisFEN.ToString() + " \tBoş : " + bosFEN.ToString(), "Sınav Sonuçları", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        #region dogrulariYukle
        public void dogrulariYukle()
        {
            string vt = Directory.GetParent(Application.ExecutablePath).ToString() + "/optikokuyucu.accdb";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + vt);
            baglanti.Open();

            string sqlStr = "select * from dogrular where kitapcik = '" + kitapcik + "' and sinavkodu = '" + sinavKodu + "'";
            OleDbCommand sorgu = new OleDbCommand(sqlStr, baglanti);
            OleDbDataReader reader;

            sqlStr = "select * from dogrular where konu='TR' and kitapcik = '" + kitapcik + "' and sinavkodu = '" + sinavKodu + "'";
            sorgu.CommandText = sqlStr;
            reader = sorgu.ExecuteReader();
            reader.Read();
            textBox5.Text = reader.GetString(4);
            reader.Close();

            sqlStr = "select * from dogrular where konu='MAT' and kitapcik = '" + kitapcik + "' and sinavkodu = '" + sinavKodu + "'";
            sorgu.CommandText = sqlStr;
            reader = sorgu.ExecuteReader();
            reader.Read();
            textBox1.Text = reader.GetString(4);
            reader.Close();

            sqlStr = "select * from dogrular where konu='SOS' and kitapcik = '" + kitapcik + "' and sinavkodu = '" + sinavKodu + "'";
            sorgu.CommandText = sqlStr;
            reader = sorgu.ExecuteReader();
            reader.Read();
            textBox2.Text = reader.GetString(4);
            reader.Close();

            sqlStr = "select * from dogrular where konu='FEN' and kitapcik = '" + kitapcik + "' and sinavkodu = '" + sinavKodu + "'";
            sorgu.CommandText = sqlStr;
            reader = sorgu.ExecuteReader();
            reader.Read();
            textBox3.Text = reader.GetString(4);
            reader.Close();        

            baglanti.Close();

        }
        #endregion
     
        #region kodumunTaralari
        private void CepTefononuTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 353; x <= 413; x += 10)
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
        //
        // -- > Sınıfı < --
        //
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
        //
        // -- > Kurum Kodunu < --
        //
        private void KurumKodunuTara()
        {
            int satir = 0;
            int sutun = 0;
            int startX = baslangicX + 399;
            int startY = baslangicY + 106;

            for (int x = startX; x <= startX + 50; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = startY; y <= startY + 90 ; y += 10)
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
                    if (say > sens)
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
            sinavKodu = txtKurumKodu.Text;
        }

        //
        // -- > Kitapçık < --
        //
        private void KitapçıkTara()
        {
            int sutun = 0;
            int startX = baslangicX + 429;
            int startY = baslangicY + 517;

            sutun = 0;

            for (int y = startY; y <= startY + 30 ; y += 10)
            {
                sutun++;
                int say = 0;
                for (int kx = 0; kx <= 8; kx++)
                {
                    for (int ky = 0; ky <= 8; ky++)
                    {
                        if (resim.GetPixel(startX + kx, y + ky).R == 0)
                        {
                            say++;
                        }
                    }
                }
                if (say > sens)
                {
                    txtKitapcik.Text = dizi[sutun].ToString();
                    for (int kx = 0; kx <= 8; kx++)
                    {
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            resim.SetPixel(startX + kx, y + ky, Color.Gold);
                        }
                    }
                }
                picOptikForm.Image = resim;
            }
            kitapcik = txtKitapcik.Text;

            //// -- > A Kitapçığı < --
            //if (txtKitapcik.Text == "A")
            //{
            //    MessageBox.Show("A");
            //}

            //// -- > B Kitapçığı < --
            //if (txtKitapcik.Text == "B")
            //{
            //    MessageBox.Show("B");
            //}

            //// -- > C Kitapçığı < --
            //if (txtKitapcik.Text == "C")
            //{
            //    MessageBox.Show("C");
            //}

            //// -- > D Kitapçığı < --
            //if (txtKitapcik.Text == "D")
            //{
            //    MessageBox.Show("D");
            //}
        }

        //
        // -- > Adını < --
        //
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
        //
        // -- > GSM < --
        //
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
        //
        // -- > Şubesi < --
        //
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
        //
        // -- > TC Kimlik Numarası < --
        //
        private void TCTara()
        {
            int satir = 0;
            int sutun = 0;


            for (int x = 181; x <= 281; x += 10)
            {
                satir++;
                sutun = 0;

                for (int y = 147; y <= 237; y += 10)
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
                                resim.SetPixel(x + kx, y + ky, Color.Aqua);
                            }
                        }
                    }
                    picOptikForm.Image = resim;
                }
            }
        }
        //
        // -- > Öğrenci Numarası < --
        //
        private void OgrenciNoTara()
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
        //
        // -- > Soyadını < --
        //
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
        #endregion


        private void cevaplariTara(int gelen)
        {
            int satir = 0;
            int sutun = 0;
            int startX = 0;
            int startY = 0;
            int mesafe = 60;

            startY = baslangicY + 226;
            switch (gelen)
            {
                case 1:
                    startX = baslangicX + 158;
                    break;
                case 2:
                    startX = baslangicX + 158 + mesafe;
                    break;
                case 3:
                    startX = baslangicX + 158 + mesafe * 2;
                    break;
                case 4:
                    startX = baslangicX + 158 + mesafe * 3;
                    break;
            }

            for (int y = startY; y <= startY + 390; y += 10)
            {
                sutun++;
                satir = 0;

                bool ctrl = false;
                for (int x = startX; x <= startX + 40; x += 10)
                {
                    satir++;
                    int say = 0;
                    for (int ky = 0; ky <= 8; ky++)
                    {
                        for (int kx = 0; kx <= 8; kx++)
                        {
                            if (resim.GetPixel(x + kx, y + ky).R == 0)
                            {
                                say++;
                            }
                        }
                    }
                    if (say > sens)
                    {
                        switch (gelen)
                        {
                            case 1:
                                    txtCvpTR.Text += ops[satir].ToString();
                                break;
                            case 2:
                                    txtCvpMAT.Text += ops[satir].ToString();
                                break;
                            case 3:
                                    txtCvpSOS.Text += ops[satir].ToString();
                                break;
                            case 4:
                                    txtCvpFEN.Text += ops[satir].ToString();
                                break;
                        }
                        ctrl = true;
                        for (int ky = 0; ky <= 8; ky++)
                        {
                            for (int kx = 0; kx <= 8; kx++)
                            {
                                resim.SetPixel(x + ky, y + kx, Color.Green);
                            }
                        }
                        break;//br satırda ilk işareti bulunca satırdan çık
                    }
                }
                if (ctrl == false)
                    switch (gelen)
                    {
                        case 1:
                            txtCvpTR.Text += "0";
                            break;
                        case 2:
                            txtCvpMAT.Text += "0";
                            break;
                        case 3:
                            txtCvpSOS.Text += "0";
                            break;
                        case 4:
                            txtCvpFEN.Text += "0";
                            break;
                    }
            }
            picOptikForm.Image = resim;
            lblTurkce.Text = txtCvpTR.TextLength.ToString();
        }

        //
        // -- > Resmi Siyah ve Beyaz Yap
        //
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            progbarYukleniyor.Value = 0;
            for (int x = 0; x < resim.Width; x++)
            {
                progbarYukleniyor.Maximum = resim.Width;
                if (progbarYukleniyor.Value < resim.Width)
                {
                    progbarYukleniyor.Value += 1;
                }
                else
                {
                    progbarYukleniyor.Value = 0;
                }
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
            baslangicNoktasiTespiti();
        }
        //
        // -- > Klasördeki Resimleri Bul
        //
        private void btKlasor_Click(object sender, EventArgs e)
        {
            DialogResult klasor = ofKlasor.ShowDialog();
            if (klasor == DialogResult.OK)
            {
                int toplam = 0;
                string resimler = "";
                foreach (string resim in System.IO.Directory.GetFiles(ofKlasor.SelectedPath, "*.jpg"))
                {

                    resimler = resim;
                    listboxFormlar.Items.Add(resimler);
                    toplam++;
                }
                if (toplam > 0)
                {
                    MessageBox.Show("Bu konum içerisinde, " + toplam.ToString() + " adet resim tespit edildi !", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Resim dosyası (*.jpg) tespit edilemedi !", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //for(int i= 1;i <= klasor.HasFlag; i++)
                //picOptikForm.Image = Image.FromFile(ofOptikForm.FileName);
                //resim = new Bitmap(Image.FromFile(ofOptikForm.FileName));
            }
        }
        //
        // -- > Resimleri Tara
        //
        private void btnFTara_Click(object sender, EventArgs e)
        {
            int dosyalar = 0;
            for (int i = 0; i < listboxFormlar.Items.Count; i++)
            {
                alfabe = new string[listboxFormlar.Items.Count - 1];
                //alfabe[i] = listboxFormlar. ;
                dosyalar++;
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
                CepTefononuTara();
                soyadiniTara();
                SubeTara();
                GSMTara();
                adiniTara();
                KurumKodunuTara();
                SınıfıTara();
                SubeTara();
                OgrenciNoTara();
                KitapçıkTara();
                MessageBox.Show(alfabe[i].ToString() + ". dosya kaydedildi");
            }
            //MessageBox.Show(listboxFormlar.SelectedItem.ToString() + " Taranıyor...");
        }

        private void btnCvp_Click(object sender, EventArgs e)
        {
            frmCevap cvp = new frmCevap();
            cvp.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bul == false)
            {
                numericUpDown1.Value++;
                SendKeys.Send(textBox4.Text);
            }
            else
            {
                timer1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void formOptik_Load(object sender, EventArgs e)
        {
            //kulak.SetInputToDefaultAudioDevice();
            //Choices ses = new Choices("hello", "bye");
            //GrammarBuilder gramerci = new GrammarBuilder(ses);
            //Grammar gramer = new Grammar(gramerci);
            //kulak.LoadGrammar(gramer);
            //kulak.SpeechRecognized += kulak_Duy;
            //kulak.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void button1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == numericUpDown1.Value)
            {
                button1.Text = "bulundu!";
                bul = true;
            }
        }

        private void picOptikForm_MouseMove(object sender, MouseEventArgs e)
        {
            txtTC.Text = e.X.ToString() + " : " + e.Y.ToString();
        }


        //void kulak_Duy(object sender, SpeechRecognizedEventArgs e)
        //{
        //    foreach (RecognizedWordUnit words in e.Result.Words)
        //    {
        //        if (words.Text.Equals("hello"))
        //        {
        //            MessageBox.Show("Hoşgeldin :)");
        //        }
        //        else if (words.Text.Equals("bye"))
        //        {
        //            MessageBox.Show("Güle güle :(");
        //        }
        //        else 
        //        {
        //            MessageBox.Show("Anlamadım ?");
        //        }
        //    }
        //}

        //private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        //{
            //if (e.KeyChar == 65) 
            //{
            //    MessageBox.Show("E tuşuna bastınız.");
            //}
            //if (e.KeyChar == 65)
            //{
            //    MessageBox.Show("D tuşuna bastınız.");
            //}
            //if (e.KeyChar == 99)
            //{
            //    MessageBox.Show("C tuşuna bastınız.");
            //}
            //if (e.KeyChar == 98)
            //{
            //    MessageBox.Show("B tuşuna bastınız.");
            //}
            //if (e.KeyChar == 97)
            //{
            //    MessageBox.Show("A tuşuna bastınız.");
            //}
        //}
    }
}
