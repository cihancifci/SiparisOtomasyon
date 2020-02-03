namespace Nyp_Proje
{
    partial class AnaSayfaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.kullanıcıadtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.parolatext = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rdo_admin = new System.Windows.Forms.RadioButton();
            this.rdo_musteri = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // kullanıcıadtext
            // 
            this.kullanıcıadtext.Location = new System.Drawing.Point(246, 123);
            this.kullanıcıadtext.Name = "kullanıcıadtext";
            this.kullanıcıadtext.Size = new System.Drawing.Size(147, 32);
            this.kullanıcıadtext.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Parola :";
            // 
            // parolatext
            // 
            this.parolatext.Location = new System.Drawing.Point(246, 161);
            this.parolatext.Name = "parolatext";
            this.parolatext.Size = new System.Drawing.Size(147, 32);
            this.parolatext.TabIndex = 3;
            this.parolatext.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "Giriş ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rdo_admin
            // 
            this.rdo_admin.AutoSize = true;
            this.rdo_admin.Location = new System.Drawing.Point(132, 58);
            this.rdo_admin.Name = "rdo_admin";
            this.rdo_admin.Size = new System.Drawing.Size(87, 28);
            this.rdo_admin.TabIndex = 6;
            this.rdo_admin.TabStop = true;
            this.rdo_admin.Text = "Admin";
            this.rdo_admin.UseVisualStyleBackColor = true;
            // 
            // rdo_musteri
            // 
            this.rdo_musteri.AutoSize = true;
            this.rdo_musteri.Location = new System.Drawing.Point(263, 58);
            this.rdo_musteri.Name = "rdo_musteri";
            this.rdo_musteri.Size = new System.Drawing.Size(96, 28);
            this.rdo_musteri.TabIndex = 7;
            this.rdo_musteri.TabStop = true;
            this.rdo_musteri.Text = "Müşteri";
            this.rdo_musteri.UseVisualStyleBackColor = true;
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 389);
            this.Controls.Add(this.rdo_musteri);
            this.Controls.Add(this.rdo_admin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.parolatext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kullanıcıadtext);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaSayfaForm";
            this.Text = "Giriş";
            this.Load += new System.EventHandler(this.AnaSayfaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox kullanıcıadtext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox parolatext;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rdo_admin;
        private System.Windows.Forms.RadioButton rdo_musteri;
    }
}

