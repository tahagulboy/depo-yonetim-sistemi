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
    public partial class Firmalar : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private SqlDataAdapter adapter;

        public Firmalar()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void Firmalar_Load(object sender, EventArgs e)
        {
            GetData();
            ResizeDataGridView();
        }

        private void ResizeDataGridView()
        {
            dtFirmalar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtFirmalar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void GetData()
        {
            string query = "SELECT * FROM Firmalar";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtFirmalar.DataSource = dataTable;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("Ad LIKE '%{0}%'", searchText);
                dtFirmalar.DataSource = dv;
            }
            else
            {
                dtFirmalar.DataSource = dataTable;
            }
        }

        private void btFirmaEkle_Click(object sender, EventArgs e)
        {
            FirmaEkle firmaEkle = new FirmaEkle();
            firmaEkle.Show();
        }

        private void btFirmaSil_Click(object sender, EventArgs e)
        {
            if (dtFirmalar.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtFirmalar.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["FirmaID"].Value);

                    try
                    {
                        connection.Open();

                        string deleteChildQuery = "DELETE FROM StokHareketleri WHERE TedarikciFirmaID = @ParentID";
                        SqlCommand deleteChildCommand = new SqlCommand(deleteChildQuery, connection);
                        deleteChildCommand.Parameters.AddWithValue("@ParentID", id);
                        deleteChildCommand.ExecuteNonQuery();

                        string deleteChildQuery2 = "DELETE FROM TedarikciFirma WHERE FirmaID = @ParentID";
                        SqlCommand deleteChildCommand2 = new SqlCommand(deleteChildQuery2, connection);
                        deleteChildCommand2.Parameters.AddWithValue("@ParentID", id);
                        deleteChildCommand2.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("İlişkili verileri silme hatası: " + ex.Message);
                        connection.Close();
                        return;
                    }
                    finally
                    {
                        connection.Close();
                    }

                    try
                    {
                        connection.Open();

                        string deleteParentQuery = "DELETE FROM Firmalar WHERE FirmaID = @TedarikciID";
                        SqlCommand deleteParentCommand = new SqlCommand(deleteParentQuery, connection);
                        deleteParentCommand.Parameters.AddWithValue("@TedarikciID", id);
                        deleteParentCommand.ExecuteNonQuery();
                        dtFirmalar.Rows.Remove(row);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Veritabanından silme hatası: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
            }
        }

        private void cbYenile_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Firmalar";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtFirmalar.DataSource = dataTable;
            dtFirmalar.Refresh();
        }
    }
}
