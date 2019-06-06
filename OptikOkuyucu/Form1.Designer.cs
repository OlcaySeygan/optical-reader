namespace OptikOkuyucu
{
    partial class formOptik
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picOptikForm = new System.Windows.Forms.PictureBox();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnTara = new System.Windows.Forms.Button();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.ofOptikForm = new System.Windows.Forms.OpenFileDialog();
            this.Koordinatlar = new System.Windows.Forms.ListBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.txtGSM = new System.Windows.Forms.TextBox();
            this.lblGSM = new System.Windows.Forms.Label();
            this.txtCepTelefoNo = new System.Windows.Forms.TextBox();
            this.lblCepTelefonNo = new System.Windows.Forms.Label();
            this.txtKurumKodu = new System.Windows.Forms.TextBox();
            this.lvlKurumKodu = new System.Windows.Forms.Label();
            this.txtSinifi = new System.Windows.Forms.TextBox();
            this.lblSinifi = new System.Windows.Forms.Label();
            this.txtSube = new System.Windows.Forms.TextBox();
            this.lblSube = new System.Windows.Forms.Label();
            this.txtOgenciNo = new System.Windows.Forms.TextBox();
            this.lblOgrenciNo = new System.Windows.Forms.Label();
            this.txtKitapcik = new System.Windows.Forms.TextBox();
            this.lblOgreniNo = new System.Windows.Forms.Label();
            this.txtTurkce = new System.Windows.Forms.TextBox();
            this.lblTurkce = new System.Windows.Forms.Label();
            this.lblMatematik = new System.Windows.Forms.Label();
            this.txtMatematik = new System.Windows.Forms.TextBox();
            this.lblSosyal = new System.Windows.Forms.Label();
            this.txtSosyal = new System.Windows.Forms.TextBox();
            this.lblFen = new System.Windows.Forms.Label();
            this.txtFen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOptikForm)).BeginInit();
            this.SuspendLayout();
            // 
            // picOptikForm
            // 
            this.picOptikForm.Location = new System.Drawing.Point(12, 12);
            this.picOptikForm.Name = "picOptikForm";
            this.picOptikForm.Size = new System.Drawing.Size(510, 702);
            this.picOptikForm.TabIndex = 0;
            this.picOptikForm.TabStop = false;
            this.picOptikForm.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOptikForm_MouseClick);
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(528, 12);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(100, 25);
            this.btnForm.TabIndex = 1;
            this.btnForm.Text = "Optik Form Seç";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(634, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 25);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnTara
            // 
            this.btnTara.Location = new System.Drawing.Point(528, 43);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(100, 25);
            this.btnTara.TabIndex = 3;
            this.btnTara.Text = "Formu Tara";
            this.btnTara.UseVisualStyleBackColor = true;
            this.btnTara.Click += new System.EventHandler(this.btnTara_Click);
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(528, 71);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(28, 13);
            this.lblAdi.TabIndex = 4;
            this.lblAdi.Text = "Adı :";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(528, 110);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(45, 13);
            this.lblSoyadi.TabIndex = 5;
            this.lblSoyadi.Text = "Soyadı :";
            // 
            // ofOptikForm
            // 
            this.ofOptikForm.FileName = "Optik Form Seç";
            // 
            // Koordinatlar
            // 
            this.Koordinatlar.FormattingEnabled = true;
            this.Koordinatlar.Location = new System.Drawing.Point(531, 619);
            this.Koordinatlar.Name = "Koordinatlar";
            this.Koordinatlar.Size = new System.Drawing.Size(438, 95);
            this.Koordinatlar.TabIndex = 6;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(528, 87);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.ReadOnly = true;
            this.txtAdi.Size = new System.Drawing.Size(100, 20);
            this.txtAdi.TabIndex = 7;
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(528, 126);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(100, 20);
            this.txtSoyadi.TabIndex = 8;
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Location = new System.Drawing.Point(528, 149);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(74, 13);
            this.lblTC.TabIndex = 9;
            this.lblTC.Text = "TC Kimlik No :";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(528, 165);
            this.txtTC.Name = "txtTC";
            this.txtTC.ReadOnly = true;
            this.txtTC.Size = new System.Drawing.Size(100, 20);
            this.txtTC.TabIndex = 10;
            // 
            // txtGSM
            // 
            this.txtGSM.Location = new System.Drawing.Point(528, 204);
            this.txtGSM.Name = "txtGSM";
            this.txtGSM.ReadOnly = true;
            this.txtGSM.Size = new System.Drawing.Size(100, 20);
            this.txtGSM.TabIndex = 12;
            // 
            // lblGSM
            // 
            this.lblGSM.AutoSize = true;
            this.lblGSM.Location = new System.Drawing.Point(528, 188);
            this.lblGSM.Name = "lblGSM";
            this.lblGSM.Size = new System.Drawing.Size(65, 13);
            this.lblGSM.TabIndex = 11;
            this.lblGSM.Text = "GSM Kodu :";
            // 
            // txtCepTelefoNo
            // 
            this.txtCepTelefoNo.Location = new System.Drawing.Point(528, 243);
            this.txtCepTelefoNo.Name = "txtCepTelefoNo";
            this.txtCepTelefoNo.ReadOnly = true;
            this.txtCepTelefoNo.Size = new System.Drawing.Size(100, 20);
            this.txtCepTelefoNo.TabIndex = 14;
            // 
            // lblCepTelefonNo
            // 
            this.lblCepTelefonNo.AutoSize = true;
            this.lblCepTelefonNo.Location = new System.Drawing.Point(528, 227);
            this.lblCepTelefonNo.Name = "lblCepTelefonNo";
            this.lblCepTelefonNo.Size = new System.Drawing.Size(88, 13);
            this.lblCepTelefonNo.TabIndex = 13;
            this.lblCepTelefonNo.Text = "Cep Telefon No :";
            // 
            // txtKurumKodu
            // 
            this.txtKurumKodu.Location = new System.Drawing.Point(528, 282);
            this.txtKurumKodu.Name = "txtKurumKodu";
            this.txtKurumKodu.ReadOnly = true;
            this.txtKurumKodu.Size = new System.Drawing.Size(100, 20);
            this.txtKurumKodu.TabIndex = 16;
            // 
            // lvlKurumKodu
            // 
            this.lvlKurumKodu.AutoSize = true;
            this.lvlKurumKodu.Location = new System.Drawing.Point(528, 266);
            this.lvlKurumKodu.Name = "lvlKurumKodu";
            this.lvlKurumKodu.Size = new System.Drawing.Size(71, 13);
            this.lvlKurumKodu.TabIndex = 15;
            this.lvlKurumKodu.Text = "Kurum Kodu :";
            // 
            // txtSinifi
            // 
            this.txtSinifi.Location = new System.Drawing.Point(528, 321);
            this.txtSinifi.Name = "txtSinifi";
            this.txtSinifi.ReadOnly = true;
            this.txtSinifi.Size = new System.Drawing.Size(100, 20);
            this.txtSinifi.TabIndex = 18;
            // 
            // lblSinifi
            // 
            this.lblSinifi.AutoSize = true;
            this.lblSinifi.Location = new System.Drawing.Point(528, 305);
            this.lblSinifi.Name = "lblSinifi";
            this.lblSinifi.Size = new System.Drawing.Size(35, 13);
            this.lblSinifi.TabIndex = 17;
            this.lblSinifi.Text = "Sınıfı :";
            // 
            // txtSube
            // 
            this.txtSube.Location = new System.Drawing.Point(528, 360);
            this.txtSube.Name = "txtSube";
            this.txtSube.ReadOnly = true;
            this.txtSube.Size = new System.Drawing.Size(100, 20);
            this.txtSube.TabIndex = 20;
            // 
            // lblSube
            // 
            this.lblSube.AutoSize = true;
            this.lblSube.Location = new System.Drawing.Point(528, 344);
            this.lblSube.Name = "lblSube";
            this.lblSube.Size = new System.Drawing.Size(38, 13);
            this.lblSube.TabIndex = 19;
            this.lblSube.Text = "Şube :";
            // 
            // txtOgenciNo
            // 
            this.txtOgenciNo.Location = new System.Drawing.Point(528, 399);
            this.txtOgenciNo.Name = "txtOgenciNo";
            this.txtOgenciNo.ReadOnly = true;
            this.txtOgenciNo.Size = new System.Drawing.Size(100, 20);
            this.txtOgenciNo.TabIndex = 22;
            // 
            // lblOgrenciNo
            // 
            this.lblOgrenciNo.AutoSize = true;
            this.lblOgrenciNo.Location = new System.Drawing.Point(528, 383);
            this.lblOgrenciNo.Name = "lblOgrenciNo";
            this.lblOgrenciNo.Size = new System.Drawing.Size(67, 13);
            this.lblOgrenciNo.TabIndex = 21;
            this.lblOgrenciNo.Text = "Öğrenci No :";
            // 
            // txtKitapcik
            // 
            this.txtKitapcik.Location = new System.Drawing.Point(528, 438);
            this.txtKitapcik.Name = "txtKitapcik";
            this.txtKitapcik.ReadOnly = true;
            this.txtKitapcik.Size = new System.Drawing.Size(100, 20);
            this.txtKitapcik.TabIndex = 24;
            // 
            // lblOgreniNo
            // 
            this.lblOgreniNo.AutoSize = true;
            this.lblOgreniNo.Location = new System.Drawing.Point(528, 422);
            this.lblOgreniNo.Name = "lblOgreniNo";
            this.lblOgreniNo.Size = new System.Drawing.Size(51, 13);
            this.lblOgreniNo.TabIndex = 23;
            this.lblOgreniNo.Text = "Kitapçık :";
            // 
            // txtTurkce
            // 
            this.txtTurkce.Location = new System.Drawing.Point(528, 477);
            this.txtTurkce.Name = "txtTurkce";
            this.txtTurkce.ReadOnly = true;
            this.txtTurkce.Size = new System.Drawing.Size(181, 20);
            this.txtTurkce.TabIndex = 25;
            // 
            // lblTurkce
            // 
            this.lblTurkce.AutoSize = true;
            this.lblTurkce.Location = new System.Drawing.Point(528, 461);
            this.lblTurkce.Name = "lblTurkce";
            this.lblTurkce.Size = new System.Drawing.Size(87, 13);
            this.lblTurkce.TabIndex = 26;
            this.lblTurkce.Text = "Türkçe Yanıtları :";
            // 
            // lblMatematik
            // 
            this.lblMatematik.AutoSize = true;
            this.lblMatematik.Location = new System.Drawing.Point(528, 500);
            this.lblMatematik.Name = "lblMatematik";
            this.lblMatematik.Size = new System.Drawing.Size(134, 13);
            this.lblMatematik.TabIndex = 28;
            this.lblMatematik.Text = "Temel Matematik Yanıtları :";
            // 
            // txtMatematik
            // 
            this.txtMatematik.Location = new System.Drawing.Point(528, 516);
            this.txtMatematik.Name = "txtMatematik";
            this.txtMatematik.ReadOnly = true;
            this.txtMatematik.Size = new System.Drawing.Size(181, 20);
            this.txtMatematik.TabIndex = 27;
            // 
            // lblSosyal
            // 
            this.lblSosyal.AutoSize = true;
            this.lblSosyal.Location = new System.Drawing.Point(529, 539);
            this.lblSosyal.Name = "lblSosyal";
            this.lblSosyal.Size = new System.Drawing.Size(119, 13);
            this.lblSosyal.TabIndex = 30;
            this.lblSosyal.Text = "Sosyal Bilimler Yanıtları :";
            // 
            // txtSosyal
            // 
            this.txtSosyal.Location = new System.Drawing.Point(529, 555);
            this.txtSosyal.Name = "txtSosyal";
            this.txtSosyal.ReadOnly = true;
            this.txtSosyal.Size = new System.Drawing.Size(181, 20);
            this.txtSosyal.TabIndex = 29;
            // 
            // lblFen
            // 
            this.lblFen.AutoSize = true;
            this.lblFen.Location = new System.Drawing.Point(529, 578);
            this.lblFen.Name = "lblFen";
            this.lblFen.Size = new System.Drawing.Size(106, 13);
            this.lblFen.TabIndex = 32;
            this.lblFen.Text = "Fen Bilimler Yanıtları :";
            // 
            // txtFen
            // 
            this.txtFen.Location = new System.Drawing.Point(529, 594);
            this.txtFen.Name = "txtFen";
            this.txtFen.ReadOnly = true;
            this.txtFen.Size = new System.Drawing.Size(181, 20);
            this.txtFen.TabIndex = 31;
            // 
            // formOptik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 726);
            this.Controls.Add(this.lblFen);
            this.Controls.Add(this.txtFen);
            this.Controls.Add(this.lblSosyal);
            this.Controls.Add(this.txtSosyal);
            this.Controls.Add(this.lblMatematik);
            this.Controls.Add(this.txtMatematik);
            this.Controls.Add(this.lblTurkce);
            this.Controls.Add(this.txtTurkce);
            this.Controls.Add(this.txtKitapcik);
            this.Controls.Add(this.lblOgreniNo);
            this.Controls.Add(this.txtOgenciNo);
            this.Controls.Add(this.lblOgrenciNo);
            this.Controls.Add(this.txtSube);
            this.Controls.Add(this.lblSube);
            this.Controls.Add(this.txtSinifi);
            this.Controls.Add(this.lblSinifi);
            this.Controls.Add(this.txtKurumKodu);
            this.Controls.Add(this.lvlKurumKodu);
            this.Controls.Add(this.txtCepTelefoNo);
            this.Controls.Add(this.lblCepTelefonNo);
            this.Controls.Add(this.txtGSM);
            this.Controls.Add(this.lblGSM);
            this.Controls.Add(this.txtTC);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.Koordinatlar);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.btnTara);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.picOptikForm);
            this.Name = "formOptik";
            this.Text = "Optik Okuyucu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.picOptikForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picOptikForm;
        private System.Windows.Forms.Button btnForm;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnTara;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.OpenFileDialog ofOptikForm;
        private System.Windows.Forms.ListBox Koordinatlar;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.TextBox txtGSM;
        private System.Windows.Forms.Label lblGSM;
        private System.Windows.Forms.TextBox txtCepTelefoNo;
        private System.Windows.Forms.Label lblCepTelefonNo;
        private System.Windows.Forms.TextBox txtKurumKodu;
        private System.Windows.Forms.Label lvlKurumKodu;
        private System.Windows.Forms.TextBox txtSinifi;
        private System.Windows.Forms.Label lblSinifi;
        private System.Windows.Forms.TextBox txtSube;
        private System.Windows.Forms.Label lblSube;
        private System.Windows.Forms.TextBox txtOgenciNo;
        private System.Windows.Forms.Label lblOgrenciNo;
        private System.Windows.Forms.TextBox txtKitapcik;
        private System.Windows.Forms.Label lblOgreniNo;
        private System.Windows.Forms.TextBox txtTurkce;
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.Label lblMatematik;
        private System.Windows.Forms.TextBox txtMatematik;
        private System.Windows.Forms.Label lblSosyal;
        private System.Windows.Forms.TextBox txtSosyal;
        private System.Windows.Forms.Label lblFen;
        private System.Windows.Forms.TextBox txtFen;
    }
}

