using System.ComponentModel;

namespace CAx_KeyManager
{
    public static class DataManager
    {
        public static BindingList<Key> BindingKeyList = new BindingList<Key>();

        public static void AddKey(Key _addedKey)
        {
            BindingKeyList.Add(_addedKey);
        }

        public static void DeleteKey(Key _removedKey)
        {
            if (BindingKeyList.Contains(_removedKey))
            {
                BindingKeyList.Remove(_removedKey);
            }
        }
    }
}
