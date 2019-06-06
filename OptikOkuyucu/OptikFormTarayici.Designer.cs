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
            this.components = new System.ComponentModel.Container();
            this.picOptikForm = new System.Windows.Forms.PictureBox();
            this.btnForm = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnTara = new System.Windows.Forms.Button();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.ofOptikForm = new System.Windows.Forms.OpenFileDialog();
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
            this.lblTurkce = new System.Windows.Forms.Label();
            this.lblMatematik = new System.Windows.Forms.Label();
            this.lblSosyal = new System.Windows.Forms.Label();
            this.lblFen = new System.Windows.Forms.Label();
            this.btKlasor = new System.Windows.Forms.Button();
            this.ofKlasor = new System.Windows.Forms.FolderBrowserDialog();
            this.listboxFormlar = new System.Windows.Forms.ListBox();
            this.btnFTara = new System.Windows.Forms.Button();
            this.btnCvp = new System.Windows.Forms.Button();
            this.progbarYukleniyor = new System.Windows.Forms.ProgressBar();
            this.txtCvpTR = new System.Windows.Forms.TextBox();
            this.txtCvpMAT = new System.Windows.Forms.TextBox();
            this.txtCvpSOS = new System.Windows.Forms.TextBox();
            this.txtCvpFEN = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOptikForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // picOptikForm
            // 
            this.picOptikForm.Location = new System.Drawing.Point(12, 12);
            this.picOptikForm.Name = "picOptikForm";
            this.picOptikForm.Size = new System.Drawing.Size(510, 702);
            this.picOptikForm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOptikForm.TabIndex = 0;
            this.picOptikForm.TabStop = false;
            this.picOptikForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picOptikForm_MouseMove);
            // 
            // btnForm
            // 
            this.btnForm.Location = new System.Drawing.Point(634, 12);
            this.btnForm.Name = "btnForm";
            this.btnForm.Size = new System.Drawing.Size(100, 56);
            this.btnForm.TabIndex = 1;
            this.btnForm.Text = "Form Seç";
            this.btnForm.UseVisualStyleBackColor = true;
            this.btnForm.Click += new System.EventHandler(this.btnForm_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Enabled = false;
            this.btnTemizle.Location = new System.Drawing.Point(528, 12);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 56);
            this.btnTemizle.TabIndex = 2;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnTara
            // 
            this.btnTara.Location = new System.Drawing.Point(740, 12);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(103, 56);
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
            this.ofOptikForm.FileName = "deneme";
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
            // lblSosyal
            // 
            this.lblSosyal.AutoSize = true;
            this.lblSosyal.Location = new System.Drawing.Point(529, 539);
            this.lblSosyal.Name = "lblSosyal";
            this.lblSosyal.Size = new System.Drawing.Size(119, 13);
            this.lblSosyal.TabIndex = 30;
            this.lblSosyal.Text = "Sosyal Bilimler Yanıtları :";
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
            // btKlasor
            // 
            this.btKlasor.Enabled = false;
            this.btKlasor.Location = new System.Drawing.Point(634, 74);
            this.btKlasor.Name = "btKlasor";
            this.btKlasor.Size = new System.Drawing.Size(101, 56);
            this.btKlasor.TabIndex = 33;
            this.btKlasor.Text = "Klasör Seç";
            this.btKlasor.UseVisualStyleBackColor = true;
            this.btKlasor.Click += new System.EventHandler(this.btKlasor_Click);
            // 
            // ofKlasor
            // 
            this.ofKlasor.SelectedPath = "C:\\Documents and Settings\\user\\Desktop";
            // 
            // listboxFormlar
            // 
            this.listboxFormlar.Enabled = false;
            this.listboxFormlar.FormattingEnabled = true;
            this.listboxFormlar.Location = new System.Drawing.Point(529, 620);
            this.listboxFormlar.Name = "listboxFormlar";
            this.listboxFormlar.Size = new System.Drawing.Size(311, 95);
            this.listboxFormlar.TabIndex = 59;
            // 
            // btnFTara
            // 
            this.btnFTara.Enabled = false;
            this.btnFTara.Location = new System.Drawing.Point(740, 74);
            this.btnFTara.Name = "btnFTara";
            this.btnFTara.Size = new System.Drawing.Size(103, 56);
            this.btnFTara.TabIndex = 60;
            this.btnFTara.Text = "Formları Tara";
            this.btnFTara.UseVisualStyleBackColor = true;
            this.btnFTara.Click += new System.EventHandler(this.btnFTara_Click);
            // 
            // btnCvp
            // 
            this.btnCvp.Location = new System.Drawing.Point(634, 139);
            this.btnCvp.Name = "btnCvp";
            this.btnCvp.Size = new System.Drawing.Size(209, 23);
            this.btnCvp.TabIndex = 61;
            this.btnCvp.Text = "Cevap Anahtarı";
            this.btnCvp.UseVisualStyleBackColor = true;
            this.btnCvp.Click += new System.EventHandler(this.btnCvp_Click);
            // 
            // progbarYukleniyor
            // 
            this.progbarYukleniyor.Location = new System.Drawing.Point(634, 168);
            this.progbarYukleniyor.Name = "progbarYukleniyor";
            this.progbarYukleniyor.Size = new System.Drawing.Size(209, 23);
            this.progbarYukleniyor.TabIndex = 66;
            // 
            // txtCvpTR
            // 
            this.txtCvpTR.Location = new System.Drawing.Point(528, 477);
            this.txtCvpTR.Name = "txtCvpTR";
            this.txtCvpTR.ReadOnly = true;
            this.txtCvpTR.Size = new System.Drawing.Size(312, 20);
            this.txtCvpTR.TabIndex = 68;
            // 
            // txtCvpMAT
            // 
            this.txtCvpMAT.Location = new System.Drawing.Point(528, 516);
            this.txtCvpMAT.Name = "txtCvpMAT";
            this.txtCvpMAT.ReadOnly = true;
            this.txtCvpMAT.Size = new System.Drawing.Size(312, 20);
            this.txtCvpMAT.TabIndex = 69;
            // 
            // txtCvpSOS
            // 
            this.txtCvpSOS.Location = new System.Drawing.Point(531, 555);
            this.txtCvpSOS.Name = "txtCvpSOS";
            this.txtCvpSOS.ReadOnly = true;
            this.txtCvpSOS.Size = new System.Drawing.Size(312, 20);
            this.txtCvpSOS.TabIndex = 70;
            // 
            // txtCvpFEN
            // 
            this.txtCvpFEN.Location = new System.Drawing.Point(531, 593);
            this.txtCvpFEN.Name = "txtCvpFEN";
            this.txtCvpFEN.ReadOnly = true;
            this.txtCvpFEN.Size = new System.Drawing.Size(312, 20);
            this.txtCvpFEN.TabIndex = 71;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(634, 204);
            this.textBox5.MaxLength = 40;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(209, 20);
            this.textBox5.TabIndex = 72;
            this.textBox5.Text = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA" +
                "AAAAAAAAAAAAAAAAAAAA";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 230);
            this.textBox1.MaxLength = 40;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 20);
            this.textBox1.TabIndex = 73;
            this.textBox1.Text = "BBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBBB";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(634, 256);
            this.textBox2.MaxLength = 40;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 20);
            this.textBox2.TabIndex = 74;
            this.textBox2.Text = "CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(634, 282);
            this.textBox3.MaxLength = 40;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(209, 20);
            this.textBox3.TabIndex = 75;
            this.textBox3.Text = "DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(696, 423);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(87, 20);
            this.numericUpDown1.TabIndex = 77;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 21);
            this.button1.TabIndex = 78;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button1_KeyPress);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(696, 451);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(147, 20);
            this.textBox4.TabIndex = 79;
            // 
            // formOptik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 727);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtCvpFEN);
            this.Controls.Add(this.txtCvpSOS);
            this.Controls.Add(this.txtCvpMAT);
            this.Controls.Add(this.txtCvpTR);
            this.Controls.Add(this.progbarYukleniyor);
            this.Controls.Add(this.btnCvp);
            this.Controls.Add(this.btnFTara);
            this.Controls.Add(this.listboxFormlar);
            this.Controls.Add(this.btKlasor);
            this.Controls.Add(this.lblFen);
            this.Controls.Add(this.lblSosyal);
            this.Controls.Add(this.lblMatematik);
            this.Controls.Add(this.lblTurkce);
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
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.btnTara);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnForm);
            this.Controls.Add(this.picOptikForm);
            this.MaximizeBox = false;
            this.Name = "formOptik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optik Okuyucu (MeTeM)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.formOptik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picOptikForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.Label lblTurkce;
        private System.Windows.Forms.Label lblMatematik;
        private System.Windows.Forms.Label lblSosyal;
        private System.Windows.Forms.Label lblFen;
        private System.Windows.Forms.Button btKlasor;
        private System.Windows.Forms.FolderBrowserDialog ofKlasor;
        private System.Windows.Forms.ListBox listboxFormlar;
        private System.Windows.Forms.Button btnFTara;
        private System.Windows.Forms.Button btnCvp;
        private System.Windows.Forms.ProgressBar progbarYukleniyor;
        private System.Windows.Forms.TextBox txtCvpTR;
        private System.Windows.Forms.TextBox txtCvpMAT;
        private System.Windows.Forms.TextBox txtCvpSOS;
        private System.Windows.Forms.TextBox txtCvpFEN;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
    }
}

