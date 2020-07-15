using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CAx_KeyManager
{
    /// <summary>
    ///  This is my primary relation, where Owner maps to multiple keys
    /// </summary>
    public class Owner
    {
        public int OwnerID { get; set; }
        public string Name { get; set; }
        public List<Key> Keys = new List<Key>();

        public Owner() { }
    }
}
