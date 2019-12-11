using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_KeyManager
{
    class Key
    {
        public string Key_OwnerName;
        public string Key_RoomID;
        public string Suffix_Name;
        
        public Key(string _owner, string _room)
        {
            Key_OwnerName = _owner;
            Key_RoomID = _room;
            
        }

        static string Get_SuffixName(string _name)
        {
            string Modified_SuffixName;
            foreach (char c in _name)
            {
                switch (c)
                {
                    case a:
                        Key_OwnerName


                }
            }

            return Modified_SuffixName;
        }
    }
}
