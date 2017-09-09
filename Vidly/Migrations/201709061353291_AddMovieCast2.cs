namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMovieCast2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Casts", "Actors", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Casts", "Actors");
        }
    }
}
