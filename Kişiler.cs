using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Kütüphane_Yönet
{
    public partial class Kişiler : Form
    {
        private SQLiteConnection connection;

        public Kişiler()
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

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Kisiler (
                                                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                KisiIsmi TEXT,
                                                KisiSoyismi TEXT,
                                                KisiNumarasi INTEGER
                                            );";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı başarısız oldu: " + ex.Message);
            }
        }

        private void kısıekle_Click(object sender, EventArgs e)
        {
            string kisiIsmi = textBox1.Text;
            string kisiSoyismi = textBox2.Text;
            int kisiNumarasi;

            if (!int.TryParse(textBox3.Text, out kisiNumarasi))
            {
                MessageBox.Show("Geçersiz kişi numarası.");
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO Kisiler (KisiIsmi, KisiSoyismi, KisiNumarasi) VALUES (@kisiIsmi, @kisiSoyismi, @kisiNumarasi);";

                SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@kisiIsmi", kisiIsmi);
                insertCommand.Parameters.AddWithValue("@kisiSoyismi", kisiSoyismi);
                insertCommand.Parameters.AddWithValue("@kisiNumarasi", kisiNumarasi);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Kişi başarıyla eklendi.");

                // Yeni veriyi göstermek için DataGridView'i yeniden yükle
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kişi eklenirken bir hata oluştu: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string selectQuery = "SELECT KisiIsmi, KisiSoyismi, KisiNumarasi FROM Kisiler;";
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
