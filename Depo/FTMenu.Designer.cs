namespace Depo
{
    partial class FTMenu
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
            this.btSearch = new System.Windows.Forms.Button();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.FirmalarBaslik = new System.Windows.Forms.Label();
            this.btFirmaSil = new System.Windows.Forms.Button();
            this.btFirmaEkle = new System.Windows.Forms.Button();
            this.dtTdFr = new System.Windows.Forms.DataGridView();
            this.cbYenile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtTdFr)).BeginInit();
            this.SuspendLayout();
            // 
            // btSearch
            // 
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btSearch.Location = new System.Drawing.Point(446, 44);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(161, 29);
            this.btSearch.TabIndex = 39;
            this.btSearch.Text = "Ara";
            this.btSearch.UseVisualStyleBackColor = true;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // searchBox
            // 
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchBox.Location = new System.Drawing.Point(12, 44);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(428, 29);
            this.searchBox.TabIndex = 38;
            // 
            // FirmalarBaslik
            // 
            this.FirmalarBaslik.AutoSize = true;
            this.FirmalarBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FirmalarBaslik.Location = new System.Drawing.Point(12, 9);
            this.FirmalarBaslik.Name = "FirmalarBaslik";
            this.FirmalarBaslik.Size = new System.Drawing.Size(209, 25);
            this.FirmalarBaslik.TabIndex = 37;
            this.FirmalarBaslik.Text = "Tedarikçiler-Firmalar";
            // 
            // btFirmaSil
            // 
            this.btFirmaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFirmaSil.Location = new System.Drawing.Point(613, 44);
            this.btFirmaSil.Name = "btFirmaSil";
            this.btFirmaSil.Size = new System.Drawing.Size(175, 50);
            this.btFirmaSil.TabIndex = 36;
            this.btFirmaSil.Text = "Sil";
            this.btFirmaSil.UseVisualStyleBackColor = true;
            this.btFirmaSil.Click += new System.EventHandler(this.btFirmaSil_Click);
            // 
            // btFirmaEkle
            // 
            this.btFirmaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btFirmaEkle.Location = new System.Drawing.Point(12, 247);
            this.btFirmaEkle.Name = "btFirmaEkle";
            this.btFirmaEkle.Size = new System.Drawing.Size(595, 50);
            this.btFirmaEkle.TabIndex = 35;
            this.btFirmaEkle.Text = "İlişkilendir";
            this.btFirmaEkle.UseVisualStyleBackColor = true;
            this.btFirmaEkle.Click += new System.EventHandler(this.btFirmaEkle_Click);
            // 
            // dtTdFr
            // 
            this.dtTdFr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtTdFr.Location = new System.Drawing.Point(12, 79);
            this.dtTdFr.Name = "dtTdFr";
            this.dtTdFr.Size = new System.Drawing.Size(595, 162);
            this.dtTdFr.TabIndex = 33;
            // 
            // cbYenile
            // 
            this.cbYenile.Location = new System.Drawing.Point(739, 6);
            this.cbYenile.Name = "cbYenile";
            this.cbYenile.Size = new System.Drawing.Size(49, 37);
            this.cbYenile.TabIndex = 40;
            this.cbYenile.Text = "Yenile";
            this.cbYenile.UseVisualStyleBackColor = true;
            this.cbYenile.Click += new System.EventHandler(this.cbYenile_Click);
            // 
            // FTMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 307);
            this.Controls.Add(this.cbYenile);
            this.Controls.Add(this.btSearch);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.FirmalarBaslik);
            this.Controls.Add(this.btFirmaSil);
            this.Controls.Add(this.btFirmaEkle);
            this.Controls.Add(this.dtTdFr);
            this.Name = "FTMenu";
            this.Text = "FTMenu";
            this.Load += new System.EventHandler(this.FTMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtTdFr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.Label FirmalarBaslik;
        private System.Windows.Forms.Button btFirmaSil;
        private System.Windows.Forms.Button btFirmaEkle;
        private System.Windows.Forms.DataGridView dtTdFr;
        private System.Windows.Forms.Button cbYenile;
    }
}