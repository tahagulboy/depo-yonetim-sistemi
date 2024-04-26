namespace Depo
{
    partial class Urunler
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
            this.dtUrunler = new System.Windows.Forms.DataGridView();
            this.btUrunEkle = new System.Windows.Forms.Button();
            this.btUrunSil = new System.Windows.Forms.Button();
            this.UrunlerBaslik = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.cbYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUrunler
            // 
            this.dtUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUrunler.Location = new System.Drawing.Point(12, 72);
            this.dtUrunler.Name = "dtUrunler";
            this.dtUrunler.Size = new System.Drawing.Size(595, 162);
            this.dtUrunler.TabIndex = 15;
            // 
            // btUrunEkle
            // 
            this.btUrunEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btUrunEkle.Location = new System.Drawing.Point(613, 72);
            this.btUrunEkle.Name = "btUrunEkle";
            this.btUrunEkle.Size = new System.Drawing.Size(175, 50);
            this.btUrunEkle.TabIndex = 17;
            this.btUrunEkle.Text = "Ekle";
            this.btUrunEkle.UseVisualStyleBackColor = true;
            this.btUrunEkle.Click += new System.EventHandler(this.btUrunEkle_Click);
            // 
            // btUrunSil
            // 
            this.btUrunSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btUrunSil.Location = new System.Drawing.Point(613, 128);
            this.btUrunSil.Name = "btUrunSil";
            this.btUrunSil.Size = new System.Drawing.Size(175, 50);
            this.btUrunSil.TabIndex = 18;
            this.btUrunSil.Text = "Sil";
            this.btUrunSil.UseVisualStyleBackColor = true;
            this.btUrunSil.Click += new System.EventHandler(this.btUrunSil_Click);
            // 
            // UrunlerBaslik
            // 
            this.UrunlerBaslik.AutoSize = true;
            this.UrunlerBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunlerBaslik.Location = new System.Drawing.Point(12, 9);
            this.UrunlerBaslik.Name = "UrunlerBaslik";
            this.UrunlerBaslik.Size = new System.Drawing.Size(82, 25);
            this.UrunlerBaslik.TabIndex = 20;
            this.UrunlerBaslik.Text = "Ürünler";
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.Location = new System.Drawing.Point(446, 37);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(161, 29);
            this.btSearch.TabIndex = 36;
            this.btSearch.Text = "Ara";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.Location = new System.Drawing.Point(12, 37);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(428, 29);
            this.searchBox.TabIndex = 35;
            // 
            // cbYenile
            // 
            this.cbYenile.Location = new System.Drawing.Point(739, 9);
            this.cbYenile.Name = "cbYenile";
            this.cbYenile.Size = new System.Drawing.Size(49, 37);
            this.cbYenile.TabIndex = 37;
            this.cbYenile.Text = "Yenile";
            this.cbYenile.UseVisualStyleBackColor = true;
            this.cbYenile.Click += new System.EventHandler(this.cbYenile_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 243);
            this.Controls.Add(this.cbYenile);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.UrunlerBaslik);
            this.Controls.Add(this.btUrunSil);
            this.Controls.Add(this.btUrunEkle);
            this.Controls.Add(this.dtUrunler);
            this.Name = "Urunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtUrunler;
        private System.Windows.Forms.Button btUrunEkle;
        private System.Windows.Forms.Button btUrunSil;
        private System.Windows.Forms.Label UrunlerBaslik;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button cbYenile;
    }
}