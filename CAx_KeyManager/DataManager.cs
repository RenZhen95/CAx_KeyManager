using System.ComponentModel;

namespace CAx_KeyManager
{
    // This class deals with the Form1 class
    public static class DataManager
    {
        // Binding List for storing keys
        public static BindingList<Key> BindingKeyList = new BindingList<Key>();
        // Binding List for storing owners
        public static BindingList<Owner> BindingOwnerList = new BindingList<Owner>();
        
        // Methods for Key Binding List
        public static void AddKeyFromDB(Key _addedKey)
        {
            BindingKeyList.Add(_addedKey);
        }
        public static void AddKeyFromUI(Owner _owner, string _roomID)
        {
            // First create a new key object
            Key newKey = new Key(_owner, _roomID);
            BindingKeyList.Add(newKey);

            // Add the key to the database
            Program.CreateInDatabase(newKey, _owner);
        }
        public static void DeleteKey(Key _removedKey)
        {
            // First delete the key from the Binding List
            if (BindingKeyList.Contains(_removedKey))
            {
                BindingKeyList.Remove(_removedKey);
            }

            // Add the key to the database
            Program.DeleteFromDatabase(_removedKey);
        }

        // Methods for Owner Binding List
        public static void AddOwnerFromDB(Owner _owner)
        {
            BindingOwnerList.Add(_owner);
        }
        public static void AddOwnerFromUI(string _ownerName)
        {
            Owner _newOwner = new Owner() { Name = _ownerName };

            // First adding the new owner to the Binding List
            BindingOwnerList.Add(_newOwner);

            // Adding the owner to the database
            Program.CreateInDatabase(_newOwner);
        }
    }
}
