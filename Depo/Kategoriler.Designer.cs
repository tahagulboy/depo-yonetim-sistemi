namespace Depo
{
    partial class Kategoriler
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
            this.KategorilerBaslik = new System.Windows.Forms.Label();
            this.btKategoriSil = new System.Windows.Forms.Button();
            this.btKategoriEkle = new System.Windows.Forms.Button();
            this.btKategoriSec = new System.Windows.Forms.Button();
            this.dtKategoriler = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtKategoriler)).BeginInit();
            this.SuspendLayout();
            // 
            // KategorilerBaslik
            // 
            this.KategorilerBaslik.AutoSize = true;
            this.KategorilerBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KategorilerBaslik.Location = new System.Drawing.Point(12, 12);
            this.KategorilerBaslik.Name = "KategorilerBaslik";
            this.KategorilerBaslik.Size = new System.Drawing.Size(116, 25);
            this.KategorilerBaslik.TabIndex = 25;
            this.KategorilerBaslik.Text = "Kategoriler";
            // 
            // btKategoriSil
            // 
            this.btKategoriSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKategoriSil.Location = new System.Drawing.Point(613, 205);
            this.btKategoriSil.Name = "btKategoriSil";
            this.btKategoriSil.Size = new System.Drawing.Size(175, 50);
            this.btKategoriSil.TabIndex = 24;
            this.btKategoriSil.Text = "Sil";
            this.btKategoriSil.UseVisualStyleBackColor = true;
            // 
            // btKategoriEkle
            // 
            this.btKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKategoriEkle.Location = new System.Drawing.Point(613, 93);
            this.btKategoriEkle.Name = "btKategoriEkle";
            this.btKategoriEkle.Size = new System.Drawing.Size(175, 50);
            this.btKategoriEkle.TabIndex = 23;
            this.btKategoriEkle.Text = "Ekle";
            this.btKategoriEkle.UseVisualStyleBackColor = true;
            this.btKategoriEkle.Click += new System.EventHandler(this.btKategoriEkle_Click);
            // 
            // btKategoriSec
            // 
            this.btKategoriSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKategoriSec.Location = new System.Drawing.Point(613, 149);
            this.btKategoriSec.Name = "btKategoriSec";
            this.btKategoriSec.Size = new System.Drawing.Size(175, 50);
            this.btKategoriSec.TabIndex = 22;
            this.btKategoriSec.Text = "Seç";
            this.btKategoriSec.UseVisualStyleBackColor = true;
            // 
            // dtKategoriler
            // 
            this.dtKategoriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtKategoriler.Location = new System.Drawing.Point(12, 93);
            this.dtKategoriler.Name = "dtKategoriler";
            this.dtKategoriler.Size = new System.Drawing.Size(595, 162);
            this.dtKategoriler.TabIndex = 21;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.Location = new System.Drawing.Point(446, 58);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(161, 29);
            this.btSearch.TabIndex = 27;
            this.btSearch.Text = "Ara";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.Location = new System.Drawing.Point(12, 58);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(428, 29);
            this.searchBox.TabIndex = 26;
            // 
            // Kategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 271);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.KategorilerBaslik);
            this.Controls.Add(this.btKategoriSil);
            this.Controls.Add(this.btKategoriEkle);
            this.Controls.Add(this.btKategoriSec);
            this.Controls.Add(this.dtKategoriler);
            this.Name = "Kategoriler";
            this.Text = "Kategoriler";
            this.Load += new System.EventHandler(this.Kategoriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtKategoriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KategorilerBaslik;
        private System.Windows.Forms.Button btKategoriSil;
        private System.Windows.Forms.Button btKategoriEkle;
        private System.Windows.Forms.Button btKategoriSec;
        private System.Windows.Forms.DataGridView dtKategoriler;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox searchBox;
    }
}