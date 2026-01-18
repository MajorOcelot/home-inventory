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
using System.IO;

namespace HomeInventory
{
    public partial class HomeInventory : Form
    {
        public HomeInventory()
        {
            InitializeComponent();

            LoadSQLiteData();
        }

        #region CRUD Click Events
        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddItem();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateItem();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }
        #endregion

        #region Sorting Click Events
        private void btnShowEmpties_Click(object sender, EventArgs e)
        {
            ShowEmpties();
        }
        #endregion

        #region Export Click Events
        private void btnSaveShoppingList_Click(object sender, EventArgs e)
        {
            // Exports text file
            ShoppingListExport();
        }
        #endregion

        #region Data Cell Changed
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Prevents error when clicking on header row
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            // Populates text fields with selected row data
            txtItemID.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtItemName.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItemQuantity.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtpExpirationDate.Value = DateTime.Parse(dgvHomeInventory.Rows[e.RowIndex].Cells[3].Value.ToString());
            cbxItemType.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[4].Value.ToString();
            rtbNotes.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[5].Value.ToString();
        }
        #endregion

        #region Load SQLite Data
        private void LoadSQLiteData()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";
            string sqlQuery = "SELECT * FROM HomeInventory";

            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();

                    // Fill DataTable with data from database
                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlQuery, databaseConnection))
                    {
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvHomeInventory.AutoResizeColumns();
                        dgvHomeInventory.DataSource = dataTable;
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error loading the database file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Open Database File
        private void OpenDatabaseFile()
        {
            // Opens existing database file
            ofdOpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofdOpenFile.Filter = "Database Files (*.db)|*.db";

            try
            {
                if (ofdOpenFile.ShowDialog() == DialogResult.OK)
                {
                    // Gets selected file path
                    string selectedFilePath = ofdOpenFile.FileName;
                    string connectionString = $"Data Source={selectedFilePath};Version=3;";

                    using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                    {
                        databaseConnection.Open();

                        using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter("SELECT * FROM HomeInventory", databaseConnection))
                        {
                            // Fill DataTable with data from selected database file
                            DataTable dataTable = new DataTable();
                            dataAdapter.Fill(dataTable);
                            DataView dataView = new DataView(dataTable);
                            dgvHomeInventory.AutoResizeColumns();
                            dgvHomeInventory.DataSource = dataTable;
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error opening the database file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CreateSQLiteDB
        private void CreateSQLiteDB()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";
            string sqlCreateTable = "CREATE TABLE IF NOT EXISTS HomeInventory (" +
                                    "ID INTEGER PRIMARY KEY AUTOINCREMENT," +
                                    "Name TEXT NOT NULL," +
                                    "Quantity INTEGER NOT NULL," +
                                    "Expiration TEXT," +
                                    "Type TEXT," +
                                    "Notes TEXT)";
            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();
                    using (SQLiteCommand command = new SQLiteCommand(sqlCreateTable, databaseConnection))
                    {
                        // Creates table if it does not exist
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error creating the database file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Add Item
        public void AddItem()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";

            string sqlInsert = "INSERT INTO HomeInventory (Name, Quantity, Expiration, Type, Notes) " +
                               "VALUES (@Name, @Quantity, @Expiration, @Type, @Notes)";

            DateTime expirationDate = dtpExpirationDate.Value;

            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();

                    using (SQLiteCommand command = new SQLiteCommand(sqlInsert, databaseConnection))
                    {
                        // Inserts new item into database
                        command.Parameters.AddWithValue("@Name", txtItemName.Text);
                        command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtItemQuantity.Text));
                        command.Parameters.AddWithValue("@Expiration", expirationDate.ToString("d"));
                        command.Parameters.AddWithValue("@Type", cbxItemType.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Notes", rtbNotes.Text);
                        command.ExecuteNonQuery();
                    }
                }
                
                LoadSQLiteData();
                ClearFields();
            }
            catch
            {
                MessageBox.Show("There was an error adding the item to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Update Item
        public void UpdateItem()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";
            string sqlUpdate = "UPDATE HomeInventory SET Name = @Name, Quantity = @Quantity WHERE ID = @ID";
            
            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();
                    
                    using (SQLiteCommand command = new SQLiteCommand(sqlUpdate, databaseConnection))
                    {
                        // Updates item based on ID
                        command.Parameters.AddWithValue("@ID", txtItemID.Text);
                        command.Parameters.AddWithValue("@Name", txtItemName.Text);
                        command.Parameters.AddWithValue("@Quantity", txtItemQuantity.Text);
                        command.Parameters.AddWithValue("@Expiration", dtpExpirationDate.Value.ToString());
                        command.Parameters.AddWithValue("@Type", cbxItemType.SelectedItem.ToString());
                        command.Parameters.AddWithValue("@Notes", rtbNotes.Text);
                        command.ExecuteNonQuery();
                    }
                }

                LoadSQLiteData();
                ClearFields();
            }
            catch
            {
                MessageBox.Show("There was an error updating the item in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Delete Item
        public void DeleteItem()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";
            string sqlDelete = "DELETE FROM HomeInventory WHERE ID = @ID";
            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();

                    using (SQLiteCommand deleteCommand = new SQLiteCommand(sqlDelete, databaseConnection))
                    {
                        // Deletes item based on ID
                        deleteCommand.Parameters.AddWithValue("@ID", Convert.ToInt32(txtItemID.Text));
                        deleteCommand.ExecuteNonQuery();
                    }
                }

                LoadSQLiteData();
                ClearFields();
            }
            catch
            {
                MessageBox.Show("There was an error deleting the item from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Show Empties
        private void ShowEmpties()
        {
            string connectionString = "Data Source=home_inventory.db;Version=3;";
            string sqlZeroQuantity = "SELECT Name FROM HomeInventory WHERE Quantity = 0;";

            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlZeroQuantity, connectionString))
                    {
                        // Fill DataTable with zero quantity items from database
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        DataView dataView = new DataView(dataTable);
                        dgvHomeInventory.AutoResizeColumns();
                        dgvHomeInventory.DataSource = dataTable;
                    }
                }
            }
            catch
            {
                MessageBox.Show("There was an error retrieving zero quantities from the database. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Shopping List
        private void ShoppingListExport()
        {
            sfdSaveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            sfdSaveFile.Filter = "Text Files (*.txt)|*.txt";

            try
            {
                if (sfdSaveFile.ShowDialog() == DialogResult.OK)
                {
                    using (TextWriter writer = new StreamWriter(sfdSaveFile.FileName))
                    {
                        // Writes DataGridView content to text file
                        for (int i = 0; i < dgvHomeInventory.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvHomeInventory.Columns.Count; j++)
                            {
                                // Writes cell value
                                writer.Write($"{dgvHomeInventory.Rows[i].Cells[j].Value.ToString()}");

                                // Adds comma except for last column
                                if (j != dgvHomeInventory.Columns.Count - 1)
                                {
                                    writer.Write(", ");
                                }
                            }

                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Shopping list has been saved!", "Shopping List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("There was an error exporting the shopping list from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Clear Fields
        private void ClearFields()
        {
            // Clears all text fields
            txtItemID.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtItemQuantity.Text = string.Empty;
            dtpExpirationDate.Value = DateTime.Now;
            cbxItemType.Text = string.Empty;
            rtbNotes.Text = string.Empty;
        }
        #endregion

        #region Reset Form
        private void ResetForm()
        {
            ClearFields();

            // Resets DataGridView to show all data
            dgvHomeInventory.DataSource = null;
            LoadSQLiteData();
        }
        #endregion
    }
}
