using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HomeInventory
{
    public partial class HomeInventory : Form
    {
        public HomeInventory()
        {
            InitializeComponent();

            LoadSQLiteData();
        }

        private void LoadSQLiteData()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";

            string sqlQuery = "SELECT * FROM HomeInventory";

            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlQuery, databaseConnection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);

                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error loading the database file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddItem()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";

            string sqlInsert = "INSERT INTO HomeInventory (Item_Name, Quantity) VALUES (@ItemName, @Quantity)";

            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sqlInsert, databaseConnection))
                    {
                        command.Parameters.AddWithValue("@ItemName", "New Item");
                        command.Parameters.AddWithValue("@Quantity", 1);
                        command.ExecuteNonQuery();
                    }
                }
                LoadSQLiteData();
            }
            catch
            {
                MessageBox.Show("There was an error adding the item to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }
    }
}
