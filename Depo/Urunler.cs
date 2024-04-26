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
    public partial class Urunler : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private SqlDataAdapter adapter;

        public Urunler()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            GetData();
            ResizeDataGridView();
        }

        private void ResizeDataGridView()
        {
            dtUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtUrunler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void GetData()
        {
            string query = "SELECT * FROM Urunler";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtUrunler.DataSource = dataTable;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("UrunAdi LIKE '%{0}%'", searchText);
                dtUrunler.DataSource = dv;
            }
            else
            {
                dtUrunler.DataSource = dataTable;
            }
        }

        private void btUrunEkle_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
        }

        private void btUrunSil_Click(object sender, EventArgs e)
        {
            if (dtUrunler.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtUrunler.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["UrunID"].Value);

                    try
                    {
                        connection.Open();

                        string deleteChildQuery = "DELETE FROM StokHareketleri WHERE UrunID = @ParentID";
                        SqlCommand deleteChildCommand = new SqlCommand(deleteChildQuery, connection);
                        deleteChildCommand.Parameters.AddWithValue("@ParentID", id);
                        deleteChildCommand.ExecuteNonQuery();
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

                        string deleteParentQuery = "DELETE FROM Urunler WHERE UrunID = @UrunID";
                        SqlCommand deleteParentCommand = new SqlCommand(deleteParentQuery, connection);
                        deleteParentCommand.Parameters.AddWithValue("@UrunID", id);
                        deleteParentCommand.ExecuteNonQuery();

                        dtUrunler.Rows.Remove(row);
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
            string query = "SELECT * FROM Urunler";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtUrunler.DataSource = dataTable;
            dtUrunler.Refresh();
        }
    }
}
