namespace NCSafety.DAL.NCSafetyEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Equipment",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        eqName = c.String(nullable: false),
                        labID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lab", t => t.labID)
                .Index(t => t.labID);
            
            CreateTable(
                "dbo.Lab",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        labBuilding = c.String(nullable: false),
                        labNumber = c.String(nullable: false),
                        labType = c.String(),
                        schID = c.Int(nullable: false),
                        School_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.School", t => t.School_ID)
                .Index(t => t.School_ID);
            
            CreateTable(
                "dbo.Hazard",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        hazName = c.String(nullable: false),
                        hazDescription = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Item",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        itemArea = c.String(nullable: false),
                        itemHazComment = c.String(nullable: false),
                        itemCorrActionDt = c.DateTime(nullable: false),
                        itemCorrActionCompleted = c.DateTime(nullable: false),
                        itemComment = c.String(),
                        InspectionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Inspection", t => t.InspectionID)
                .Index(t => t.InspectionID);
            
            CreateTable(
                "dbo.Inspection",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        schID = c.Int(nullable: false),
                        labID = c.Int(nullable: false),
                        inspDate = c.DateTime(nullable: false),
                        School_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Lab", t => t.labID)
                .ForeignKey("dbo.School", t => t.School_ID)
                .Index(t => t.labID)
                .Index(t => t.School_ID);
            
            CreateTable(
                "dbo.School",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        schName = c.String(nullable: false),
                        ascDeanFirst = c.String(),
                        ascDeanLast = c.String(),
                        ascDeanAssistantEmail = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.ItemHazard",
                c => new
                    {
                        Item_ID = c.Int(nullable: false),
                        Hazard_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Item_ID, t.Hazard_ID })
                .ForeignKey("dbo.Item", t => t.Item_ID, cascadeDelete: true)
                .ForeignKey("dbo.Hazard", t => t.Hazard_ID, cascadeDelete: true)
                .Index(t => t.Item_ID)
                .Index(t => t.Hazard_ID);
            
            CreateTable(
                "dbo.HazardLab",
                c => new
                    {
                        Hazard_ID = c.Int(nullable: false),
                        Lab_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Hazard_ID, t.Lab_ID })
                .ForeignKey("dbo.Hazard", t => t.Hazard_ID, cascadeDelete: true)
                .ForeignKey("dbo.Lab", t => t.Lab_ID, cascadeDelete: true)
                .Index(t => t.Hazard_ID)
                .Index(t => t.Lab_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HazardLab", "Lab_ID", "dbo.Lab");
            DropForeignKey("dbo.HazardLab", "Hazard_ID", "dbo.Hazard");
            DropForeignKey("dbo.Inspection", "School_ID", "dbo.School");
            DropForeignKey("dbo.Lab", "School_ID", "dbo.School");
            DropForeignKey("dbo.Inspection", "labID", "dbo.Lab");
            DropForeignKey("dbo.Item", "InspectionID", "dbo.Inspection");
            DropForeignKey("dbo.ItemHazard", "Hazard_ID", "dbo.Hazard");
            DropForeignKey("dbo.ItemHazard", "Item_ID", "dbo.Item");
            DropForeignKey("dbo.Equipment", "labID", "dbo.Lab");
            DropIndex("dbo.HazardLab", new[] { "Lab_ID" });
            DropIndex("dbo.HazardLab", new[] { "Hazard_ID" });
            DropIndex("dbo.ItemHazard", new[] { "Hazard_ID" });
            DropIndex("dbo.ItemHazard", new[] { "Item_ID" });
            DropIndex("dbo.Inspection", new[] { "School_ID" });
            DropIndex("dbo.Inspection", new[] { "labID" });
            DropIndex("dbo.Item", new[] { "InspectionID" });
            DropIndex("dbo.Lab", new[] { "School_ID" });
            DropIndex("dbo.Equipment", new[] { "labID" });
            DropTable("dbo.HazardLab");
            DropTable("dbo.ItemHazard");
            DropTable("dbo.School");
            DropTable("dbo.Inspection");
            DropTable("dbo.Item");
            DropTable("dbo.Hazard");
            DropTable("dbo.Lab");
            DropTable("dbo.Equipment");
        }
    }
}
