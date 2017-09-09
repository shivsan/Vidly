namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        MemberShipId = c.Int(nullable: false),
                        MemberShipType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MemberShipTypes", t => t.MemberShipType_Id)
                .Index(t => t.MemberShipType_Id);
            
            CreateTable(
                "dbo.MemberShipTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            DropTable("dbo.MemberShipTypes");
            DropTable("dbo.Customers");
        }
    }
}
