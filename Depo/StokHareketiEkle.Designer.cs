namespace Depo
{
    partial class StokHareketiEkle
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
            this.StokHareketiBaslik = new System.Windows.Forms.Label();
            this.cbUrun = new System.Windows.Forms.ComboBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.cbTedarikci = new System.Windows.Forms.ComboBox();
            this.tMiktar = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btIslemiOnayla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StokHareketiBaslik
            // 
            this.StokHareketiBaslik.AutoSize = true;
            this.StokHareketiBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokHareketiBaslik.Location = new System.Drawing.Point(12, 9);
            this.StokHareketiBaslik.Name = "StokHareketiBaslik";
            this.StokHareketiBaslik.Size = new System.Drawing.Size(211, 29);
            this.StokHareketiBaslik.TabIndex = 10;
            this.StokHareketiBaslik.Text = "Stok Hareketi Ekle";
            // 
            // cbUrun
            // 
            this.cbUrun.FormattingEnabled = true;
            this.cbUrun.Location = new System.Drawing.Point(12, 61);
            this.cbUrun.Name = "cbUrun";
            this.cbUrun.Size = new System.Drawing.Size(211, 21);
            this.cbUrun.TabIndex = 11;
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Location = new System.Drawing.Point(12, 104);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(211, 21);
            this.cbTur.TabIndex = 12;
            // 
            // cbTedarikci
            // 
            this.cbTedarikci.FormattingEnabled = true;
            this.cbTedarikci.Location = new System.Drawing.Point(12, 150);
            this.cbTedarikci.Name = "cbTedarikci";
            this.cbTedarikci.Size = new System.Drawing.Size(211, 21);
            this.cbTedarikci.TabIndex = 13;
            // 
            // tMiktar
            // 
            this.tMiktar.Location = new System.Drawing.Point(12, 200);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(211, 20);
            this.tMiktar.TabIndex = 14;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 247);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Ürün";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hareket Türü";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Tedarikçi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Miktar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Hareket Tarihi";
            // 
            // btIslemiOnayla
            // 
            this.btIslemiOnayla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btIslemiOnayla.Location = new System.Drawing.Point(12, 281);
            this.btIslemiOnayla.Name = "btIslemiOnayla";
            this.btIslemiOnayla.Size = new System.Drawing.Size(211, 45);
            this.btIslemiOnayla.TabIndex = 21;
            this.btIslemiOnayla.Text = "İşlemi Onayla";
            this.btIslemiOnayla.UseVisualStyleBackColor = true;
            // 
            // StokHareketiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 332);
            this.Controls.Add(this.btIslemiOnayla);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.tMiktar);
            this.Controls.Add(this.cbTedarikci);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.cbUrun);
            this.Controls.Add(this.StokHareketiBaslik);
            this.Name = "StokHareketiEkle";
            this.Text = "Stok Hareketi Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StokHareketiBaslik;
        private System.Windows.Forms.ComboBox cbUrun;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.ComboBox cbTedarikci;
        private System.Windows.Forms.TextBox tMiktar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btIslemiOnayla;
    }
}