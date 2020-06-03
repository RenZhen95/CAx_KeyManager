using System;
using System.ComponentModel.DataAnnotations;

namespace CAx_KeyManager
{
    [Serializable]
    public class Owner
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public Owner() { }
    }
}
