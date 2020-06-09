using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CAx_KeyManager
{
    public class Owner
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        public Owner() { }
    }
}
