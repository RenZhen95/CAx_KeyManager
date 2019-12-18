using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_KeyManager
{
    public class KeyFactory
    {
        public static int ID_Number = 0;

        public string NameSuffix;

        public string[] InvalidCharacters = { "a", "e", "i", "o", "u", "ä", "ö", "ü", "ß" };
        
        public string KeyID;

        public KeyFactory(string _owner, string _room)
        {
            // Each key gets a key number depending on when it's added
            ID_Number += 1;

            // Generating the modified name, taking off the characters we don't want
            NameSuffix = Generate_SuffixName(_owner);

            // Generating the KeyID
            KeyID = GenerateID(_room, NameSuffix, ID_Number);
        }

        private string Generate_SuffixName(string _name)
        {
            string Modified_SuffixName = _name;

            // Remove 'a','e','i','o','u','ä','ö','ü','ß' from the name
            foreach (string character in InvalidCharacters)
            {
                if (Modified_SuffixName.Contains(character))
                {
                    Modified_SuffixName = Modified_SuffixName.Replace(character, "");
                }
            }
            return Modified_SuffixName;
        }

        private string GenerateID(string _roomID, string _modifiedName, int _keyIDNumber)
        {
            string _keyID;

            // Prepping the KeyID
            _keyID = _roomID + "_" + _modifiedName + "_" + _keyIDNumber;
            return _keyID;
        }

        public int ReturnKeyIDNumber()
        {
            return ID_Number;
        }

        public string ReturnKeyID()
        {
            //System.Diagnostics.Debug.WriteLine(KeyID);
            return KeyID;
        }
    }
}
