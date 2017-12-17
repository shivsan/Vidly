namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addedevent : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventLogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ControllerName = c.String(),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventLogs");
        }
    }
}
