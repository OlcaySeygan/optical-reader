using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace OptikOkuyucu
{
    public partial class frmCevap : Form
    {
        int cvptr, cvpmat, cvpsos, cvpfen;
        public frmCevap()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            cevaplariKaydet();
            refreshGrid();
            cvptr = txtCvpTR.TextLength;
            cvpmat = txtCvpMAT.TextLength;
            cvpsos = txtCvpSOS.TextLength;
            cvpfen = txtCvpFEN.TextLength;
            string cvptop = "";
            if (cvptr < 40)
            {
                cvptop += "Türkçenin cevap anahtarını " + cvptr.ToString() + ". soruya kadar girdiniz.";
            }
            if (cvpmat < 40)
            {
                cvptop += "\n" + "Matematiğin cevap anahtarını " + cvpmat.ToString() + ". soruya kadar girdiniz.";
            }
            if (cvpsos < 40)
            {
                cvptop += "\n" + "Sosyal Bilgilerin cevap anahtarını " + cvpsos.ToString() + ". soruya kadar girdiniz.";
            }
            if (cvpfen < 40)
            {
                cvptop += "\n" + "Fen Bilimlerinin cevap anahtarını " + cvpfen.ToString() + ". soruya kadar girdiniz.";
            }
            if (txtSinavKodu.TextLength != 6)
            {
                cvptop += "\n" + "Sınav kodunu eksik girdiniz.";
            }
            if(cvptop != "") MessageBox.Show(cvptop,"Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public bool formKontrol()
        {
            if (txtCvpMAT.Text == "") return false;
            if (txtCvpFEN.Text == "") return false;
            if (txtCvpTR.Text == "") return false;
            if (txtCvpSOS.Text == "") return false;
            if (comboKitap.Text == "") return false;
            if (txtSinavKodu.Text == "") return false;
            return true;
        }


        public void cevaplariKaydet()
        {
            if (formKontrol())
            {
                if ((txtCvpFEN.TextLength == 40) && (txtCvpMAT.TextLength == 40) && (txtCvpSOS.TextLength == 40) && (txtCvpTR.TextLength == 40) && (txtSinavKodu.TextLength == 6))
                {
                string vt = Directory.GetParent(Application.ExecutablePath).ToString() + "/optikokuyucu.accdb";
                OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + vt);
                baglanti.Open();
                string sqlStr = "insert into dogrular (kitapcik, sinavkodu, konu, cevaplar) values('";
                sqlStr += comboKitap.Text + "','" + txtSinavKodu.Text + "','TR', '" + txtCvpTR.Text.Trim() + "')";
                OleDbCommand sorgu = new OleDbCommand(sqlStr, baglanti);
                sorgu.ExecuteNonQuery();
                sqlStr = "insert into dogrular (kitapcik, sinavkodu, konu, cevaplar) values('";
                sqlStr += comboKitap.Text + "','" + txtSinavKodu.Text + "','MAT', '" + txtCvpMAT.Text.Trim() + "')";
                sorgu = new OleDbCommand(sqlStr, baglanti);
                sorgu.ExecuteNonQuery();
                sqlStr = "insert into dogrular (kitapcik, sinavkodu, konu, cevaplar) values('";
                sqlStr += comboKitap.Text + "','" + txtSinavKodu.Text + "','SOS', '" + txtCvpSOS.Text.Trim() + "')";
                sorgu = new OleDbCommand(sqlStr, baglanti);
                sorgu.ExecuteNonQuery();
                sqlStr = "insert into dogrular (kitapcik, sinavkodu, konu, cevaplar) values('";
                sqlStr += comboKitap.Text + "','" + txtSinavKodu.Text + "','FEN', '" + txtCvpFEN.Text.Trim() + "')";
                sorgu = new OleDbCommand(sqlStr, baglanti);
                sorgu.ExecuteNonQuery();
                baglanti.Close();
                }
            }
        }

        public void refreshGrid()
        {
            string vt = Directory.GetParent(Application.ExecutablePath).ToString() + "/optikokuyucu.accdb";
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + vt);
            baglanti.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from dogrular", baglanti);
            DataSet dts = new DataSet();
            da.Fill(dts, "dogrular");
            dataGridView1.DataSource = dts.Tables["dogrular"];
        }

        private void frmCevap_Load(object sender, EventArgs e)
        {
            refreshGrid();
        }

        private void txtCvpTR_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 65) || (e.KeyChar == 66) || (e.KeyChar == 67) || (e.KeyChar == 68) || (e.KeyChar == 69) || (e.KeyChar == 8))
            {
                lblUyarı.Text = "Geçerli.";
            }
            else 
            {
                lblUyarı.Text = "Geçerli olmayan karekter girdiniz !";
            }
        }

        private void txtCvpMAT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 65) || (e.KeyChar == 66) || (e.KeyChar == 67) || (e.KeyChar == 68) || (e.KeyChar == 69) || (e.KeyChar == 8))
            {
                lblUyarı.Text = "Geçerli.";
            }
            else
            {
                lblUyarı.Text = "Geçerli olmayan karekter girdiniz !";
            }
        }

        private void txtCvpSOS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 65) || (e.KeyChar == 66) || (e.KeyChar == 67) || (e.KeyChar == 68) || (e.KeyChar == 69) || (e.KeyChar == 8))
            {
                lblUyarı.Text = "Geçerli.";
            }
            else
            {
                lblUyarı.Text = "Geçerli olmayan karekter girdiniz !";
            }
        }

        private void txtCvpFEN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 65) || (e.KeyChar == 66) || (e.KeyChar == 67) || (e.KeyChar == 68) || (e.KeyChar == 69) || (e.KeyChar == 8))
            {
                lblUyarı.Text = "Geçerli.";
            }
            else
            {
                lblUyarı.Text = "Geçerli olmayan karekter girdiniz !";
            }
        }

        private void txtSinavKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == 48) || (e.KeyChar == 49) || (e.KeyChar == 50) || (e.KeyChar == 51) || (e.KeyChar == 52) || (e.KeyChar == 53) || (e.KeyChar == 54) || (e.KeyChar == 55) || (e.KeyChar == 56) || (e.KeyChar == 57) || (e.KeyChar == 8))
            {
                lblUyarı.Text = "Geçerli.";
            }
            else
            {
                lblUyarı.Text = "Geçerli olmayan karekter girdiniz !"; 
            }
        }
    }
}
