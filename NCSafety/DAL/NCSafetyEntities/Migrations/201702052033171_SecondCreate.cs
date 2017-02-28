namespace NCSafety.DAL.NCSafetyEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.School", "ascDeanEmail", c => c.String());
            DropColumn("dbo.Lab", "labType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Lab", "labType", c => c.String());
            DropColumn("dbo.School", "ascDeanEmail");
        }
    }
}
