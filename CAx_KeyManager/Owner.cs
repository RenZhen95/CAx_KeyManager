using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAx_KeyManager
{
    class Owner
    {
        public string OwnerName;
        public string OwnerID;
        public List<string> OwnerNameList = new List<string>();
        public List<string> OwnerIDList   = new List<string>();

        public Owner(string _ownerName, string _ownerID)
        {
            OwnerName = _ownerName;
            OwnerID = _ownerID;

            OwnerNameList.Add(OwnerName);
            OwnerIDList.Add(OwnerID);
            // Checks of the owner name and ID have been added before
        }

        //private bool checkIfOwnerExist(string OwnerName, string OwnerID)
        //{
        //    if (ow
        //        )
        //    return true 
        //}
    }
}
