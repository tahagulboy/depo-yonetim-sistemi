﻿using System;
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
    public partial class AnaSayfa : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private SqlDataAdapter adapter;


        public AnaSayfa()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void btUrunlereGit_Click(object sender, EventArgs e)
        {
            Urunler urunler = new Urunler();
            urunler.Show();
        }

        private void btKategorilereGit_Click(object sender, EventArgs e)
        {
            Kategoriler kategoriler = new Kategoriler();
            kategoriler.Show();
        }

        private void btTedarikcilereGit_Click(object sender, EventArgs e)
        {
            Tedarikciler tedarikciler = new Tedarikciler();
            tedarikciler.Show();
        }

        private void btFirmalaraGit_Click(object sender, EventArgs e)
        {
            Firmalar firmalar = new Firmalar();
            firmalar.Show();
        }

        private void btStokHareketiEkle_Click(object sender, EventArgs e)
        {
            StokHareketiEkle stokHareketiEkle = new StokHareketiEkle();
            stokHareketiEkle.Show();
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            GetData();
            ResizeDataGridView();
        }

        private void ResizeDataGridView()
        {
            dtStokHareketleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtStokHareketleri.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void GetData()
        {
            string query = "SELECT * FROM StokHareketleri";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtStokHareketleri.DataSource = dataTable;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("UrunAdi LIKE '%{0}%'", searchText);
                dtStokHareketleri.DataSource = dv;
            }
            else
            {
                dtStokHareketleri.DataSource = dataTable;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FTMenu fTMenu = new FTMenu();
            fTMenu.Show();
        }

        private void btStokHareketiSil_Click(object sender, EventArgs e)
        {
            List<int> hareketIDs = new List<int>();

            foreach (DataGridViewRow row in dtStokHareketleri.SelectedRows)
            {
                if (row.Cells["HareketID"].Value != null)
                {
                    hareketIDs.Add(Convert.ToInt32(row.Cells["HareketID"].Value));
                }
            }

            if (hareketIDs.Count > 0)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;"))
                    {
                        connection.Open();

                        string query = "DELETE FROM StokHareketleri WHERE HareketID IN (" + string.Join(",", hareketIDs) + ")";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }

                    GetData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Veritabanından silme hatası: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir satır seçin.");
            }
        }



        private void cbYenile_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM StokHareketleri";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtStokHareketleri.DataSource = dataTable;
            dtStokHareketleri.Refresh();
        }
    }
}
