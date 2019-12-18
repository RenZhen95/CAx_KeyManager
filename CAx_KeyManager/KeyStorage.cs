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
        public string KeyID_Number;
        public string KeyID;

        public KeyStorage(string _owner, string _roomID)
        {
            // Assigning the user input string (owner name) to KeyOwnerName
            KeyOwnerName = _owner;

            // Assigning the user input string (roomID) to KeyRoomID
            KeyRoomID = _roomID;
        }

        public void AddKeyID_Number(string _keyIDNumber)
        {
            KeyID_Number = _keyIDNumber;
        }

        public void AddKeyID(string _keyID)
        {
            KeyID = _keyID;
        }
    }
}
