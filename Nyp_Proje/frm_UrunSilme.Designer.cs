namespace Nyp_Proje
{
    partial class frm_UrunSilme
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
            this.btn_Sil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rctxt_Bilgiler = new System.Windows.Forms.RichTextBox();
            this.uruncmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Sil
            // 
            this.btn_Sil.Location = new System.Drawing.Point(133, 214);
            this.btn_Sil.Name = "btn_Sil";
            this.btn_Sil.Size = new System.Drawing.Size(121, 47);
            this.btn_Sil.TabIndex = 38;
            this.btn_Sil.Text = "Sil";
            this.btn_Sil.UseVisualStyleBackColor = true;
            this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "BİLGİLER";
            // 
            // rctxt_Bilgiler
            // 
            this.rctxt_Bilgiler.Location = new System.Drawing.Point(399, 117);
            this.rctxt_Bilgiler.Name = "rctxt_Bilgiler";
            this.rctxt_Bilgiler.Size = new System.Drawing.Size(276, 177);
            this.rctxt_Bilgiler.TabIndex = 36;
            this.rctxt_Bilgiler.Text = "";
            // 
            // uruncmb
            // 
            this.uruncmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uruncmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uruncmb.FormattingEnabled = true;
            this.uruncmb.Location = new System.Drawing.Point(158, 76);
            this.uruncmb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uruncmb.Name = "uruncmb";
            this.uruncmb.Size = new System.Drawing.Size(178, 37);
            this.uruncmb.TabIndex = 35;
            this.uruncmb.SelectedIndexChanged += new System.EventHandler(this.uruncmb_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(54, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 34;
            this.label1.Text = "ÜRÜN :";
            // 
            // frm_UrunSilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Sil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rctxt_Bilgiler);
            this.Controls.Add(this.uruncmb);
            this.Controls.Add(this.label1);
            this.Name = "frm_UrunSilme";
            this.Text = "Urun Silme";
            this.Load += new System.EventHandler(this.frm_UrunSilme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Sil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rctxt_Bilgiler;
        private System.Windows.Forms.ComboBox uruncmb;
        private System.Windows.Forms.Label label1;
    }
}