using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAx_KeyManager
{
    public class Key
    {
        // ID of the Key itself
        [Key]
        public int ID { get; set; }
        // ID of the Room
        public string RoomID { get; set; }
        // Unique KeyID
        public string UniqueID { get; set; }

        // One (Owner) to Many (Key) relationship
        public int OwnerID { get; set; }
        public Owner Owner { get; set; }

        // Null constructor
        public Key() { }

        // Constructor taking user input arguments 
        public Key(Owner _owner, string _roomID)
        {
            Owner = _owner;
            RoomID   = _roomID;

            string modifiedName = Generate_SuffixName(Owner.Name);
            UniqueID = GenerateID(modifiedName);
        }

        // Method to modify the owner name, remove all vowels
        private string Generate_SuffixName(string _name)
        {
            string[] InvalidCharacters = { "a", "e", "i", "o", "u",
                                           "ä", "ö", "ü", "ß" };
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
        // Method to generate the KeyID
        private string GenerateID(string _modifiedName)
        {
            string keyID;

            // Generate a random suffix
            Random random = new Random();
            int randInt   = random.Next(0, 999);

            string randIntString;
            // Always ensuring the suffix has three digit placeholders
            if (randInt < 10)
            {
                randIntString = $"00{randInt}";
            }
            else if ((randInt >= 10) && (randInt < 100))
            {
                randIntString = $"0{randInt}";
            }
            else { randIntString = randInt.ToString(); }

            // Prepping the KeyID
            keyID = $"{RoomID}_{_modifiedName}_{randIntString}";
            return keyID;
        }
    }
}
