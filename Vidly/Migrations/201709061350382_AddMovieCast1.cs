namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieCast1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Casts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Movies", "CastId");
            AddForeignKey("dbo.Movies", "CastId", "dbo.Casts", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Movies", "CastId", "dbo.Casts");
            DropIndex("dbo.Movies", new[] { "CastId" });
            DropTable("dbo.Casts");
        }
    }
}
