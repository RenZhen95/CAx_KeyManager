using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAx_KeyManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
            
        private void AddName_Button_Click(object sender, EventArgs e)
        {
            string OwnerName = Owner_Input.Text;
            string RoomID = RoomID_Input.Text;

            // Creating and preparing the key properties
            KeyFactory newKey = new KeyFactory(OwnerName, RoomID);

            // Creating new key object
            Key AddKeyInfo = new Key(newKey.Owner, newKey.Room, newKey.KeyID);

            // Adding the new key object to the DataGrid
            if (!String.IsNullOrEmpty(AddKeyInfo.KeyID))
            {
                DataGrid_Key.Rows.Add(AddKeyInfo.KeyOwnerName, AddKeyInfo.KeyID, AddKeyInfo.KeyRoomID);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Credit to: Tim Schmelter (https://stackoverflow.com/questions/28602700/how-to-delete-selected-rows-from-a-datagridview#28602806)
            foreach (DataGridViewRow selectedRow in DataGrid_Key.SelectedRows)
            {
                DataGrid_Key.Rows.RemoveAt(selectedRow.Index);
            }
        }
    }
}
