using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAx_KeyManager
{
    public class KeyFactory
    {
        public static int ID_Number = 0;

        public string nameSuffix;
        public string keyID;
        public string owner;
        public string room;

        public string[] InvalidCharacters = { "a", "e", "i", "o", "u", "ä", "ö", "ü", "ß" };

        public KeyFactory(string _owner, string _room)
        {
            Owner = _owner;
            Room = _room;

            // First check that no empty string has been input
            if (string.IsNullOrEmpty(Owner) || string.IsNullOrEmpty(Room))
            {
                if (string.IsNullOrEmpty(Owner) && string.IsNullOrEmpty(Room))
                {
                    MessageBox.Show("Please enter an owner and a room name.");
                    System.Diagnostics.Debug.WriteLine(KeyID);
                }
                else if (string.IsNullOrEmpty(Owner))
                {
                    MessageBox.Show("Please enter an owner name.");
                    System.Diagnostics.Debug.WriteLine(KeyID);
                }
                else if (string.IsNullOrEmpty(Room))
                {
                    MessageBox.Show("Please enter a room name.");
                    System.Diagnostics.Debug.WriteLine(KeyID);
                }
                return;
            }
            // Everything is good...
            else
            {
                // Each key gets a key number depending on when it's added
                ID_Number += 1;

                // Generating the modified name, taking off the characters we don't want
                NameSuffix = Generate_SuffixName(_owner);

                // Generating the KeyID
                KeyID = GenerateID(_room, NameSuffix, ID_Number);
                System.Diagnostics.Debug.WriteLine(KeyID);
            }
        }

        // Getters and Setters
        public string NameSuffix
        {
            get { return nameSuffix; }
            set { nameSuffix = value; }
        }

        public string KeyID
        {
            get { return keyID; }
            set { keyID = value; }
        }

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public string Room
        {
            get { return room; }
            set { room = value; }
        }

        // Methods to generate KeyID
        private string Generate_SuffixName(string _name)
        {
            string Modified_SuffixName = _name;

            // Remove 'a','e','i','o','u','ä','ö','ü','ß' from the name
            foreach (string character in InvalidCharacters)
            {
                if (Modified_SuffixName.Contains(character))
                {
                    Modified_SuffixName = Modified_SuffixName.Replace(character, String.Empty);
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
    }
}
