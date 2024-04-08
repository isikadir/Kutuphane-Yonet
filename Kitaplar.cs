using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Kütüphane_Yönet
{
    public partial class kitaplar : Form
    {
        private SQLiteConnection connection;

        public kitaplar()
        {
            InitializeComponent();
            InitializeDatabase();
            LoadData();
        }

        private void InitializeDatabase()
        {
            string databasePath = "veritabani.db";
            string connectionString = $"Data Source={databasePath};Version=3;";

            connection = new SQLiteConnection(connectionString);

            try
            {
                connection.Open();

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Kitaplar (
                                                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                YazarIsmi TEXT,
                                                KitapAdi TEXT,
                                                SayfaSayisi INTEGER
                                            );";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı başarısız oldu: " + ex.Message);
            }
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string yazarIsmi = textBox3.Text;
            string kitapAdi = textBox4.Text;
            int sayfaSayisi;

            if (!int.TryParse(textBox5.Text, out sayfaSayisi))
            {
                MessageBox.Show("Geçersiz sayfa sayısı.");
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO Kitaplar (YazarIsmi, KitapAdi, SayfaSayisi) VALUES (@yazarIsmi, @kitapAdi, @sayfaSayisi);";

                SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@yazarIsmi", yazarIsmi);
                insertCommand.Parameters.AddWithValue("@kitapAdi", kitapAdi);
                insertCommand.Parameters.AddWithValue("@sayfaSayisi", sayfaSayisi);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Kitap başarıyla eklendi.");

                // Yeni veriyi göstermek için DataGridView'i yeniden yükle
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitap eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string selectQuery = "SELECT YazarIsmi, KitapAdi, SayfaSayisi FROM Kitaplar;";
                SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(selectQuery, connection);

                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);

                dataGridView1.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler yüklenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
