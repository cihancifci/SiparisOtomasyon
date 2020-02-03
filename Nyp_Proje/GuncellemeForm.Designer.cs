namespace Nyp_Proje
{
    partial class GuncellemeForm
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
            this.uruncmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.fiyattext = new System.Windows.Forms.TextBox();
            this.ağırlıktext = new System.Windows.Forms.TextBox();
            this.acıklamatext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uruncmb
            // 
            this.uruncmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uruncmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uruncmb.FormattingEnabled = true;
            this.uruncmb.Location = new System.Drawing.Point(259, 71);
            this.uruncmb.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.uruncmb.Name = "uruncmb";
            this.uruncmb.Size = new System.Drawing.Size(178, 37);
            this.uruncmb.TabIndex = 18;
            this.uruncmb.SelectedIndexChanged += new System.EventHandler(this.uruncmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(155, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "ÜRÜN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(155, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 29);
            this.label3.TabIndex = 20;
            this.label3.Text = "FİYAT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 29);
            this.label2.TabIndex = 21;
            this.label2.Text = "KARGO AĞIRLIĞI :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "AÇIKLAMA :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 55);
            this.button1.TabIndex = 24;
            this.button1.Text = "GÜNCELLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(618, 107);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(276, 177);
            this.richTextBox1.TabIndex = 25;
            this.richTextBox1.Text = "";
            // 
            // fiyattext
            // 
            this.fiyattext.Location = new System.Drawing.Point(259, 124);
            this.fiyattext.Name = "fiyattext";
            this.fiyattext.Size = new System.Drawing.Size(100, 34);
            this.fiyattext.TabIndex = 26;
            // 
            // ağırlıktext
            // 
            this.ağırlıktext.Location = new System.Drawing.Point(259, 174);
            this.ağırlıktext.Name = "ağırlıktext";
            this.ağırlıktext.Size = new System.Drawing.Size(100, 34);
            this.ağırlıktext.TabIndex = 27;
            // 
            // acıklamatext
            // 
            this.acıklamatext.Location = new System.Drawing.Point(259, 224);
            this.acıklamatext.Multiline = true;
            this.acıklamatext.Name = "acıklamatext";
            this.acıklamatext.Size = new System.Drawing.Size(283, 83);
            this.acıklamatext.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(178, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "ESKİ BİLGİLER";
            // 
            // GuncellemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 448);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.acıklamatext);
            this.Controls.Add(this.ağırlıktext);
            this.Controls.Add(this.fiyattext);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uruncmb);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "GuncellemeForm";
            this.Text = "Guncelleme";
            this.Load += new System.EventHandler(this.GuncellemeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox uruncmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox fiyattext;
        private System.Windows.Forms.TextBox ağırlıktext;
        private System.Windows.Forms.TextBox acıklamatext;
        private System.Windows.Forms.Label label5;
    }
}