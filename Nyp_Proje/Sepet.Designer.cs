namespace Nyp_Proje
{
    partial class Sepet
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cikarbuton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(534, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "ÖDEME EKRANINA İLERLE\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader,
            this.columnHeader2,
            this.columnHeader5,
            this.columnHeader3});
            this.listView1.Location = new System.Drawing.Point(48, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(572, 133);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "SIRA";
            this.columnHeader4.Width = 61;
            // 
            // columnHeader
            // 
            this.columnHeader.Text = "ÜRÜN";
            this.columnHeader.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ADET";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KARGO AĞIRLIĞI";
            this.columnHeader5.Width = 153;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "FİYAT";
            this.columnHeader3.Width = 68;
            // 
            // cikarbuton
            // 
            this.cikarbuton.Location = new System.Drawing.Point(48, 177);
            this.cikarbuton.Name = "cikarbuton";
            this.cikarbuton.Size = new System.Drawing.Size(95, 42);
            this.cikarbuton.TabIndex = 4;
            this.cikarbuton.Text = "ÇIKAR";
            this.cikarbuton.UseVisualStyleBackColor = true;
            this.cikarbuton.Click += new System.EventHandler(this.button4_Click);
            // 
            // Sepet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 296);
            this.Controls.Add(this.cikarbuton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Name = "Sepet";
            this.Text = "Sepet";
            this.Load += new System.EventHandler(this.Sepet_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button cikarbuton;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}