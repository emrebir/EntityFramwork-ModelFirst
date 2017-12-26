namespace Win171108_EFKategoriUrunProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpbFiltre = new System.Windows.Forms.GroupBox();
            this.btnFiltrele = new System.Windows.Forms.Button();
            this.cmbKategoriFiltre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbUrundetay = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnYeniKayit = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAra = new System.Windows.Forms.Button();
            this.cmbKategoriUrun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgEkran = new System.Windows.Forms.DataGridView();
            this.UrunID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunMiktari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KategoriAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTumUrunler = new System.Windows.Forms.Button();
            this.grpbFiltre.SuspendLayout();
            this.grpbUrundetay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEkran)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbFiltre
            // 
            this.grpbFiltre.Controls.Add(this.btnTumUrunler);
            this.grpbFiltre.Controls.Add(this.btnFiltrele);
            this.grpbFiltre.Controls.Add(this.cmbKategoriFiltre);
            this.grpbFiltre.Controls.Add(this.label1);
            this.grpbFiltre.Location = new System.Drawing.Point(53, 12);
            this.grpbFiltre.Name = "grpbFiltre";
            this.grpbFiltre.Size = new System.Drawing.Size(630, 69);
            this.grpbFiltre.TabIndex = 0;
            this.grpbFiltre.TabStop = false;
            this.grpbFiltre.Text = "Filtre";
            // 
            // btnFiltrele
            // 
            this.btnFiltrele.Location = new System.Drawing.Point(391, 29);
            this.btnFiltrele.Name = "btnFiltrele";
            this.btnFiltrele.Size = new System.Drawing.Size(100, 23);
            this.btnFiltrele.TabIndex = 2;
            this.btnFiltrele.Text = "Filtrele";
            this.btnFiltrele.UseVisualStyleBackColor = true;
            this.btnFiltrele.Click += new System.EventHandler(this.btnFiltrele_Click);
            // 
            // cmbKategoriFiltre
            // 
            this.cmbKategoriFiltre.FormattingEnabled = true;
            this.cmbKategoriFiltre.Location = new System.Drawing.Point(117, 29);
            this.cmbKategoriFiltre.Name = "cmbKategoriFiltre";
            this.cmbKategoriFiltre.Size = new System.Drawing.Size(249, 21);
            this.cmbKategoriFiltre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori Seçimi";
            // 
            // grpbUrundetay
            // 
            this.grpbUrundetay.Controls.Add(this.btnSil);
            this.grpbUrundetay.Controls.Add(this.btnGuncelle);
            this.grpbUrundetay.Controls.Add(this.btnEkle);
            this.grpbUrundetay.Controls.Add(this.btnYeniKayit);
            this.grpbUrundetay.Controls.Add(this.txtMiktar);
            this.grpbUrundetay.Controls.Add(this.label5);
            this.grpbUrundetay.Controls.Add(this.txtUrunId);
            this.grpbUrundetay.Controls.Add(this.txtUrunAdi);
            this.grpbUrundetay.Controls.Add(this.label4);
            this.grpbUrundetay.Controls.Add(this.label3);
            this.grpbUrundetay.Controls.Add(this.btnAra);
            this.grpbUrundetay.Controls.Add(this.cmbKategoriUrun);
            this.grpbUrundetay.Controls.Add(this.label2);
            this.grpbUrundetay.Location = new System.Drawing.Point(53, 99);
            this.grpbUrundetay.Name = "grpbUrundetay";
            this.grpbUrundetay.Size = new System.Drawing.Size(630, 153);
            this.grpbUrundetay.TabIndex = 1;
            this.grpbUrundetay.TabStop = false;
            this.grpbUrundetay.Text = "Ürün Detay";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(539, 85);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(68, 39);
            this.btnSil.TabIndex = 12;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(465, 86);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(68, 39);
            this.btnGuncelle.TabIndex = 11;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(391, 86);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(68, 39);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnYeniKayit
            // 
            this.btnYeniKayit.Location = new System.Drawing.Point(391, 32);
            this.btnYeniKayit.Name = "btnYeniKayit";
            this.btnYeniKayit.Size = new System.Drawing.Size(216, 48);
            this.btnYeniKayit.TabIndex = 9;
            this.btnYeniKayit.Text = "Yeni Kayıt";
            this.btnYeniKayit.UseVisualStyleBackColor = true;
            this.btnYeniKayit.Click += new System.EventHandler(this.btnYeniKayit_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(296, 60);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(70, 20);
            this.txtMiktar.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Miktar";
            // 
            // txtUrunId
            // 
            this.txtUrunId.Location = new System.Drawing.Point(96, 29);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.ReadOnly = true;
            this.txtUrunId.Size = new System.Drawing.Size(64, 20);
            this.txtUrunId.TabIndex = 6;
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(96, 60);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(145, 20);
            this.txtUrunAdi.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ürün Adı";
            // 
            // btnAra
            // 
            this.btnAra.Location = new System.Drawing.Point(166, 27);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(75, 23);
            this.btnAra.TabIndex = 2;
            this.btnAra.Text = "Ara";
            this.btnAra.UseVisualStyleBackColor = true;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // cmbKategoriUrun
            // 
            this.cmbKategoriUrun.FormattingEnabled = true;
            this.cmbKategoriUrun.Location = new System.Drawing.Point(96, 95);
            this.cmbKategoriUrun.Name = "cmbKategoriUrun";
            this.cmbKategoriUrun.Size = new System.Drawing.Size(145, 21);
            this.cmbKategoriUrun.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ürün ID";
            // 
            // dgEkran
            // 
            this.dgEkran.AllowUserToAddRows = false;
            this.dgEkran.AllowUserToDeleteRows = false;
            this.dgEkran.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgEkran.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEkran.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UrunID,
            this.UrunAdi,
            this.UrunMiktari,
            this.KategoriAdi});
            this.dgEkran.Location = new System.Drawing.Point(53, 279);
            this.dgEkran.Name = "dgEkran";
            this.dgEkran.ReadOnly = true;
            this.dgEkran.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEkran.Size = new System.Drawing.Size(630, 175);
            this.dgEkran.TabIndex = 2;
            this.dgEkran.SelectionChanged += new System.EventHandler(this.dgEkran_SelectionChanged);
            // 
            // UrunID
            // 
            this.UrunID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunID.HeaderText = "Ürün ID";
            this.UrunID.Name = "UrunID";
            this.UrunID.ReadOnly = true;
            // 
            // UrunAdi
            // 
            this.UrunAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunAdi.HeaderText = "Ürün Adı";
            this.UrunAdi.Name = "UrunAdi";
            this.UrunAdi.ReadOnly = true;
            // 
            // UrunMiktari
            // 
            this.UrunMiktari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunMiktari.HeaderText = "Ürün Miktarı";
            this.UrunMiktari.Name = "UrunMiktari";
            this.UrunMiktari.ReadOnly = true;
            // 
            // KategoriAdi
            // 
            this.KategoriAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KategoriAdi.HeaderText = "Kategori Adı";
            this.KategoriAdi.Name = "KategoriAdi";
            this.KategoriAdi.ReadOnly = true;
            // 
            // btnTumUrunler
            // 
            this.btnTumUrunler.Location = new System.Drawing.Point(510, 29);
            this.btnTumUrunler.Name = "btnTumUrunler";
            this.btnTumUrunler.Size = new System.Drawing.Size(97, 23);
            this.btnTumUrunler.TabIndex = 3;
            this.btnTumUrunler.Text = "Tüm Ürünler";
            this.btnTumUrunler.UseVisualStyleBackColor = true;
            this.btnTumUrunler.Click += new System.EventHandler(this.btnTumUrunler_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(729, 472);
            this.Controls.Add(this.dgEkran);
            this.Controls.Add(this.grpbUrundetay);
            this.Controls.Add(this.grpbFiltre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmreMarkt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpbFiltre.ResumeLayout(false);
            this.grpbFiltre.PerformLayout();
            this.grpbUrundetay.ResumeLayout(false);
            this.grpbUrundetay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEkran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbFiltre;
        private System.Windows.Forms.Button btnFiltrele;
        private System.Windows.Forms.ComboBox cmbKategoriFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbUrundetay;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnYeniKayit;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.TextBox txtUrunAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.ComboBox cmbKategoriUrun;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgEkran;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunMiktari;
        private System.Windows.Forms.DataGridViewTextBoxColumn KategoriAdi;
        private System.Windows.Forms.Button btnTumUrunler;
    }
}

