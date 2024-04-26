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
    public partial class Kategoriler : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private SqlDataAdapter adapter;

        public Kategoriler()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void Kategoriler_Load(object sender, EventArgs e)
        {
            GetData();
            ResizeDataGridView();
        }

        private void ResizeDataGridView()
        {
            dtKategoriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtKategoriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void GetData()
        {
            string query = "SELECT * FROM Kategoriler";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtKategoriler.DataSource = dataTable;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("KategoriAdi LIKE '%{0}%'", searchText);
                dtKategoriler.DataSource = dv;
            }
            else
            {
                dtKategoriler.DataSource = dataTable;
            }
        }

        private void btKategoriEkle_Click(object sender, EventArgs e)
        {
            KategoriEkle kategoriEkle = new KategoriEkle();
            kategoriEkle.Show();
        }

        private void btKategoriSil_Click(object sender, EventArgs e)
        {
            if (dtKategoriler.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtKategoriler.SelectedRows)
                {
                    int id = Convert.ToInt32(row.Cells["KategoriID"].Value);

                    try
                    {
                        connection.Open();

                        string deleteChildQuery = "DELETE FROM Urunler WHERE KategoriID = @ParentID";
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

                        string deleteParentQuery = "DELETE FROM Kategoriler WHERE KategoriID = @KategoriID";
                        SqlCommand deleteParentCommand = new SqlCommand(deleteParentQuery, connection);
                        deleteParentCommand.Parameters.AddWithValue("@KategoriID", id);
                        deleteParentCommand.ExecuteNonQuery();

                        dtKategoriler.Rows.Remove(row);
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
            string query = "SELECT * FROM Kategoriler";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtKategoriler.DataSource = dataTable;
            dtKategoriler.Refresh();
        }
    }
}
