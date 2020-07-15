namespace CAx_KeyManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Keys",
                c => new
                    {
                        KeyID = c.Int(nullable: false, identity: true),
                        RoomID = c.String(),
                        UniqueID = c.String(),
                        OwnerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.KeyID)
                .ForeignKey("dbo.Owners", t => t.OwnerID, cascadeDelete: true)
                .Index(t => t.OwnerID);
            
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.OwnerID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Keys", "OwnerID", "dbo.Owners");
            DropIndex("dbo.Keys", new[] { "OwnerID" });
            DropTable("dbo.Owners");
            DropTable("dbo.Keys");
        }
    }
}
