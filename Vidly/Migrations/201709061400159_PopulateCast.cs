namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCast : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Casts Values('actor1, actor2, actor3'),('actor4, actor5, actor6')");
        }
        
        public override void Down()
        {
        }
    }
}
