namespace Depo
{
    partial class FirmaEkle
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
            this.tTelefon = new System.Windows.Forms.TextBox();
            this.tAdres = new System.Windows.Forms.RichTextBox();
            this.tAd = new System.Windows.Forms.TextBox();
            this.btIslemiOnayla = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StokHareketiBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tTelefon
            // 
            this.tTelefon.Location = new System.Drawing.Point(12, 242);
            this.tTelefon.Name = "tTelefon";
            this.tTelefon.Size = new System.Drawing.Size(211, 20);
            this.tTelefon.TabIndex = 50;
            // 
            // tAdres
            // 
            this.tAdres.Location = new System.Drawing.Point(12, 114);
            this.tAdres.Name = "tAdres";
            this.tAdres.Size = new System.Drawing.Size(216, 96);
            this.tAdres.TabIndex = 49;
            this.tAdres.Text = "";
            // 
            // tAd
            // 
            this.tAd.Location = new System.Drawing.Point(12, 65);
            this.tAd.Name = "tAd";
            this.tAd.Size = new System.Drawing.Size(211, 20);
            this.tAd.TabIndex = 47;
            // 
            // btIslemiOnayla
            // 
            this.btIslemiOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIslemiOnayla.Location = new System.Drawing.Point(12, 268);
            this.btIslemiOnayla.Name = "btIslemiOnayla";
            this.btIslemiOnayla.Size = new System.Drawing.Size(211, 45);
            this.btIslemiOnayla.TabIndex = 46;
            this.btIslemiOnayla.Text = "İşlemi Onayla";
            this.btIslemiOnayla.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Telefon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Adres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Firma Adı";
            // 
            // StokHareketiBaslik
            // 
            this.StokHareketiBaslik.AutoSize = true;
            this.StokHareketiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokHareketiBaslik.Location = new System.Drawing.Point(12, 9);
            this.StokHareketiBaslik.Name = "StokHareketiBaslik";
            this.StokHareketiBaslik.Size = new System.Drawing.Size(129, 29);
            this.StokHareketiBaslik.TabIndex = 39;
            this.StokHareketiBaslik.Text = "Firma Ekle";
            // 
            // FirmaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 322);
            this.Controls.Add(this.tTelefon);
            this.Controls.Add(this.tAdres);
            this.Controls.Add(this.tAd);
            this.Controls.Add(this.btIslemiOnayla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StokHareketiBaslik);
            this.Name = "FirmaEkle";
            this.Text = "Firma Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tTelefon;
        private System.Windows.Forms.RichTextBox tAdres;
        private System.Windows.Forms.TextBox tAd;
        private System.Windows.Forms.Button btIslemiOnayla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StokHareketiBaslik;
    }
}