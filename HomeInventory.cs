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
            ResetFields();
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
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return; // This statement returns if headers are clicked
            }

            txtItemID.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtItemName.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtItemQuantity.Text = dgvHomeInventory.Rows[e.RowIndex].Cells[2].Value.ToString();
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

        #region Add Item
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
                        command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                        command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txtItemQuantity.Text));
                        command.ExecuteNonQuery();
                    }
                }
                lblOutRowSuccess.Text = "Item Added!";
                
                LoadSQLiteData();
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
            string sqlUpdate = "UPDATE HomeInventory SET Item_Name = @ItemName, Quantity = @Quantity WHERE Item_ID = @ItemId";
            
            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();
                    
                    using (SQLiteCommand command = new SQLiteCommand(sqlUpdate, databaseConnection))
                    {
                        command.Parameters.AddWithValue("@ItemId", Convert.ToInt32(txtItemID.Text));
                        command.Parameters.AddWithValue("@ItemName", txtItemName.Text);
                        command.Parameters.AddWithValue("@Quantity", txtItemQuantity.Text);
                        command.ExecuteNonQuery();
                    }
                }
                LoadSQLiteData();
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
            string sqlDelete = "DELETE FROM HomeInventory WHERE Item_ID = @ItemId";
            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();
                    using (SQLiteCommand deleteCommand = new SQLiteCommand(sqlDelete, databaseConnection))
                    {
                        deleteCommand.Parameters.AddWithValue("@ItemId", Convert.ToInt32(txtItemID.Text));
                        deleteCommand.ExecuteNonQuery();
                    }
                }
                LoadSQLiteData();
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
            string sqlZeroQuantity = "SELECT Item_Name FROM HomeInventory WHERE Quantity = 0;";

            try
            {
                using (SQLiteConnection databaseConnection = new SQLiteConnection(connectionString))
                {
                    databaseConnection.Open();

                    using (SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(sqlZeroQuantity, connectionString))
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
                        for (int i = 0; i < dgvHomeInventory.Rows.Count - 1; i++)
                        {
                            for (int j = 0; j < dgvHomeInventory.Columns.Count; j++)
                            {
                                writer.Write($"{dgvHomeInventory.Rows[i].Cells[j].Value.ToString()}");

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

        #region Reset Fields
        private void ResetFields()
        {
            txtItemID.Clear();
            txtItemName.Clear();
            txtItemQuantity.Clear();

            dgvHomeInventory.DataSource = null;
            LoadSQLiteData();
        }
        #endregion
    }
}
