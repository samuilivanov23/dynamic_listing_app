namespace DynamicObjectListing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adding_session_analysis_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.session_analysis",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        HeartRateMin = c.Int(nullable: false),
                        HeartRateMax = c.Int(nullable: false),
                        HeartRateAvg = c.Int(nullable: false),
                        PowerAvg = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.session_analysis");
        }
    }
}
