namespace Nyp_Proje
{
    partial class KullanıcıForm
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
            this.btn_StokGoruntule = new System.Windows.Forms.Button();
            this.btn_StokEkle = new System.Windows.Forms.Button();
            this.btn_StokDus = new System.Windows.Forms.Button();
            this.btn_Guncelle = new System.Windows.Forms.Button();
            this.btn_SonSiparis = new System.Windows.Forms.Button();
            this.btn_UrunEkle = new System.Windows.Forms.Button();
            this.btn_UrunSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_StokGoruntule
            // 
            this.btn_StokGoruntule.Location = new System.Drawing.Point(42, 49);
            this.btn_StokGoruntule.Name = "btn_StokGoruntule";
            this.btn_StokGoruntule.Size = new System.Drawing.Size(191, 60);
            this.btn_StokGoruntule.TabIndex = 0;
            this.btn_StokGoruntule.Text = "STOK SAYISI GÖRÜNTÜLE";
            this.btn_StokGoruntule.UseVisualStyleBackColor = true;
            this.btn_StokGoruntule.Click += new System.EventHandler(this.btn_StokGoruntule_Click);
            // 
            // btn_StokEkle
            // 
            this.btn_StokEkle.Location = new System.Drawing.Point(288, 49);
            this.btn_StokEkle.Name = "btn_StokEkle";
            this.btn_StokEkle.Size = new System.Drawing.Size(191, 60);
            this.btn_StokEkle.TabIndex = 1;
            this.btn_StokEkle.Text = "STOK EKLE";
            this.btn_StokEkle.UseVisualStyleBackColor = true;
            this.btn_StokEkle.Click += new System.EventHandler(this.btn_StokEkle_Click);
            // 
            // btn_StokDus
            // 
            this.btn_StokDus.Location = new System.Drawing.Point(42, 172);
            this.btn_StokDus.Name = "btn_StokDus";
            this.btn_StokDus.Size = new System.Drawing.Size(191, 60);
            this.btn_StokDus.TabIndex = 2;
            this.btn_StokDus.Text = "STOK DÜŞÜR";
            this.btn_StokDus.UseVisualStyleBackColor = true;
            this.btn_StokDus.Click += new System.EventHandler(this.btn_StokDus_Click);
            // 
            // btn_Guncelle
            // 
            this.btn_Guncelle.Location = new System.Drawing.Point(288, 172);
            this.btn_Guncelle.Name = "btn_Guncelle";
            this.btn_Guncelle.Size = new System.Drawing.Size(191, 60);
            this.btn_Guncelle.TabIndex = 3;
            this.btn_Guncelle.Text = "ÜRÜN BİLGİLERİNİ GÜNCELLE";
            this.btn_Guncelle.UseVisualStyleBackColor = true;
            this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
            // 
            // btn_SonSiparis
            // 
            this.btn_SonSiparis.Location = new System.Drawing.Point(42, 288);
            this.btn_SonSiparis.Name = "btn_SonSiparis";
            this.btn_SonSiparis.Size = new System.Drawing.Size(191, 60);
            this.btn_SonSiparis.TabIndex = 4;
            this.btn_SonSiparis.Text = "SON SİPARİŞLERİ GÖRÜNTÜLE";
            this.btn_SonSiparis.UseVisualStyleBackColor = true;
            this.btn_SonSiparis.Click += new System.EventHandler(this.btn_SonSiparis_Click);
            // 
            // btn_UrunEkle
            // 
            this.btn_UrunEkle.Location = new System.Drawing.Point(288, 288);
            this.btn_UrunEkle.Name = "btn_UrunEkle";
            this.btn_UrunEkle.Size = new System.Drawing.Size(191, 60);
            this.btn_UrunEkle.TabIndex = 5;
            this.btn_UrunEkle.Text = "ÜRÜN EKLE";
            this.btn_UrunEkle.UseVisualStyleBackColor = true;
            this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
            // 
            // btn_UrunSil
            // 
            this.btn_UrunSil.Location = new System.Drawing.Point(42, 418);
            this.btn_UrunSil.Name = "btn_UrunSil";
            this.btn_UrunSil.Size = new System.Drawing.Size(191, 60);
            this.btn_UrunSil.TabIndex = 6;
            this.btn_UrunSil.Text = "ÜRÜN SİL";
            this.btn_UrunSil.UseVisualStyleBackColor = true;
            this.btn_UrunSil.Click += new System.EventHandler(this.btn_UrunSil_Click);
            // 
            // KullanıcıForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 565);
            this.Controls.Add(this.btn_UrunSil);
            this.Controls.Add(this.btn_UrunEkle);
            this.Controls.Add(this.btn_SonSiparis);
            this.Controls.Add(this.btn_Guncelle);
            this.Controls.Add(this.btn_StokDus);
            this.Controls.Add(this.btn_StokEkle);
            this.Controls.Add(this.btn_StokGoruntule);
            this.Name = "KullanıcıForm";
            this.Text = "Admin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_StokGoruntule;
        private System.Windows.Forms.Button btn_StokEkle;
        private System.Windows.Forms.Button btn_StokDus;
        private System.Windows.Forms.Button btn_Guncelle;
        private System.Windows.Forms.Button btn_SonSiparis;
        private System.Windows.Forms.Button btn_UrunEkle;
        private System.Windows.Forms.Button btn_UrunSil;
    }
}