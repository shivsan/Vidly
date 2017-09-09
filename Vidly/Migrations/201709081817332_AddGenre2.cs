namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddGenre2 : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Movies", "CastId", "dbo.Casts");
            //DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            //DropIndex("dbo.Movies", new[] { "GenreId" });
            //DropIndex("dbo.Movies", new[] { "CastId" });
            //AlterColumn("dbo.Movies", "GenreId", c => c.Int());
            //AlterColumn("dbo.Movies", "CastId", c => c.Int());
            //CreateIndex("dbo.Movies", "GenreId");
            //CreateIndex("dbo.Movies", "CastId");
            //AddForeignKey("dbo.Movies", "CastId", "dbo.Casts", "Id");
            //AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id");
        }
        
        public override void Down()
        {
            //DropForeignKey("dbo.Movies", "GenreId", "dbo.Genres");
            //DropForeignKey("dbo.Movies", "CastId", "dbo.Casts");
            //DropIndex("dbo.Movies", new[] { "CastId" });
            //DropIndex("dbo.Movies", new[] { "GenreId" });
            //AlterColumn("dbo.Movies", "CastId", c => c.Int(nullable: false));
            //AlterColumn("dbo.Movies", "GenreId", c => c.Int(nullable: false));
            //CreateIndex("dbo.Movies", "CastId");
            //CreateIndex("dbo.Movies", "GenreId");
            //AddForeignKey("dbo.Movies", "GenreId", "dbo.Genres", "Id", cascadeDelete: true);
            //AddForeignKey("dbo.Movies", "CastId", "dbo.Casts", "Id", cascadeDelete: true);
        }
    }
}
