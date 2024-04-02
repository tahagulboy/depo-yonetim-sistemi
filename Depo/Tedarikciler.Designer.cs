namespace Depo
{
    partial class Tedarikciler
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
            this.TedarikcilerBaslik = new System.Windows.Forms.Label();
            this.btTedarikciSil = new System.Windows.Forms.Button();
            this.btTedarikciEkle = new System.Windows.Forms.Button();
            this.btTedarikciSec = new System.Windows.Forms.Button();
            this.dtTedarikciler = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtTedarikciler)).BeginInit();
            this.SuspendLayout();
            // 
            // TedarikcilerBaslik
            // 
            this.TedarikcilerBaslik.AutoSize = true;
            this.TedarikcilerBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TedarikcilerBaslik.Location = new System.Drawing.Point(12, 8);
            this.TedarikcilerBaslik.Name = "TedarikcilerBaslik";
            this.TedarikcilerBaslik.Size = new System.Drawing.Size(124, 25);
            this.TedarikcilerBaslik.TabIndex = 30;
            this.TedarikcilerBaslik.Text = "Tedarikçiler";
            // 
            // btTedarikciSil
            // 
            this.btTedarikciSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btTedarikciSil.Location = new System.Drawing.Point(613, 192);
            this.btTedarikciSil.Name = "btTedarikciSil";
            this.btTedarikciSil.Size = new System.Drawing.Size(175, 50);
            this.btTedarikciSil.TabIndex = 29;
            this.btTedarikciSil.Text = "Sil";
            this.btTedarikciSil.UseVisualStyleBackColor = true;
            // 
            // btTedarikciEkle
            // 
            this.btTedarikciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btTedarikciEkle.Location = new System.Drawing.Point(613, 80);
            this.btTedarikciEkle.Name = "btTedarikciEkle";
            this.btTedarikciEkle.Size = new System.Drawing.Size(175, 50);
            this.btTedarikciEkle.TabIndex = 28;
            this.btTedarikciEkle.Text = "Ekle";
            this.btTedarikciEkle.UseVisualStyleBackColor = true;
            this.btTedarikciEkle.Click += new System.EventHandler(this.btTedarikciEkle_Click);
            // 
            // btTedarikciSec
            // 
            this.btTedarikciSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btTedarikciSec.Location = new System.Drawing.Point(613, 136);
            this.btTedarikciSec.Name = "btTedarikciSec";
            this.btTedarikciSec.Size = new System.Drawing.Size(175, 50);
            this.btTedarikciSec.TabIndex = 27;
            this.btTedarikciSec.Text = "Seç";
            this.btTedarikciSec.UseVisualStyleBackColor = true;
            // 
            // dtTedarikciler
            // 
            this.dtTedarikciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTedarikciler.Location = new System.Drawing.Point(12, 80);
            this.dtTedarikciler.Name = "dtTedarikciler";
            this.dtTedarikciler.Size = new System.Drawing.Size(595, 162);
            this.dtTedarikciler.TabIndex = 26;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.Location = new System.Drawing.Point(446, 45);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(161, 29);
            this.btSearch.TabIndex = 34;
            this.btSearch.Text = "Ara";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.Location = new System.Drawing.Point(12, 45);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(428, 29);
            this.searchBox.TabIndex = 33;
            // 
            // Tedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.TedarikcilerBaslik);
            this.Controls.Add(this.btTedarikciSil);
            this.Controls.Add(this.btTedarikciEkle);
            this.Controls.Add(this.btTedarikciSec);
            this.Controls.Add(this.dtTedarikciler);
            this.Name = "Tedarikciler";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Tedarikciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTedarikciler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TedarikcilerBaslik;
        private System.Windows.Forms.Button btTedarikciSil;
        private System.Windows.Forms.Button btTedarikciEkle;
        private System.Windows.Forms.Button btTedarikciSec;
        private System.Windows.Forms.DataGridView dtTedarikciler;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox searchBox;
    }
}