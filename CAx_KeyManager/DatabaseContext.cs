using System.Data.Entity;

namespace CAx_KeyManager
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=KeyManager_Database")
        { }
        public virtual DbSet<Key> Keys { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }
    }
}
