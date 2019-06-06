namespace OptikOkuyucu
{
    partial class frmCevap
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
            this.lblKitap = new System.Windows.Forms.Label();
            this.lblSinavKodu = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtSinavKodu = new System.Windows.Forms.TextBox();
            this.comboKitap = new System.Windows.Forms.ComboBox();
            this.txtCvpTR = new System.Windows.Forms.TextBox();
            this.txtCvpMAT = new System.Windows.Forms.TextBox();
            this.txtCvpSOS = new System.Windows.Forms.TextBox();
            this.txtCvpFEN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblUyarı = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKitap
            // 
            this.lblKitap.AutoSize = true;
            this.lblKitap.Location = new System.Drawing.Point(9, 43);
            this.lblKitap.Name = "lblKitap";
            this.lblKitap.Size = new System.Drawing.Size(76, 13);
            this.lblKitap.TabIndex = 74;
            this.lblKitap.Text = "Kitapçık Türü :";
            // 
            // lblSinavKodu
            // 
            this.lblSinavKodu.AutoSize = true;
            this.lblSinavKodu.Location = new System.Drawing.Point(88, 18);
            this.lblSinavKodu.Name = "lblSinavKodu";
            this.lblSinavKodu.Size = new System.Drawing.Size(68, 13);
            this.lblSinavKodu.TabIndex = 73;
            this.lblSinavKodu.Text = "Sınav Kodu :";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(12, 12);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 72;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtSinavKodu
            // 
            this.txtSinavKodu.Location = new System.Drawing.Point(162, 14);
            this.txtSinavKodu.MaxLength = 10;
            this.txtSinavKodu.Name = "txtSinavKodu";
            this.txtSinavKodu.Size = new System.Drawing.Size(154, 20);
            this.txtSinavKodu.TabIndex = 71;
            this.txtSinavKodu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSinavKodu_KeyPress);
            // 
            // comboKitap
            // 
            this.comboKitap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboKitap.FormattingEnabled = true;
            this.comboKitap.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboKitap.Location = new System.Drawing.Point(91, 40);
            this.comboKitap.Name = "comboKitap";
            this.comboKitap.Size = new System.Drawing.Size(225, 21);
            this.comboKitap.TabIndex = 69;
            // 
            // txtCvpTR
            // 
            this.txtCvpTR.Location = new System.Drawing.Point(91, 67);
            this.txtCvpTR.MaxLength = 40;
            this.txtCvpTR.Name = "txtCvpTR";
            this.txtCvpTR.Size = new System.Drawing.Size(340, 20);
            this.txtCvpTR.TabIndex = 76;
            this.txtCvpTR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvpTR_KeyPress);
            // 
            // txtCvpMAT
            // 
            this.txtCvpMAT.Location = new System.Drawing.Point(91, 93);
            this.txtCvpMAT.MaxLength = 40;
            this.txtCvpMAT.Name = "txtCvpMAT";
            this.txtCvpMAT.Size = new System.Drawing.Size(340, 20);
            this.txtCvpMAT.TabIndex = 77;
            this.txtCvpMAT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvpMAT_KeyPress);
            // 
            // txtCvpSOS
            // 
            this.txtCvpSOS.Location = new System.Drawing.Point(91, 119);
            this.txtCvpSOS.MaxLength = 40;
            this.txtCvpSOS.Name = "txtCvpSOS";
            this.txtCvpSOS.Size = new System.Drawing.Size(340, 20);
            this.txtCvpSOS.TabIndex = 78;
            this.txtCvpSOS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvpSOS_KeyPress);
            // 
            // txtCvpFEN
            // 
            this.txtCvpFEN.Location = new System.Drawing.Point(91, 145);
            this.txtCvpFEN.MaxLength = 40;
            this.txtCvpFEN.Name = "txtCvpFEN";
            this.txtCvpFEN.Size = new System.Drawing.Size(340, 20);
            this.txtCvpFEN.TabIndex = 79;
            this.txtCvpFEN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCvpFEN_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 80;
            this.label1.Text = "Türkçe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 81;
            this.label2.Text = "Matematik :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Sosyal :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 83;
            this.label4.Text = "Fen :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 239);
            this.dataGridView1.TabIndex = 84;
            // 
            // lblUyarı
            // 
            this.lblUyarı.Location = new System.Drawing.Point(322, 14);
            this.lblUyarı.Name = "lblUyarı";
            this.lblUyarı.Size = new System.Drawing.Size(109, 47);
            this.lblUyarı.TabIndex = 85;
            this.lblUyarı.Text = "Uyarı";
            this.lblUyarı.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCevap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 422);
            this.Controls.Add(this.lblUyarı);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCvpFEN);
            this.Controls.Add(this.txtCvpSOS);
            this.Controls.Add(this.txtCvpMAT);
            this.Controls.Add(this.txtCvpTR);
            this.Controls.Add(this.lblKitap);
            this.Controls.Add(this.lblSinavKodu);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSinavKodu);
            this.Controls.Add(this.comboKitap);
            this.MaximizeBox = false;
            this.Name = "frmCevap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cevap Anahtarı";
            this.Load += new System.EventHandler(this.frmCevap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKitap;
        private System.Windows.Forms.Label lblSinavKodu;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtSinavKodu;
        private System.Windows.Forms.ComboBox comboKitap;
        private System.Windows.Forms.TextBox txtCvpTR;
        private System.Windows.Forms.TextBox txtCvpMAT;
        private System.Windows.Forms.TextBox txtCvpSOS;
        private System.Windows.Forms.TextBox txtCvpFEN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblUyarı;
    }
}