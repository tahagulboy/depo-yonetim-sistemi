﻿namespace Depo
{
    partial class KategoriEkle
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
            this.tKategoriAdi = new System.Windows.Forms.TextBox();
            this.btIslemiOnayla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UrunEkleBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tKategoriAdi
            // 
            this.tKategoriAdi.Location = new System.Drawing.Point(12, 65);
            this.tKategoriAdi.Name = "tKategoriAdi";
            this.tKategoriAdi.Size = new System.Drawing.Size(211, 20);
            this.tKategoriAdi.TabIndex = 44;
            // 
            // btIslemiOnayla
            // 
            this.btIslemiOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIslemiOnayla.Location = new System.Drawing.Point(12, 91);
            this.btIslemiOnayla.Name = "btIslemiOnayla";
            this.btIslemiOnayla.Size = new System.Drawing.Size(211, 45);
            this.btIslemiOnayla.TabIndex = 43;
            this.btIslemiOnayla.Text = "İşlemi Onayla";
            this.btIslemiOnayla.UseVisualStyleBackColor = true;
            this.btIslemiOnayla.Click += new System.EventHandler(this.btIslemiOnayla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Kategori Adı";
            // 
            // UrunEkleBaslik
            // 
            this.UrunEkleBaslik.AutoSize = true;
            this.UrunEkleBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunEkleBaslik.Location = new System.Drawing.Point(12, 9);
            this.UrunEkleBaslik.Name = "UrunEkleBaslik";
            this.UrunEkleBaslik.Size = new System.Drawing.Size(158, 29);
            this.UrunEkleBaslik.TabIndex = 36;
            this.UrunEkleBaslik.Text = "Kategori Ekle";
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 145);
            this.Controls.Add(this.tKategoriAdi);
            this.Controls.Add(this.btIslemiOnayla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UrunEkleBaslik);
            this.Name = "KategoriEkle";
            this.Text = "Kategori Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tKategoriAdi;
        private System.Windows.Forms.Button btIslemiOnayla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label UrunEkleBaslik;
    }
}