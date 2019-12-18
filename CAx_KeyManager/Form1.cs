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
            KeyFactory newKey = new KeyFactory("Madison", "MB264");
            newKey.ReturnKeyID();
            //if (string.IsNullOrEmpty(Owner_Input.Text))
            // Gets values that have been entered in the textboxes
            // dataGrid_Keys.DataSource = DataManager.BindingKeyList
            // Check out static classes
        }

        // Create a KeyManager class that contains a static list 
        //  Implement methods to add and delete key
        //      Think of the conditions for a key to be added (no empty fields for example)
        //  Object created when user inputs name and room

        // Create a Key class that takes in name and user
        //  Returns a KeyID of a specific formats
    }
}
