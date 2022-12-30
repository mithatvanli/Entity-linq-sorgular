namespace ENTITY1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnOgrenciListele = new System.Windows.Forms.Button();
            this.BtnBul = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.BtnSil = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.LblSoyad = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.LblAd = new System.Windows.Forms.Label();
            this.TxtFoto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.LblId = new System.Windows.Forms.Label();
            this.DERSLER = new System.Windows.Forms.GroupBox();
            this.TxtDersAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDersId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSinavNotuGuncelle = new System.Windows.Forms.Button();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtDurum = new System.Windows.Forms.TextBox();
            this.LblDurum = new System.Windows.Forms.Label();
            this.TxtSinav3 = new System.Windows.Forms.TextBox();
            this.LblSinav3 = new System.Windows.Forms.Label();
            this.TxtSinav2 = new System.Windows.Forms.TextBox();
            this.LblSinav2 = new System.Windows.Forms.Label();
            this.TxtOrtalama = new System.Windows.Forms.TextBox();
            this.LblOrtalama = new System.Windows.Forms.Label();
            this.TxtSinav1 = new System.Windows.Forms.TextBox();
            this.LblSinav1 = new System.Windows.Forms.Label();
            this.BtnDersListesi = new System.Windows.Forms.Button();
            this.BtnNotListesi = new System.Windows.Forms.Button();
            this.BtnListeProcedure = new System.Windows.Forms.Button();
            this.RBtnAd = new System.Windows.Forms.RadioButton();
            this.BtnLinq = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radiobutton5 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.BtnJoin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.DERSLER.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(718, 147);
            this.dataGridView1.TabIndex = 0;
            // 
            // BtnOgrenciListele
            // 
            this.BtnOgrenciListele.Location = new System.Drawing.Point(-2, 153);
            this.BtnOgrenciListele.Name = "BtnOgrenciListele";
            this.BtnOgrenciListele.Size = new System.Drawing.Size(99, 23);
            this.BtnOgrenciListele.TabIndex = 1;
            this.BtnOgrenciListele.Text = "Öğrenci Listele";
            this.BtnOgrenciListele.UseVisualStyleBackColor = true;
            this.BtnOgrenciListele.Click += new System.EventHandler(this.BtnOgrenciListele_Click);
            // 
            // BtnBul
            // 
            this.BtnBul.Location = new System.Drawing.Point(-2, 269);
            this.BtnBul.Name = "BtnBul";
            this.BtnBul.Size = new System.Drawing.Size(99, 23);
            this.BtnBul.TabIndex = 2;
            this.BtnBul.Text = "Bul";
            this.BtnBul.UseVisualStyleBackColor = true;
            this.BtnBul.Click += new System.EventHandler(this.BtnBul_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Location = new System.Drawing.Point(-2, 240);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(99, 23);
            this.BtnGuncelle.TabIndex = 3;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Location = new System.Drawing.Point(-2, 182);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(99, 23);
            this.BtnKaydet.TabIndex = 4;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.Location = new System.Drawing.Point(-2, 211);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(99, 23);
            this.BtnSil.TabIndex = 5;
            this.BtnSil.Text = "Sil";
            this.BtnSil.UseVisualStyleBackColor = true;
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtSoyad);
            this.groupBox1.Controls.Add(this.LblSoyad);
            this.groupBox1.Controls.Add(this.TxtAd);
            this.groupBox1.Controls.Add(this.LblAd);
            this.groupBox1.Controls.Add(this.TxtFoto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.LblId);
            this.groupBox1.Location = new System.Drawing.Point(143, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 164);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÖĞRENCİ";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(154, 105);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(100, 20);
            this.TxtSoyad.TabIndex = 21;
            // 
            // LblSoyad
            // 
            this.LblSoyad.AutoSize = true;
            this.LblSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSoyad.Location = new System.Drawing.Point(70, 103);
            this.LblSoyad.Name = "LblSoyad";
            this.LblSoyad.Size = new System.Drawing.Size(71, 20);
            this.LblSoyad.TabIndex = 20;
            this.LblSoyad.Text = "SOYAD";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(154, 76);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 20);
            this.TxtAd.TabIndex = 19;
            this.TxtAd.TextChanged += new System.EventHandler(this.TxtAd_TextChanged);
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblAd.Location = new System.Drawing.Point(107, 74);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(34, 20);
            this.LblAd.TabIndex = 18;
            this.LblAd.Text = "AD";
            // 
            // TxtFoto
            // 
            this.TxtFoto.Location = new System.Drawing.Point(154, 134);
            this.TxtFoto.Name = "TxtFoto";
            this.TxtFoto.Size = new System.Drawing.Size(100, 20);
            this.TxtFoto.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(42, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "FOTOĞRAF";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(154, 45);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(100, 20);
            this.TxtId.TabIndex = 15;
            // 
            // LblId
            // 
            this.LblId.AutoSize = true;
            this.LblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblId.Location = new System.Drawing.Point(107, 45);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(28, 20);
            this.LblId.TabIndex = 14;
            this.LblId.Text = "ID";
            // 
            // DERSLER
            // 
            this.DERSLER.Controls.Add(this.TxtDersAd);
            this.DERSLER.Controls.Add(this.label3);
            this.DERSLER.Controls.Add(this.TxtDersId);
            this.DERSLER.Controls.Add(this.label5);
            this.DERSLER.Location = new System.Drawing.Point(143, 339);
            this.DERSLER.Name = "DERSLER";
            this.DERSLER.Size = new System.Drawing.Size(297, 111);
            this.DERSLER.TabIndex = 7;
            this.DERSLER.TabStop = false;
            this.DERSLER.Text = "groupBox2";
            // 
            // TxtDersAd
            // 
            this.TxtDersAd.Location = new System.Drawing.Point(154, 76);
            this.TxtDersAd.Name = "TxtDersAd";
            this.TxtDersAd.Size = new System.Drawing.Size(100, 20);
            this.TxtDersAd.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(107, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "AD";
            // 
            // TxtDersId
            // 
            this.TxtDersId.Location = new System.Drawing.Point(154, 45);
            this.TxtDersId.Name = "TxtDersId";
            this.TxtDersId.Size = new System.Drawing.Size(100, 20);
            this.TxtDersId.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(107, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSinavNotuGuncelle);
            this.groupBox3.Controls.Add(this.BtnHesapla);
            this.groupBox3.Controls.Add(this.TxtDurum);
            this.groupBox3.Controls.Add(this.LblDurum);
            this.groupBox3.Controls.Add(this.TxtSinav3);
            this.groupBox3.Controls.Add(this.LblSinav3);
            this.groupBox3.Controls.Add(this.TxtSinav2);
            this.groupBox3.Controls.Add(this.LblSinav2);
            this.groupBox3.Controls.Add(this.TxtOrtalama);
            this.groupBox3.Controls.Add(this.LblOrtalama);
            this.groupBox3.Controls.Add(this.TxtSinav1);
            this.groupBox3.Controls.Add(this.LblSinav1);
            this.groupBox3.Location = new System.Drawing.Point(456, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 281);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NOTLAR";
            // 
            // BtnSinavNotuGuncelle
            // 
            this.BtnSinavNotuGuncelle.Location = new System.Drawing.Point(111, 240);
            this.BtnSinavNotuGuncelle.Name = "BtnSinavNotuGuncelle";
            this.BtnSinavNotuGuncelle.Size = new System.Drawing.Size(142, 23);
            this.BtnSinavNotuGuncelle.TabIndex = 25;
            this.BtnSinavNotuGuncelle.Text = "Sınav Notu Güncelle";
            this.BtnSinavNotuGuncelle.UseVisualStyleBackColor = true;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(111, 211);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(143, 23);
            this.BtnHesapla.TabIndex = 24;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            // 
            // TxtDurum
            // 
            this.TxtDurum.Location = new System.Drawing.Point(154, 162);
            this.TxtDurum.Name = "TxtDurum";
            this.TxtDurum.Size = new System.Drawing.Size(100, 20);
            this.TxtDurum.TabIndex = 23;
            // 
            // LblDurum
            // 
            this.LblDurum.AutoSize = true;
            this.LblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblDurum.Location = new System.Drawing.Point(64, 162);
            this.LblDurum.Name = "LblDurum";
            this.LblDurum.Size = new System.Drawing.Size(75, 20);
            this.LblDurum.TabIndex = 22;
            this.LblDurum.Text = "DURUM";
            // 
            // TxtSinav3
            // 
            this.TxtSinav3.Location = new System.Drawing.Point(154, 105);
            this.TxtSinav3.Name = "TxtSinav3";
            this.TxtSinav3.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav3.TabIndex = 21;
            // 
            // LblSinav3
            // 
            this.LblSinav3.AutoSize = true;
            this.LblSinav3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSinav3.Location = new System.Drawing.Point(61, 105);
            this.LblSinav3.Name = "LblSinav3";
            this.LblSinav3.Size = new System.Drawing.Size(78, 20);
            this.LblSinav3.TabIndex = 20;
            this.LblSinav3.Text = "SINAV 3";
            // 
            // TxtSinav2
            // 
            this.TxtSinav2.Location = new System.Drawing.Point(154, 76);
            this.TxtSinav2.Name = "TxtSinav2";
            this.TxtSinav2.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav2.TabIndex = 19;
            // 
            // LblSinav2
            // 
            this.LblSinav2.AutoSize = true;
            this.LblSinav2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSinav2.Location = new System.Drawing.Point(61, 78);
            this.LblSinav2.Name = "LblSinav2";
            this.LblSinav2.Size = new System.Drawing.Size(78, 20);
            this.LblSinav2.TabIndex = 18;
            this.LblSinav2.Text = "SINAV 2";
            // 
            // TxtOrtalama
            // 
            this.TxtOrtalama.Location = new System.Drawing.Point(154, 136);
            this.TxtOrtalama.Name = "TxtOrtalama";
            this.TxtOrtalama.Size = new System.Drawing.Size(100, 20);
            this.TxtOrtalama.TabIndex = 17;
            // 
            // LblOrtalama
            // 
            this.LblOrtalama.AutoSize = true;
            this.LblOrtalama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblOrtalama.Location = new System.Drawing.Point(34, 136);
            this.LblOrtalama.Name = "LblOrtalama";
            this.LblOrtalama.Size = new System.Drawing.Size(105, 20);
            this.LblOrtalama.TabIndex = 16;
            this.LblOrtalama.Text = "ORTALAMA";
            // 
            // TxtSinav1
            // 
            this.TxtSinav1.Location = new System.Drawing.Point(154, 45);
            this.TxtSinav1.Name = "TxtSinav1";
            this.TxtSinav1.Size = new System.Drawing.Size(100, 20);
            this.TxtSinav1.TabIndex = 15;
            this.TxtSinav1.TextChanged += new System.EventHandler(this.TxtSinav1_TextChanged);
            // 
            // LblSinav1
            // 
            this.LblSinav1.AutoSize = true;
            this.LblSinav1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblSinav1.Location = new System.Drawing.Point(61, 47);
            this.LblSinav1.Name = "LblSinav1";
            this.LblSinav1.Size = new System.Drawing.Size(78, 20);
            this.LblSinav1.TabIndex = 14;
            this.LblSinav1.Text = "SINAV 1";
            // 
            // BtnDersListesi
            // 
            this.BtnDersListesi.Location = new System.Drawing.Point(-2, 298);
            this.BtnDersListesi.Name = "BtnDersListesi";
            this.BtnDersListesi.Size = new System.Drawing.Size(99, 23);
            this.BtnDersListesi.TabIndex = 9;
            this.BtnDersListesi.Text = "Ders Listesi";
            this.BtnDersListesi.UseVisualStyleBackColor = true;
            this.BtnDersListesi.Click += new System.EventHandler(this.BtnDersListesi_Click);
            // 
            // BtnNotListesi
            // 
            this.BtnNotListesi.Location = new System.Drawing.Point(-3, 327);
            this.BtnNotListesi.Name = "BtnNotListesi";
            this.BtnNotListesi.Size = new System.Drawing.Size(99, 23);
            this.BtnNotListesi.TabIndex = 10;
            this.BtnNotListesi.Text = "Not Listesi";
            this.BtnNotListesi.UseVisualStyleBackColor = true;
            this.BtnNotListesi.Click += new System.EventHandler(this.BtnNotListesi_Click);
            // 
            // BtnListeProcedure
            // 
            this.BtnListeProcedure.Location = new System.Drawing.Point(-3, 365);
            this.BtnListeProcedure.Name = "BtnListeProcedure";
            this.BtnListeProcedure.Size = new System.Drawing.Size(99, 23);
            this.BtnListeProcedure.TabIndex = 11;
            this.BtnListeProcedure.Text = "Prosedür Not Listesi";
            this.BtnListeProcedure.UseVisualStyleBackColor = true;
            this.BtnListeProcedure.Click += new System.EventHandler(this.BtnListeProcedure_Click);
            // 
            // RBtnAd
            // 
            this.RBtnAd.AutoSize = true;
            this.RBtnAd.Location = new System.Drawing.Point(776, 48);
            this.RBtnAd.Name = "RBtnAd";
            this.RBtnAd.Size = new System.Drawing.Size(136, 17);
            this.RBtnAd.TabIndex = 12;
            this.RBtnAd.TabStop = true;
            this.RBtnAd.Text = "Ada Göre Sıralama(A-Z)";
            this.RBtnAd.UseVisualStyleBackColor = true;
            // 
            // BtnLinq
            // 
            this.BtnLinq.Location = new System.Drawing.Point(785, 240);
            this.BtnLinq.Name = "BtnLinq";
            this.BtnLinq.Size = new System.Drawing.Size(75, 23);
            this.BtnLinq.TabIndex = 13;
            this.BtnLinq.Text = "Linq  Entity";
            this.BtnLinq.UseVisualStyleBackColor = true;
            this.BtnLinq.Click += new System.EventHandler(this.BtnLinq_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(776, 71);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(136, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Ada Göre Sıralama(Z-A)";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(776, 94);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "İlk 5 Kayıt";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radiobutton5
            // 
            this.radiobutton5.AutoSize = true;
            this.radiobutton5.Location = new System.Drawing.Point(785, 117);
            this.radiobutton5.Name = "radiobutton5";
            this.radiobutton5.Size = new System.Drawing.Size(101, 17);
            this.radiobutton5.TabIndex = 16;
            this.radiobutton5.TabStop = true;
            this.radiobutton5.Text = "A ile başlayanlar";
            this.radiobutton5.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(776, 140);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(82, 17);
            this.radioButton3.TabIndex = 17;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "A ile bitenler";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(776, 163);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(123, 17);
            this.radioButton4.TabIndex = 18;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Tabloda Veri Var mı?";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(776, 182);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(81, 17);
            this.radioButton6.TabIndex = 19;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Toplam Veri";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // BtnJoin
            // 
            this.BtnJoin.Location = new System.Drawing.Point(785, 284);
            this.BtnJoin.Name = "BtnJoin";
            this.BtnJoin.Size = new System.Drawing.Size(75, 23);
            this.BtnJoin.TabIndex = 20;
            this.BtnJoin.Text = "Linq Join";
            this.BtnJoin.UseVisualStyleBackColor = true;
            this.BtnJoin.Click += new System.EventHandler(this.BtnJoin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 450);
            this.Controls.Add(this.BtnJoin);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radiobutton5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.BtnLinq);
            this.Controls.Add(this.RBtnAd);
            this.Controls.Add(this.BtnListeProcedure);
            this.Controls.Add(this.BtnNotListesi);
            this.Controls.Add(this.BtnDersListesi);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.DERSLER);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnSil);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.BtnBul);
            this.Controls.Add(this.BtnOgrenciListele);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DERSLER.ResumeLayout(false);
            this.DERSLER.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnOgrenciListele;
        private System.Windows.Forms.Button BtnBul;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.Button BtnSil;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.Label LblSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.TextBox TxtFoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.GroupBox DERSLER;
        private System.Windows.Forms.TextBox TxtDersAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDersId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtDurum;
        private System.Windows.Forms.Label LblDurum;
        private System.Windows.Forms.TextBox TxtSinav3;
        private System.Windows.Forms.Label LblSinav3;
        private System.Windows.Forms.TextBox TxtSinav2;
        private System.Windows.Forms.Label LblSinav2;
        private System.Windows.Forms.TextBox TxtOrtalama;
        private System.Windows.Forms.Label LblOrtalama;
        private System.Windows.Forms.TextBox TxtSinav1;
        private System.Windows.Forms.Label LblSinav1;
        private System.Windows.Forms.Button BtnDersListesi;
        private System.Windows.Forms.Button BtnNotListesi;
        private System.Windows.Forms.Button BtnSinavNotuGuncelle;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Button BtnListeProcedure;
        private System.Windows.Forms.RadioButton RBtnAd;
        private System.Windows.Forms.Button BtnLinq;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radiobutton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Button BtnJoin;
    }
}

