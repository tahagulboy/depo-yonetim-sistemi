﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Depo
{
    public partial class KategoriEkle : Form
    {
        private SqlConnection connection;

        public KategoriEkle()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void btIslemiOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "INSERT INTO Kategoriler (KategoriAdi) VALUES (@kategoriAdi)";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

                sqlCommand.Parameters.AddWithValue("@kategoriAdi", tKategoriAdi.Text);

                sqlCommand.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("İşlem başarıyla tamamlandı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu: " + ex.Message);
            }
        }
    }
}
