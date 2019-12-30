using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_KeyManager
{
    public class Key
    {
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

        // Getters and setters for the key attributes
        public string KeyOwnerName
        {
            get { return ownerName; }
            set { ownerName = value; }
        }

        public string KeyRoomID
        {
            get { return roomID; }
            set { roomID = value; }
        }

        public string KeyID
        {
            get { return keyID; }
            set { keyID = value; }
        }
    }
}
