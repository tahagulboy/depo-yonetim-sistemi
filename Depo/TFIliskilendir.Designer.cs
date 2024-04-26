namespace Depo
{
    partial class TFIliskilendir
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
            this.label2 = new System.Windows.Forms.Label();
            this.cbFirma = new System.Windows.Forms.ComboBox();
            this.UrunEkleBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTedarikci = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btIslemiOnayla
            // 
            this.btIslemiOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIslemiOnayla.Location = new System.Drawing.Point(10, 155);
            this.btIslemiOnayla.Name = "btIslemiOnayla";
            this.btIslemiOnayla.Size = new System.Drawing.Size(292, 45);
            this.btIslemiOnayla.TabIndex = 43;
            this.btIslemiOnayla.Text = "İşlemi Onayla";
            this.btIslemiOnayla.UseVisualStyleBackColor = true;
            this.btIslemiOnayla.Click += new System.EventHandler(this.btIslemiOnayla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Firma";
            // 
            // cbFirma
            // 
            this.cbFirma.FormattingEnabled = true;
            this.cbFirma.Location = new System.Drawing.Point(12, 113);
            this.cbFirma.Name = "cbFirma";
            this.cbFirma.Size = new System.Drawing.Size(290, 21);
            this.cbFirma.TabIndex = 37;
            // 
            // UrunEkleBaslik
            // 
            this.UrunEkleBaslik.AutoSize = true;
            this.UrunEkleBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunEkleBaslik.Location = new System.Drawing.Point(12, 9);
            this.UrunEkleBaslik.Name = "UrunEkleBaslik";
            this.UrunEkleBaslik.Size = new System.Drawing.Size(299, 29);
            this.UrunEkleBaslik.TabIndex = 36;
            this.UrunEkleBaslik.Text = "Tedarikçi-Firma İlişkilendir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Tedarikçi";
            // 
            // cbTedarikci
            // 
            this.cbTedarikci.FormattingEnabled = true;
            this.cbTedarikci.Location = new System.Drawing.Point(12, 64);
            this.cbTedarikci.Name = "cbTedarikci";
            this.cbTedarikci.Size = new System.Drawing.Size(290, 21);
            this.cbTedarikci.TabIndex = 46;
            // 
            // TFIliskilendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 234);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTedarikci);
            this.Controls.Add(this.btIslemiOnayla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFirma);
            this.Controls.Add(this.UrunEkleBaslik);
            this.Name = "TFIliskilendir";
            this.Text = "TFIliskilendir";
            this.Load += new System.EventHandler(this.TFIliskilendir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btIslemiOnayla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFirma;
        private System.Windows.Forms.Label UrunEkleBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTedarikci;
    }
}