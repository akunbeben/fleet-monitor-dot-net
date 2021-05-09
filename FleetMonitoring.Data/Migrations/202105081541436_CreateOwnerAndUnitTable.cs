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
                        OwnerId = c.Int(nullable: false),
                        CreatedBy = c.String(),
                        CreatedAt = c.DateTime(nullable: false),
                        UpdatedAt = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UnitId)
                .ForeignKey("dbo.Owner", t => t.OwnerId, cascadeDelete: true)
                .Index(t => t.OwnerId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Unit", "OwnerId", "dbo.Owner");
            DropIndex("dbo.Unit", new[] { "OwnerId" });
            DropTable("dbo.Unit");
            DropTable("dbo.Owner");
        }
    }
}
