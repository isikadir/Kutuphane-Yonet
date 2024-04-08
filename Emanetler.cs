using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Kütüphane_Yönet
{
    public partial class Emanetler : Form
    {
        private SQLiteConnection connection;

        public Emanetler()
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

                string createTableQuery = @"CREATE TABLE IF NOT EXISTS Emanetler (
                                                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                                AldigiTarih TEXT,
                                                TeslimTarihi TEXT,
                                                GecKalmaTarihi TEXT
                                            );";

                SQLiteCommand createTableCommand = new SQLiteCommand(createTableQuery, connection);
                createTableCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanı bağlantısı başarısız oldu: " + ex.Message);
            }
        }

        private void LoadData()
        {
            try
            {
                string selectQuery = "SELECT AldigiTarih, TeslimTarihi, GecKalmaTarihi FROM Emanetler;";
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

        private void e_Click(object sender, EventArgs e)
        {
            string aldigiTarih = textBox1.Text;
            string teslimTarihi = textBox2.Text;
            string gecKalmaTarihi = textBox3.Text;

            try
            {
                string insertQuery = "INSERT INTO Emanetler (AldigiTarih, TeslimTarihi, GecKalmaTarihi) VALUES (@aldigiTarih, @teslimTarihi, @gecKalmaTarihi);";

                SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@aldigiTarih", aldigiTarih);
                insertCommand.Parameters.AddWithValue("@teslimTarihi", teslimTarihi);
                insertCommand.Parameters.AddWithValue("@gecKalmaTarihi", gecKalmaTarihi);

                insertCommand.ExecuteNonQuery();

                MessageBox.Show("Emanet başarıyla eklendi.");

                // Yeni veriyi göstermek için DataGridView'i yeniden yükle
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Emanet eklenirken bir hata oluştu: " + ex.Message);
            }
        }
    }
}
