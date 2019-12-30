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
        public DataTable KeyTable = new DataTable();

        public Form1()
        {
            InitializeComponent();

            KeyTable.Columns.Add("Owner_Column", typeof(string));
            KeyTable.Columns.Add("ID_Column", typeof(string));
            KeyTable.Columns.Add("RoomID_Column", typeof(string));
            
        }

        //BindingList<Key> KeyContainer;
        //private void InitializeKeyContainer()
        //{
        //    // Create the new BindingList of Key type.
        //    KeyContainer = new BindingList<Key>();

        //    // Allow new parts to be added, but not removed once committed.        
        //    KeyContainer.AllowNew = true;
        //    KeyContainer.AllowRemove = false;

        //    // Raise ListChanged events when new parts are added.
        //    KeyContainer.RaiseListChangedEvents = true;

        //    // Do not allow parts to be edited.
        //    KeyContainer.AllowEdit = false;
        //}
            
        private void AddName_Button_Click(object sender, EventArgs e)
        {
            KeyFactory newKey = new KeyFactory("Madison", "MB264");

            Key AddKeyInfo = new Key("Madison", "MB264", newKey.KeyID);

            KeyTable.Rows.Add(AddKeyInfo.KeyOwnerName, AddKeyInfo.KeyID, AddKeyInfo.KeyRoomID);
            System.Diagnostics.Debug.WriteLine(AddKeyInfo.KeyOwnerName);
            DataGrid_Key.Rows.Add(AddKeyInfo.KeyOwnerName, AddKeyInfo.KeyID, AddKeyInfo.KeyRoomID);
        }

        // Create a KeyManager class that contains a static list 
        //  Implement methods to add and delete key
        //      Think of the conditions for a key to be added (no empty fields for example)
        //  Object created when user inputs name and room

        // Create a Key class that takes in name and user
        //  Returns a KeyID of a specific formats
    }
}
