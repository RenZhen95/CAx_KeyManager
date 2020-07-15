using System;
using System.Windows.Forms;
using System.Linq;
using MetroFramework.Forms;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Data.Entity.ModelConfiguration;

namespace CAx_KeyManager
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            try
            {   
                // Read data from database
                Program.ReadFromDatabase();
            }
            catch (ModelValidationException e) { MessageBox.Show(e.ToString()); }

            OwnerDropDown.DataSource = DataManager.BindingOwnerList;
            // Remember that Owner has two properties : "ID" and "Name"
            OwnerDropDown.DisplayMember = "Name";

            // Binds the BindingKeyList to the DataGridView
            DataGrid_Key.DataSource = DataManager.BindingKeyList;

            // Total width of the DataGridView = 300
            DataGrid_Key.Columns[0].Width = 40;
            DataGrid_Key.Columns[1].Width = 75;
            DataGrid_Key.Columns[2].Width = 100;
            DataGrid_Key.Columns[4].Width = 100;

            // Hiding the fourth and sixth column
            DataGrid_Key.Columns[3].Visible = false;
            DataGrid_Key.Columns[5].Visible = false;
        }
        
        // Add Key
        private void AddKey_Button_Click(object sender, EventArgs e)
        {
            string RoomID = RoomID_Input.Text;

            // If the user entered empty strings, simply return
            if (string.IsNullOrEmpty(RoomID)) { return; }

            Owner selectedOwner = (Owner)OwnerDropDown.SelectedItem;
            if (selectedOwner == null)
            {
                // If user hasn't selected an owner
                MessageBox.Show("Please select an owner");
                return;
            }
            else
            {
                if (DataManager.BindingKeyList.ToList().Any(x => x.RoomID == RoomID && x.OwnerID == selectedOwner.OwnerID))
                {
                    // If the key has already been added
                    MessageBox.Show("The key has already been added");
                    return;
                }
                else
                {
                    DataManager.AddKeyFromUI(selectedOwner, RoomID);
                    // Clear the textboxes
                    clearInputs();
                }
            }
        }
        // Delete Key
        private void DeleteKey_Button_Click(object sender, EventArgs e)
        {
            // If user has not selected any rows to delete, simply return
            if (DataGrid_Key.SelectedRows.Count == 0) { return; }
            else
            {
                Key keyToDelete = (Key)DataGrid_Key.SelectedRows[0].DataBoundItem;
                if (keyToDelete == null) { return; }
                else { DataManager.DeleteKey(keyToDelete); }
            }
        }
        // Add new owner
        private void Btn_AddOwner_Click(object sender, EventArgs e)
        {
            if (TextBox_Student.Text.Length == 0)
            {
                return;
            }
            else
            {
                string ownerName = TextBox_Student.Text;

                // Check if the the owner already exists
                if (DataManager.BindingOwnerList.ToList().Any(x => x.Name == ownerName))
                {
                    MessageBox.Show("The owner already exist!");
                    return;
                }
                Debug.WriteLine($"{ownerName} has been added!");
                DataManager.AddOwnerFromUI(ownerName);
                clearInputs();
            }
        }
        private void clearInputs()
        {
            TextBox_Student.Clear();
            RoomID_Input.Clear();
        }

        // If the DataGrid has been changed, obviously the database should also be updated
        private void DataGrid_Key_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("SOMETHING HAS BEEN CHANGED!!!!!");

            // Accessing the key that has been changed in the datagrid, contained in the BindingKeyList
            Key changedKey = DataManager.BindingKeyList[e.RowIndex];

            // Updating the Database
            Program.UpdateDatabase(changedKey);
        }
    }
}
