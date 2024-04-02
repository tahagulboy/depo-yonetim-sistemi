namespace Depo
{
    partial class Firmalar
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
            this.FirmalarBaslik = new System.Windows.Forms.Label();
            this.btFirmaSil = new System.Windows.Forms.Button();
            this.btFirmaEkle = new System.Windows.Forms.Button();
            this.btFirmaSec = new System.Windows.Forms.Button();
            this.dtFirmalar = new System.Windows.Forms.DataGridView();
            this.btSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtFirmalar)).BeginInit();
            this.SuspendLayout();
            // 
            // FirmalarBaslik
            // 
            this.FirmalarBaslik.AutoSize = true;
            this.FirmalarBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirmalarBaslik.Location = new System.Drawing.Point(12, 8);
            this.FirmalarBaslik.Name = "FirmalarBaslik";
            this.FirmalarBaslik.Size = new System.Drawing.Size(90, 25);
            this.FirmalarBaslik.TabIndex = 30;
            this.FirmalarBaslik.Text = "Firmalar";
            // 
            // btFirmaSil
            // 
            this.btFirmaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFirmaSil.Location = new System.Drawing.Point(613, 190);
            this.btFirmaSil.Name = "btFirmaSil";
            this.btFirmaSil.Size = new System.Drawing.Size(175, 50);
            this.btFirmaSil.TabIndex = 29;
            this.btFirmaSil.Text = "Sil";
            this.btFirmaSil.UseVisualStyleBackColor = true;
            // 
            // btFirmaEkle
            // 
            this.btFirmaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFirmaEkle.Location = new System.Drawing.Point(613, 78);
            this.btFirmaEkle.Name = "btFirmaEkle";
            this.btFirmaEkle.Size = new System.Drawing.Size(175, 50);
            this.btFirmaEkle.TabIndex = 28;
            this.btFirmaEkle.Text = "Ekle";
            this.btFirmaEkle.UseVisualStyleBackColor = true;
            this.btFirmaEkle.Click += new System.EventHandler(this.btFirmaEkle_Click);
            // 
            // btFirmaSec
            // 
            this.btFirmaSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFirmaSec.Location = new System.Drawing.Point(613, 134);
            this.btFirmaSec.Name = "btFirmaSec";
            this.btFirmaSec.Size = new System.Drawing.Size(175, 50);
            this.btFirmaSec.TabIndex = 27;
            this.btFirmaSec.Text = "Seç";
            this.btFirmaSec.UseVisualStyleBackColor = true;
            // 
            // dtFirmalar
            // 
            this.dtFirmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFirmalar.Location = new System.Drawing.Point(12, 78);
            this.dtFirmalar.Name = "dtFirmalar";
            this.dtFirmalar.Size = new System.Drawing.Size(595, 162);
            this.dtFirmalar.TabIndex = 26;
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.Location = new System.Drawing.Point(446, 43);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(161, 29);
            this.btSearch.TabIndex = 32;
            this.btSearch.Text = "Ara";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.Location = new System.Drawing.Point(12, 43);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(428, 29);
            this.searchBox.TabIndex = 31;
            // 
            // Firmalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 257);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.FirmalarBaslik);
            this.Controls.Add(this.btFirmaSil);
            this.Controls.Add(this.btFirmaEkle);
            this.Controls.Add(this.btFirmaSec);
            this.Controls.Add(this.dtFirmalar);
            this.Name = "Firmalar";
            this.Text = "Firmalar";
            this.Load += new System.EventHandler(this.Firmalar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFirmalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirmalarBaslik;
        private System.Windows.Forms.Button btFirmaSil;
        private System.Windows.Forms.Button btFirmaEkle;
        private System.Windows.Forms.Button btFirmaSec;
        private System.Windows.Forms.DataGridView dtFirmalar;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox searchBox;
    }
}