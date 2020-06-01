using System;

namespace CAx_KeyManager
{
    public class Key
    {
        // Public fields
        public string KeyOwnerName { get; set; }
        public string KeyRoomID { get; set; }
        public string KeyID { get; set; }

        private string ownerName;
        private string roomID;
        private string keyID;

        // Null constructor
        public Key() { }

        // Constructor taking user input arguments 
        public Key(string _owner, string _roomID, string _keyID)
        {
            if (String.IsNullOrEmpty(_keyID))
            {
                return;
            }
            else
            {
                // Assigning the user input string (owner name) to KeyOwnerName
                KeyOwnerName = _owner;

                // Assigning the user input string (roomID) to KeyRoomID
                KeyRoomID = _roomID;

                // Assigning the user input string (keyID) to KeyID
                KeyID = _keyID;
            }
        }
    }
}
