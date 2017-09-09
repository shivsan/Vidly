namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieYear : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "Year", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "Year");
        }
    }
}
