using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_KeyManager
{
    public class Key
    {
        public string KeyOwnerName;
        public string KeyRoomID;
        public string KeyID;
        
        public Key(string _owner, string _roomID, string _keyID)
        {
            // Assigning the user input string (owner name) to KeyOwnerName
            KeyOwnerName = _owner;

            // Assigning the user input string (roomID) to KeyRoomID
            KeyRoomID = _roomID;

            // Assigning the user input string (keyID) to KeyID
            KeyID = _keyID;
        }

        public Key() { }
    }
}
