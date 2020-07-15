namespace CAx_KeyManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddOwnerName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Keys", "OwnerName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Keys", "OwnerName");
        }
    }
}
