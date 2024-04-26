using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depo
{
    public partial class FirmaEkle : Form
    {
        private SqlConnection connection;

        public FirmaEkle()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void btIslemiOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "INSERT INTO Firmalar (Ad, Adres, Telefon) VALUES (@firmaAdi, @adres, @telefon)";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

                sqlCommand.Parameters.AddWithValue("@firmaAdi", tAd.Text);
                sqlCommand.Parameters.AddWithValue("@adres", tAdres.Text);
                sqlCommand.Parameters.AddWithValue("@telefon", tTelefon.Text);

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
