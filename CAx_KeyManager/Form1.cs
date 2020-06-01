using System;
using System.Windows.Forms;

namespace CAx_KeyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Binds the BindingKeyList to the DataGridView
            DataGrid_Key.DataSource = DataManager.BindingKeyList;
        }
            
        private void AddName_Button_Click(object sender, EventArgs e)
        {
            string OwnerName = Owner_Input.Text;
            string RoomID = RoomID_Input.Text;

            // If the user entered empty strings, simply return
            if (string.IsNullOrEmpty(OwnerName)) { return; }
            if (string.IsNullOrEmpty(RoomID)) { return; }

            // Creating new key object with the user input
            Key newKey = new Key(OwnerName, RoomID);

            // Adding the newly created Key into the BindingList
            DataManager.AddKey(newKey);
            // Clear the textboxes
            clearInputs();
        }
        private void clearInputs()
        {
            Owner_Input.Clear();
            RoomID_Input.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            Key selectedKey = (Key)DataGrid_Key.SelectedRows[0].DataBoundItem;
            DataManager.DeleteKey(selectedKey);
        }
    }
}
