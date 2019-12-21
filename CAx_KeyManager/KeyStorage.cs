using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_KeyManager
{
    class KeyStorage
    {
        public string KeyOwnerName;
        public string KeyRoomID;
        public string KeyID;
        
        public List<List<string>> KeyContainer = new List<List<string>>();

        public KeyStorage(string _owner, string _roomID, string _keyID)
        {
            // Assigning the user input string (owner name) to KeyOwnerName
            KeyOwnerName = _owner;

            // Assigning the user input string (roomID) to KeyRoomID
            KeyRoomID = _roomID;

            // Assigning the user input string (keyID) to KeyID
            KeyID = _keyID;

            // Storing all the input data pertaining to a key in the List of Lists KeyContainer
            KeyContainer.Add(new List<string> {KeyOwnerName, KeyRoomID, KeyID});
        }
    }
}
