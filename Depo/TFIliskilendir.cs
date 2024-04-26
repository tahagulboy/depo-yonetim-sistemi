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
    public partial class TFIliskilendir : Form
    {
        private SqlConnection connection;

        public TFIliskilendir()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void btIslemiOnayla_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "INSERT INTO TedarikciFirma (TedarikciID, FirmaID) VALUES (@tedarikci, @firma)";

                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);

                sqlCommand.Parameters.AddWithValue("@tedarikci", cbTedarikci.SelectedValue);
                sqlCommand.Parameters.AddWithValue("@firma", cbFirma.SelectedValue);

                sqlCommand.ExecuteNonQuery();


                connection.Close();

                MessageBox.Show("İşlem başarıyla tamamlandı!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısında hata oluştu: " + ex.Message);
            }
        }

        private void TFIliskilendir_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                string sqlQuery = "SELECT TedarikciID, CONCAT(Ad, ' ', Soyad) AS AdSoyad FROM Tedarikciler";
                SqlCommand sqlCommand = new SqlCommand(sqlQuery, connection);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("TedarikciID", typeof(int));
                dataTable.Columns.Add("AdSoyad", typeof(string));
                dataTable.Load(reader);

                cbTedarikci.DataSource = dataTable;
                cbTedarikci.DisplayMember = "AdSoyad";
                cbTedarikci.ValueMember = "TedarikciID";

                sqlQuery = "SELECT FirmaID, Ad FROM Firmalar";
                sqlCommand = new SqlCommand(sqlQuery, connection);
                reader = sqlCommand.ExecuteReader();

                dataTable = new DataTable();
                dataTable.Columns.Add("FirmaID", typeof(int));
                dataTable.Columns.Add("Ad", typeof(string));
                dataTable.Load(reader);

                cbFirma.DataSource = dataTable;
                cbFirma.DisplayMember = "Ad";
                cbFirma.ValueMember = "FirmaID";
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
    }
}
