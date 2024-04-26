using System;
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
    public partial class UrunEkle : Form
    {
        private SqlConnection connection;

        public UrunEkle()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void btIslemiOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "INSERT INTO Urunler (UrunAdi, KategoriID, StokMiktari, BirimFiyati) VALUES (@urunAdi, @kategoriId, @stokMiktari, @birimFiyati)";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

                sqlCommand.Parameters.AddWithValue("@urunAdi", tUrunAdi.Text);
                sqlCommand.Parameters.AddWithValue("@kategoriId", cbKategori.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@stokMiktari", tStokMiktari.Text);
                sqlCommand.Parameters.AddWithValue("@birimFiyati", tBirimFiyati.Text);

                sqlCommand.ExecuteNonQuery();

                connection.Close();

                MessageBox.Show("İşlem başarıyla tamamlandı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu: " + ex.Message);
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "SELECT KategoriID, KategoriAdi FROM Kategoriler";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("KategoriID", typeof(int));
                dataTable.Columns.Add("KategoriAdi", typeof(string));
                dataTable.Load(reader);

                cbKategori.DataSource = dataTable;
                cbKategori.DisplayMember = "KategoriAdi"; 
                cbKategori.ValueMember = "KategoriID"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanından kategoriler alınırken bir hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void tUrunAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void tStokMiktari_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tBirimFiyati_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void UrunEkleBaslik_Click(object sender, EventArgs e)
        {

        }
    }
}
