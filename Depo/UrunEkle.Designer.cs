namespace Depo
{
    partial class UrunEkle
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
            this.btIslemiOnayla = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBirimFiyati = new System.Windows.Forms.TextBox();
            this.cbKategori = new System.Windows.Forms.ComboBox();
            this.UrunEkleBaslik = new System.Windows.Forms.Label();
            this.tUrunAdi = new System.Windows.Forms.TextBox();
            this.tStokMiktari = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btIslemiOnayla
            // 
            this.btIslemiOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIslemiOnayla.Location = new System.Drawing.Point(12, 239);
            this.btIslemiOnayla.Name = "btIslemiOnayla";
            this.btIslemiOnayla.Size = new System.Drawing.Size(211, 45);
            this.btIslemiOnayla.TabIndex = 33;
            this.btIslemiOnayla.Text = "İşlemi Onayla";
            this.btIslemiOnayla.UseVisualStyleBackColor = true;
            this.btIslemiOnayla.Click += new System.EventHandler(this.btIslemiOnayla_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Birim Fiyatı (TL)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Stok Miktarı";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kategori";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Ürün Adı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tBirimFiyati
            // 
            this.tBirimFiyati.Location = new System.Drawing.Point(12, 200);
            this.tBirimFiyati.Name = "tBirimFiyati";
            this.tBirimFiyati.Size = new System.Drawing.Size(211, 20);
            this.tBirimFiyati.TabIndex = 26;
            this.tBirimFiyati.TextChanged += new System.EventHandler(this.tBirimFiyati_TextChanged);
            // 
            // cbKategori
            // 
            this.cbKategori.FormattingEnabled = true;
            this.cbKategori.Location = new System.Drawing.Point(12, 104);
            this.cbKategori.Name = "cbKategori";
            this.cbKategori.Size = new System.Drawing.Size(211, 21);
            this.cbKategori.TabIndex = 24;
            this.cbKategori.SelectedIndexChanged += new System.EventHandler(this.cbKategori_SelectedIndexChanged);
            // 
            // UrunEkleBaslik
            // 
            this.UrunEkleBaslik.AutoSize = true;
            this.UrunEkleBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunEkleBaslik.Location = new System.Drawing.Point(12, 9);
            this.UrunEkleBaslik.Name = "UrunEkleBaslik";
            this.UrunEkleBaslik.Size = new System.Drawing.Size(118, 29);
            this.UrunEkleBaslik.TabIndex = 22;
            this.UrunEkleBaslik.Text = "Ürün Ekle";
            this.UrunEkleBaslik.Click += new System.EventHandler(this.UrunEkleBaslik_Click);
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.Location = new System.Drawing.Point(12, 65);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(211, 20);
            this.tUrunAdi.TabIndex = 34;
            this.tUrunAdi.TextChanged += new System.EventHandler(this.tUrunAdi_TextChanged);
            // 
            // tStokMiktari
            // 
            this.tStokMiktari.Location = new System.Drawing.Point(12, 150);
            this.tStokMiktari.Name = "tStokMiktari";
            this.tStokMiktari.Size = new System.Drawing.Size(211, 20);
            this.tStokMiktari.TabIndex = 35;
            this.tStokMiktari.TextChanged += new System.EventHandler(this.tStokMiktari_TextChanged);
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(236, 298);
            this.Controls.Add(this.tStokMiktari);
            this.Controls.Add(this.tUrunAdi);
            this.Controls.Add(this.btIslemiOnayla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBirimFiyati);
            this.Controls.Add(this.cbKategori);
            this.Controls.Add(this.UrunEkleBaslik);
            this.Name = "UrunEkle";
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIslemiOnayla;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBirimFiyati;
        private System.Windows.Forms.ComboBox cbKategori;
        private System.Windows.Forms.Label UrunEkleBaslik;
        private System.Windows.Forms.TextBox tUrunAdi;
        private System.Windows.Forms.TextBox tStokMiktari;
    }
}