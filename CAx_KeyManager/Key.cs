using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_KeyManager
{
    class Key
    {
        public string OwnerName;
        public string RoomID;
        public static int ID_Number = 0;

        public string NameSuffix;

        public char[] InvalidCharacters = { 'a', 'e', 'i', 'o', 'u', 'ä', 'ö', 'ü', 'ß' };
        
        public string KeyID;

        public Key(string _owner, string _room)
        {
            // Assigning Owner name to Key_OwnerName
            OwnerName = _owner;

            // Assigning Room name to Key_RoomID
            RoomID = _room;

            // Each key gets a key number depending on when it's added
            ID_Number += 1;
        }

        public string Get_SuffixName(string _name)
        {
            string Modified_SuffixName = _name;

            // Remove 'a','e','i','o','u','ä','ö','ü','ß' from the name
            foreach (char character in InvalidCharacters)
            {
                if (Modified_SuffixName.Contains(character))
                {
                    string invalidChar = character.ToString();

                    Modified_SuffixName = Modified_SuffixName.Replace(invalidChar, "");
                }
            }
            return Modified_SuffixName;
        }

        public string GenerateID(string _roomID, string _modifiedName, int _keyIDNumber)
        {
            string _keyID;

            // Prepping the KeyID
            _keyID = _roomID + "_" + _modifiedName + "_" + _keyIDNumber;
            return _keyID;
        }
    }
}
