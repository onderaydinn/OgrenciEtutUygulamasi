namespace EtutTest
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CmbDers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MskTarih = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MskSaat = new System.Windows.Forms.MaskedTextBox();
            this.CmbOgretmen = new System.Windows.Forms.ComboBox();
            this.BtnEtutOlustur = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnEtutVer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TxtOgrenciid = new System.Windows.Forms.TextBox();
            this.TxtEtutid = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtSinif = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtDers = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnFotograf = new System.Windows.Forms.Button();
            this.TxtOgretmenSoyad = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtOgretmenAd = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.CmbDersAdi = new System.Windows.Forms.ComboBox();
            this.BtnOgretmenKaydet = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnEtutOlustur);
            this.groupBox1.Controls.Add(this.CmbOgretmen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.MskSaat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.MskTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.CmbDers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 280);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // CmbDers
            // 
            this.CmbDers.FormattingEnabled = true;
            this.CmbDers.Location = new System.Drawing.Point(102, 41);
            this.CmbDers.Name = "CmbDers";
            this.CmbDers.Size = new System.Drawing.Size(145, 26);
            this.CmbDers.TabIndex = 0;
            this.CmbDers.SelectedIndexChanged += new System.EventHandler(this.CmbDers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ders:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Öğretmen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tarih:";
            // 
            // MskTarih
            // 
            this.MskTarih.Location = new System.Drawing.Point(102, 122);
            this.MskTarih.Mask = "00/00/0000";
            this.MskTarih.Name = "MskTarih";
            this.MskTarih.Size = new System.Drawing.Size(145, 25);
            this.MskTarih.TabIndex = 4;
            this.MskTarih.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saat:";
            // 
            // MskSaat
            // 
            this.MskSaat.Location = new System.Drawing.Point(102, 162);
            this.MskSaat.Mask = "00:00";
            this.MskSaat.Name = "MskSaat";
            this.MskSaat.Size = new System.Drawing.Size(145, 25);
            this.MskSaat.TabIndex = 6;
            this.MskSaat.ValidatingType = typeof(System.DateTime);
            // 
            // CmbOgretmen
            // 
            this.CmbOgretmen.FormattingEnabled = true;
            this.CmbOgretmen.Location = new System.Drawing.Point(102, 82);
            this.CmbOgretmen.Name = "CmbOgretmen";
            this.CmbOgretmen.Size = new System.Drawing.Size(145, 26);
            this.CmbOgretmen.TabIndex = 8;
            // 
            // BtnEtutOlustur
            // 
            this.BtnEtutOlustur.Location = new System.Drawing.Point(102, 193);
            this.BtnEtutOlustur.Name = "BtnEtutOlustur";
            this.BtnEtutOlustur.Size = new System.Drawing.Size(145, 26);
            this.BtnEtutOlustur.TabIndex = 9;
            this.BtnEtutOlustur.Text = "Etüt Oluştur";
            this.BtnEtutOlustur.UseVisualStyleBackColor = true;
            this.BtnEtutOlustur.Click += new System.EventHandler(this.BtnEtutOlustur_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtEtutid);
            this.groupBox2.Controls.Add(this.TxtOgrenciid);
            this.groupBox2.Controls.Add(this.BtnEtutVer);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(339, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 179);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // BtnEtutVer
            // 
            this.BtnEtutVer.Location = new System.Drawing.Point(85, 117);
            this.BtnEtutVer.Name = "BtnEtutVer";
            this.BtnEtutVer.Size = new System.Drawing.Size(145, 26);
            this.BtnEtutVer.TabIndex = 9;
            this.BtnEtutVer.Text = "Etüt Ver";
            this.BtnEtutVer.UseVisualStyleBackColor = true;
            this.BtnEtutVer.Click += new System.EventHandler(this.BtnEtutVer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Öğrenci:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Etüt ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(12, 285);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 191);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // TxtOgrenciid
            // 
            this.TxtOgrenciid.Location = new System.Drawing.Point(85, 70);
            this.TxtOgrenciid.Name = "TxtOgrenciid";
            this.TxtOgrenciid.Size = new System.Drawing.Size(149, 25);
            this.TxtOgrenciid.TabIndex = 13;
            // 
            // TxtEtutid
            // 
            this.TxtEtutid.Location = new System.Drawing.Point(85, 37);
            this.TxtEtutid.Name = "TxtEtutid";
            this.TxtEtutid.Size = new System.Drawing.Size(149, 25);
            this.TxtEtutid.TabIndex = 14;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.MskTelefon);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.TxtMail);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TxtSinif);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.TxtSoyad);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.TxtAd);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(653, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 279);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BtnFotograf);
            this.groupBox5.Controls.Add(this.pictureBox1);
            this.groupBox5.Location = new System.Drawing.Point(871, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 226);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BtnOgretmenKaydet);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.CmbDersAdi);
            this.groupBox6.Controls.Add(this.TxtOgretmenSoyad);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.TxtOgretmenAd);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(871, 244);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(227, 232);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ad:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(57, 37);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(149, 25);
            this.TxtAd.TabIndex = 15;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(57, 73);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(149, 25);
            this.TxtSoyad.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 16;
            this.label6.Text = "Soyad:";
            // 
            // TxtSinif
            // 
            this.TxtSinif.Location = new System.Drawing.Point(57, 113);
            this.TxtSinif.Name = "TxtSinif";
            this.TxtSinif.Size = new System.Drawing.Size(149, 25);
            this.TxtSinif.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sınıf:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Telefon:";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(57, 192);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(149, 25);
            this.TxtMail.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Mail:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 26);
            this.button1.TabIndex = 10;
            this.button1.Text = "Öğrenci Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(57, 150);
            this.MskTelefon.Mask = "00:00";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(148, 25);
            this.MskTelefon.TabIndex = 10;
            this.MskTelefon.ValidatingType = typeof(System.DateTime);
            // 
            // TxtDers
            // 
            this.TxtDers.Location = new System.Drawing.Point(76, 44);
            this.TxtDers.Name = "TxtDers";
            this.TxtDers.Size = new System.Drawing.Size(134, 25);
            this.TxtDers.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Ders Adı:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(216, 44);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(79, 25);
            this.button4.TabIndex = 15;
            this.button4.Text = "Ders Ekle";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnFotograf
            // 
            this.BtnFotograf.Location = new System.Drawing.Point(44, 181);
            this.BtnFotograf.Name = "BtnFotograf";
            this.BtnFotograf.Size = new System.Drawing.Size(145, 26);
            this.BtnFotograf.TabIndex = 10;
            this.BtnFotograf.Text = "Fotoğraf Yükle";
            this.BtnFotograf.UseVisualStyleBackColor = true;
            this.BtnFotograf.Click += new System.EventHandler(this.BtnFotograf_Click);
            // 
            // TxtOgretmenSoyad
            // 
            this.TxtOgretmenSoyad.Location = new System.Drawing.Point(58, 68);
            this.TxtOgretmenSoyad.Name = "TxtOgretmenSoyad";
            this.TxtOgretmenSoyad.Size = new System.Drawing.Size(149, 25);
            this.TxtOgretmenSoyad.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Soyad:";
            // 
            // TxtOgretmenAd
            // 
            this.TxtOgretmenAd.BackColor = System.Drawing.Color.White;
            this.TxtOgretmenAd.Location = new System.Drawing.Point(58, 32);
            this.TxtOgretmenAd.Name = "TxtOgretmenAd";
            this.TxtOgretmenAd.Size = new System.Drawing.Size(149, 25);
            this.TxtOgretmenAd.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 18);
            this.label14.TabIndex = 18;
            this.label14.Text = "Ad:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 18);
            this.label15.TabIndex = 23;
            this.label15.Text = "Ders:";
            // 
            // CmbDersAdi
            // 
            this.CmbDersAdi.FormattingEnabled = true;
            this.CmbDersAdi.Location = new System.Drawing.Point(58, 101);
            this.CmbDersAdi.Name = "CmbDersAdi";
            this.CmbDersAdi.Size = new System.Drawing.Size(149, 26);
            this.CmbDersAdi.TabIndex = 22;
            // 
            // BtnOgretmenKaydet
            // 
            this.BtnOgretmenKaydet.Location = new System.Drawing.Point(55, 150);
            this.BtnOgretmenKaydet.Name = "BtnOgretmenKaydet";
            this.BtnOgretmenKaydet.Size = new System.Drawing.Size(145, 26);
            this.BtnOgretmenKaydet.TabIndex = 11;
            this.BtnOgretmenKaydet.Text = "Öğretmen Ekle";
            this.BtnOgretmenKaydet.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.TxtDers);
            this.groupBox7.Location = new System.Drawing.Point(339, 197);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(302, 95);
            this.groupBox7.TabIndex = 20;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 696);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CmbDers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnEtutOlustur;
        private System.Windows.Forms.ComboBox CmbOgretmen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox MskSaat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox MskTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnEtutVer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TxtOgrenciid;
        private System.Windows.Forms.TextBox TxtEtutid;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtSinif;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button BtnFotograf;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BtnOgretmenKaydet;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox CmbDersAdi;
        private System.Windows.Forms.TextBox TxtOgretmenSoyad;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtOgretmenAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtDers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox7;
    }
}

