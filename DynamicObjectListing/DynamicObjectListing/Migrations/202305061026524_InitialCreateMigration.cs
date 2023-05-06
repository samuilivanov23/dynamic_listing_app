namespace DynamicObjectListing.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreateMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.activity_sessions",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Distance = c.Double(nullable: false),
                        ElevationGain = c.Int(nullable: false),
                        MaxElevation = c.Int(nullable: false),
                        TimeMovingMinutes = c.Int(nullable: false),
                        TotalTimeMinutes = c.Int(nullable: false),
                        KudosCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.athletes",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        ActivitiesCount = c.Int(nullable: false),
                        Followers = c.Int(nullable: false),
                        Following = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.segments",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Length = c.Double(nullable: false),
                        BestEffortTimeMinutes = c.Int(nullable: false),
                        StartLocation = c.String(),
                        EndLocation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.segments");
            DropTable("dbo.athletes");
            DropTable("dbo.activity_sessions");
        }
    }
}
