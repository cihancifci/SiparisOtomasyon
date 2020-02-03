namespace Nyp_Proje
{
    partial class OdemeEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cektext1 = new System.Windows.Forms.TextBox();
            this.ceklabel1 = new System.Windows.Forms.Label();
            this.kredilabel1 = new System.Windows.Forms.Label();
            this.kredimask1 = new System.Windows.Forms.MaskedTextBox();
            this.kredicombo1 = new System.Windows.Forms.ComboBox();
            this.kredilabel2 = new System.Windows.Forms.Label();
            this.kredicombo2 = new System.Windows.Forms.ComboBox();
            this.kredilabel3 = new System.Windows.Forms.Label();
            this.kredimask2 = new System.Windows.Forms.MaskedTextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.labelücret = new System.Windows.Forms.Label();
            this.odemeturlabel1 = new System.Windows.Forms.Label();
            this.odemeturlabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "İSİM SOYİSİM :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖDEME TÜRÜ SEÇİN";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 154);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 34);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(480, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 69);
            this.button1.TabIndex = 3;
            this.button1.Text = "ÇEK İLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(647, 92);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 69);
            this.button2.TabIndex = 4;
            this.button2.Text = "KAPIDA NAKİT İLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(814, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 69);
            this.button3.TabIndex = 5;
            this.button3.Text = "KREDİ KARTI İLE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cektext1
            // 
            this.cektext1.Location = new System.Drawing.Point(228, 214);
            this.cektext1.Name = "cektext1";
            this.cektext1.Size = new System.Drawing.Size(162, 34);
            this.cektext1.TabIndex = 7;
            this.cektext1.Visible = false;
            // 
            // ceklabel1
            // 
            this.ceklabel1.AutoSize = true;
            this.ceklabel1.Location = new System.Drawing.Point(88, 219);
            this.ceklabel1.Name = "ceklabel1";
            this.ceklabel1.Size = new System.Drawing.Size(134, 29);
            this.ceklabel1.TabIndex = 6;
            this.ceklabel1.Text = "BANKA ID :";
            this.ceklabel1.Visible = false;
            // 
            // kredilabel1
            // 
            this.kredilabel1.AutoSize = true;
            this.kredilabel1.Location = new System.Drawing.Point(12, 219);
            this.kredilabel1.Name = "kredilabel1";
            this.kredilabel1.Size = new System.Drawing.Size(210, 29);
            this.kredilabel1.TabIndex = 8;
            this.kredilabel1.Text = "KREDİ KART NO :";
            this.kredilabel1.Visible = false;
            // 
            // kredimask1
            // 
            this.kredimask1.Location = new System.Drawing.Point(228, 214);
            this.kredimask1.Mask = "0000-0000-0000-0000";
            this.kredimask1.Name = "kredimask1";
            this.kredimask1.Size = new System.Drawing.Size(253, 34);
            this.kredimask1.TabIndex = 10;
            this.kredimask1.Visible = false;
            // 
            // kredicombo1
            // 
            this.kredicombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kredicombo1.FormattingEnabled = true;
            this.kredicombo1.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.kredicombo1.Location = new System.Drawing.Point(312, 292);
            this.kredicombo1.Name = "kredicombo1";
            this.kredicombo1.Size = new System.Drawing.Size(62, 37);
            this.kredicombo1.TabIndex = 11;
            this.kredicombo1.Visible = false;
            // 
            // kredilabel2
            // 
            this.kredilabel2.AutoSize = true;
            this.kredilabel2.Location = new System.Drawing.Point(12, 295);
            this.kredilabel2.Name = "kredilabel2";
            this.kredilabel2.Size = new System.Drawing.Size(294, 29);
            this.kredilabel2.TabIndex = 12;
            this.kredilabel2.Text = "SON KULLANMA TARİHİ :";
            this.kredilabel2.Visible = false;
            // 
            // kredicombo2
            // 
            this.kredicombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kredicombo2.FormattingEnabled = true;
            this.kredicombo2.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.kredicombo2.Location = new System.Drawing.Point(388, 292);
            this.kredicombo2.Name = "kredicombo2";
            this.kredicombo2.Size = new System.Drawing.Size(104, 37);
            this.kredicombo2.TabIndex = 13;
            this.kredicombo2.Visible = false;
            // 
            // kredilabel3
            // 
            this.kredilabel3.AutoSize = true;
            this.kredilabel3.Location = new System.Drawing.Point(75, 353);
            this.kredilabel3.Name = "kredilabel3";
            this.kredilabel3.Size = new System.Drawing.Size(147, 29);
            this.kredilabel3.TabIndex = 14;
            this.kredilabel3.Text = "CVV KODU :";
            this.kredilabel3.Visible = false;
            // 
            // kredimask2
            // 
            this.kredimask2.Location = new System.Drawing.Point(228, 350);
            this.kredimask2.Mask = "000";
            this.kredimask2.Name = "kredimask2";
            this.kredimask2.Size = new System.Drawing.Size(52, 34);
            this.kredimask2.TabIndex = 15;
            this.kredimask2.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(307, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 61);
            this.button4.TabIndex = 16;
            this.button4.Text = "ÖDEME YAP";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 29);
            this.label3.TabIndex = 17;
            this.label3.Text = "ADRES :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(654, 211);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(294, 113);
            this.richTextBox1.TabIndex = 18;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "TARİH :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 107);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(335, 34);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "ÜCRET :";
            // 
            // labelücret
            // 
            this.labelücret.AutoSize = true;
            this.labelücret.Location = new System.Drawing.Point(223, 59);
            this.labelücret.Name = "labelücret";
            this.labelücret.Size = new System.Drawing.Size(24, 29);
            this.labelücret.TabIndex = 22;
            this.labelücret.Text = "x";
            // 
            // odemeturlabel1
            // 
            this.odemeturlabel1.AutoSize = true;
            this.odemeturlabel1.Location = new System.Drawing.Point(578, 355);
            this.odemeturlabel1.Name = "odemeturlabel1";
            this.odemeturlabel1.Size = new System.Drawing.Size(192, 29);
            this.odemeturlabel1.TabIndex = 23;
            this.odemeturlabel1.Text = "ÖDEME TÜRÜ : ";
            this.odemeturlabel1.Visible = false;
            // 
            // odemeturlabel2
            // 
            this.odemeturlabel2.AutoSize = true;
            this.odemeturlabel2.Location = new System.Drawing.Point(776, 355);
            this.odemeturlabel2.Name = "odemeturlabel2";
            this.odemeturlabel2.Size = new System.Drawing.Size(79, 29);
            this.odemeturlabel2.TabIndex = 24;
            this.odemeturlabel2.Text = "label7";
            this.odemeturlabel2.Visible = false;
            // 
            // OdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 569);
            this.Controls.Add(this.odemeturlabel2);
            this.Controls.Add(this.odemeturlabel1);
            this.Controls.Add(this.labelücret);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.kredimask2);
            this.Controls.Add(this.kredilabel3);
            this.Controls.Add(this.kredicombo2);
            this.Controls.Add(this.kredilabel2);
            this.Controls.Add(this.kredicombo1);
            this.Controls.Add(this.kredimask1);
            this.Controls.Add(this.kredilabel1);
            this.Controls.Add(this.cektext1);
            this.Controls.Add(this.ceklabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "OdemeEkrani";
            this.Text = "Odeme Ekrani";
            this.Load += new System.EventHandler(this.OdemeEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox cektext1;
        private System.Windows.Forms.Label ceklabel1;
        private System.Windows.Forms.Label kredilabel1;
        private System.Windows.Forms.MaskedTextBox kredimask1;
        private System.Windows.Forms.ComboBox kredicombo1;
        private System.Windows.Forms.Label kredilabel2;
        private System.Windows.Forms.ComboBox kredicombo2;
        private System.Windows.Forms.Label kredilabel3;
        private System.Windows.Forms.MaskedTextBox kredimask2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelücret;
        private System.Windows.Forms.Label odemeturlabel1;
        private System.Windows.Forms.Label odemeturlabel2;
    }
}