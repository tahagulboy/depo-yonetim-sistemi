namespace Depo
{
    partial class AnaSayfa
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btUrunlereGit = new System.Windows.Forms.Button();
            this.btKategorilereGit = new System.Windows.Forms.Button();
            this.btTedarikcilereGit = new System.Windows.Forms.Button();
            this.btFirmalaraGit = new System.Windows.Forms.Button();
            this.dtStokHareketleri = new System.Windows.Forms.DataGridView();
            this.btStokHareketiSec = new System.Windows.Forms.Button();
            this.btStokHareketiEkle = new System.Windows.Forms.Button();
            this.btStokHareketiSil = new System.Windows.Forms.Button();
            this.AnaSayfaBaslik = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtStokHareketleri)).BeginInit();
            this.SuspendLayout();
            // 
            // btUrunlereGit
            // 
            this.btUrunlereGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btUrunlereGit.Location = new System.Drawing.Point(613, 220);
            this.btUrunlereGit.Name = "btUrunlereGit";
            this.btUrunlereGit.Size = new System.Drawing.Size(175, 50);
            this.btUrunlereGit.TabIndex = 0;
            this.btUrunlereGit.Text = "Ürünler";
            this.btUrunlereGit.UseVisualStyleBackColor = true;
            this.btUrunlereGit.Click += new System.EventHandler(this.btUrunlereGit_Click);
            // 
            // btKategorilereGit
            // 
            this.btKategorilereGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btKategorilereGit.Location = new System.Drawing.Point(613, 276);
            this.btKategorilereGit.Name = "btKategorilereGit";
            this.btKategorilereGit.Size = new System.Drawing.Size(175, 50);
            this.btKategorilereGit.TabIndex = 1;
            this.btKategorilereGit.Text = "Kategoriler";
            this.btKategorilereGit.UseVisualStyleBackColor = true;
            this.btKategorilereGit.Click += new System.EventHandler(this.btKategorilereGit_Click);
            // 
            // btTedarikcilereGit
            // 
            this.btTedarikcilereGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btTedarikcilereGit.Location = new System.Drawing.Point(613, 332);
            this.btTedarikcilereGit.Name = "btTedarikcilereGit";
            this.btTedarikcilereGit.Size = new System.Drawing.Size(175, 50);
            this.btTedarikcilereGit.TabIndex = 2;
            this.btTedarikcilereGit.Text = "Tedarikçiler";
            this.btTedarikcilereGit.UseVisualStyleBackColor = true;
            this.btTedarikcilereGit.Click += new System.EventHandler(this.btTedarikcilereGit_Click);
            // 
            // btFirmalaraGit
            // 
            this.btFirmalaraGit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFirmalaraGit.Location = new System.Drawing.Point(613, 388);
            this.btFirmalaraGit.Name = "btFirmalaraGit";
            this.btFirmalaraGit.Size = new System.Drawing.Size(175, 50);
            this.btFirmalaraGit.TabIndex = 3;
            this.btFirmalaraGit.Text = "Firmalar";
            this.btFirmalaraGit.UseVisualStyleBackColor = true;
            this.btFirmalaraGit.Click += new System.EventHandler(this.btFirmalaraGit_Click);
            // 
            // dtStokHareketleri
            // 
            this.dtStokHareketleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtStokHareketleri.Location = new System.Drawing.Point(12, 108);
            this.dtStokHareketleri.Name = "dtStokHareketleri";
            this.dtStokHareketleri.Size = new System.Drawing.Size(595, 330);
            this.dtStokHareketleri.TabIndex = 4;
            // 
            // btStokHareketiSec
            // 
            this.btStokHareketiSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStokHareketiSec.Location = new System.Drawing.Point(613, 108);
            this.btStokHareketiSec.Name = "btStokHareketiSec";
            this.btStokHareketiSec.Size = new System.Drawing.Size(175, 50);
            this.btStokHareketiSec.TabIndex = 5;
            this.btStokHareketiSec.Text = "Seç";
            this.btStokHareketiSec.UseVisualStyleBackColor = true;
            // 
            // btStokHareketiEkle
            // 
            this.btStokHareketiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStokHareketiEkle.Location = new System.Drawing.Point(613, 52);
            this.btStokHareketiEkle.Name = "btStokHareketiEkle";
            this.btStokHareketiEkle.Size = new System.Drawing.Size(175, 50);
            this.btStokHareketiEkle.TabIndex = 6;
            this.btStokHareketiEkle.Text = "Ekle";
            this.btStokHareketiEkle.UseVisualStyleBackColor = true;
            this.btStokHareketiEkle.Click += new System.EventHandler(this.btStokHareketiEkle_Click);
            // 
            // btStokHareketiSil
            // 
            this.btStokHareketiSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btStokHareketiSil.Location = new System.Drawing.Point(613, 164);
            this.btStokHareketiSil.Name = "btStokHareketiSil";
            this.btStokHareketiSil.Size = new System.Drawing.Size(175, 50);
            this.btStokHareketiSil.TabIndex = 8;
            this.btStokHareketiSil.Text = "Sil";
            this.btStokHareketiSil.UseVisualStyleBackColor = true;
            // 
            // AnaSayfaBaslik
            // 
            this.AnaSayfaBaslik.AutoSize = true;
            this.AnaSayfaBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnaSayfaBaslik.Location = new System.Drawing.Point(12, 9);
            this.AnaSayfaBaslik.Name = "AnaSayfaBaslik";
            this.AnaSayfaBaslik.Size = new System.Drawing.Size(451, 39);
            this.AnaSayfaBaslik.TabIndex = 9;
            this.AnaSayfaBaslik.Text = "Ana Menü - Stok Hareketleri";
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.Location = new System.Drawing.Point(12, 73);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(428, 29);
            this.searchBox.TabIndex = 10;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.Location = new System.Drawing.Point(446, 73);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(161, 29);
            this.btSearch.TabIndex = 11;
            this.btSearch.Text = "Ara";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.AnaSayfaBaslik);
            this.Controls.Add(this.btStokHareketiSil);
            this.Controls.Add(this.btStokHareketiEkle);
            this.Controls.Add(this.btStokHareketiSec);
            this.Controls.Add(this.dtStokHareketleri);
            this.Controls.Add(this.btFirmalaraGit);
            this.Controls.Add(this.btTedarikcilereGit);
            this.Controls.Add(this.btKategorilereGit);
            this.Controls.Add(this.btUrunlereGit);
            this.Name = "AnaSayfa";
            this.Text = "Depo Yönetim Sistemi: Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtStokHareketleri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btUrunlereGit;
        private System.Windows.Forms.Button btKategorilereGit;
        private System.Windows.Forms.Button btTedarikcilereGit;
        private System.Windows.Forms.Button btFirmalaraGit;
        private System.Windows.Forms.DataGridView dtStokHareketleri;
        private System.Windows.Forms.Button btStokHareketiSec;
        private System.Windows.Forms.Button btStokHareketiEkle;
        private System.Windows.Forms.Button btStokHareketiSil;
        private System.Windows.Forms.Label AnaSayfaBaslik;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Button btSearch;
    }
}

