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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Depo
{
    public partial class StokHareketiEkle : Form
    {
        private SqlConnection connection;

        public StokHareketiEkle()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void StokHareketiEkle_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "SELECT UrunID, UrunAdi FROM Urunler";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("UrunID", typeof(int));
                dataTable.Columns.Add("UrunAdi", typeof(string));
                dataTable.Load(reader);

                cbUrun.DataSource = dataTable;
                cbUrun.DisplayMember = "UrunAdi";
                cbUrun.ValueMember = "UrunID";

                sqlQuery = "SELECT TF.TedarikciFirmaID, CONCAT(T.Ad, ' ', T.Soyad) AS AdSoyad FROM TedarikciFirma TF JOIN Tedarikciler T ON TF.TedarikciID = T.TedarikciID";
                sqlCommand = new SqlCommand(sqlQuery, connection);
                reader = sqlCommand.ExecuteReader();

                DataTable dataTableTedarikci = new DataTable();
                dataTableTedarikci.Columns.Add("TedarikciID", typeof(int));
                dataTableTedarikci.Columns.Add("AdSoyad", typeof(string));
                dataTableTedarikci.Load(reader);

                cbTedarikci.DataSource = dataTableTedarikci;
                cbTedarikci.DisplayMember = "AdSoyad";
                cbTedarikci.ValueMember = "TedarikciFirmaID";

                cbTur.Items.Add(1);
                cbTur.Items.Add(0);
                cbTur.SelectedIndex = 0;
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

        private void btIslemiOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                if (cbTedarikci.SelectedValue != null)
                {
                    string sqlQuery = "INSERT INTO StokHareketleri (UrunID, TedarikciFirmaID, Tur, Miktar, Tarih) VALUES (@urunId, @tedarikciId, @hareketTurId, @miktar, @tarih)";
                    SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                    sqlCommand.Parameters.AddWithValue("@urunId", cbUrun.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@tedarikciId", cbTedarikci.SelectedValue);
                    sqlCommand.Parameters.AddWithValue("@hareketTurId", Convert.ToInt32(cbTur.SelectedItem));
                    sqlCommand.Parameters.AddWithValue("@miktar", Convert.ToInt32(tMiktar.Text));
                    sqlCommand.Parameters.AddWithValue("@tarih", dtHareket.Value);

                    sqlCommand.ExecuteNonQuery();

                    int hareketTurId = Convert.ToInt32(cbTur.SelectedItem);
                    int miktar = Convert.ToInt32(tMiktar.Text);

                    if (hareketTurId == 1)
                    {
                        string sqlQueryIf = "UPDATE Urunler SET StokMiktari = StokMiktari + @miktar WHERE UrunID = @urunId";

                        SqlCommand sqlCommandIf = new SqlCommand(sqlQueryIf, connection);
                        sqlCommandIf.Parameters.AddWithValue("@urunId", cbUrun.SelectedValue);
                        sqlCommandIf.Parameters.AddWithValue("@miktar", miktar);

                        sqlCommandIf.ExecuteNonQuery();
                    }
                    else if (hareketTurId == 0)
                    {
                        string sqlQueryElse = "UPDATE Urunler SET StokMiktari = StokMiktari - @miktar WHERE UrunID = @urunId";

                        SqlCommand sqlCommandElse = new SqlCommand(sqlQueryElse, connection);
                        sqlCommandElse.Parameters.AddWithValue("@urunId", cbUrun.SelectedValue);
                        sqlCommandElse.Parameters.AddWithValue("@miktar", miktar);

                        sqlCommandElse.ExecuteNonQuery();
                    }

                    MessageBox.Show("İşlem başarıyla tamamlandı!");
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir tedarikçi seçin.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
