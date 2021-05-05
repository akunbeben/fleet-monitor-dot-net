namespace FleetMonitoring.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOwnerAndUnitTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        OwnerId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        CreatedBy = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.OwnerId);
            
            CreateTable(
                "dbo.Unit",
                c => new
                    {
                        UnitId = c.Int(nullable: false, identity: true),
                        Identity = c.String(),
                        Name = c.String(),
                        Description = c.String(),
                        CreatedBy = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                        Owner_OwnerId = c.Int(),
                    })
                .PrimaryKey(t => t.UnitId)
                .ForeignKey("dbo.Owner", t => t.Owner_OwnerId)
                .Index(t => t.Owner_OwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Unit", "Owner_OwnerId", "dbo.Owner");
            DropIndex("dbo.Unit", new[] { "Owner_OwnerId" });
            DropTable("dbo.Unit");
            DropTable("dbo.Owner");
        }
    }
}
