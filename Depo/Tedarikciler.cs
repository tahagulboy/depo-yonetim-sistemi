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
    public partial class Tedarikciler : Form
    {
        private SqlConnection connection;
        private DataTable dataTable;
        private SqlDataAdapter adapter;

        public Tedarikciler()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source = DESKTOP-2DF58T4;Initial Catalog = Depo;Integrated Security = true;");
        }

        private void Tedarikciler_Load(object sender, EventArgs e)
        {
            GetData();
            ResizeDataGridView();
        }

        private void ResizeDataGridView()
        {
            dtTedarikciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtTedarikciler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void GetData()
        {
            string query = "SELECT * FROM Tedarikciler";
            adapter = new SqlDataAdapter(query, connection);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            dtTedarikciler.DataSource = dataTable;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string searchText = searchBox.Text.ToLower();
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                DataView dv = new DataView(dataTable);
                dv.RowFilter = string.Format("Ad LIKE '%{0}%'", searchText);
                dtTedarikciler.DataSource = dv;
            }
            else
            {
                dtTedarikciler.DataSource = dataTable;
            }
        }

        private void btTedarikciEkle_Click(object sender, EventArgs e)
        {
            TedarikciEkle tedarikciEkle = new TedarikciEkle();
            tedarikciEkle.Show();
        }
    }
}
