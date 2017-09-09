namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomer1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipType_Id" });
            RenameColumn(table: "dbo.Customers", name: "MemberShipType_Id", newName: "MemberShipTypeId");
            AlterColumn("dbo.Customers", "Firstname", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Customers", "MemberShipTypeId");
            AddForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes", "Id", cascadeDelete: true);
            DropColumn("dbo.Customers", "MemberShipId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "MemberShipId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Customers", "MemberShipTypeId", "dbo.MemberShipTypes");
            DropIndex("dbo.Customers", new[] { "MemberShipTypeId" });
            AlterColumn("dbo.Customers", "MemberShipTypeId", c => c.Int());
            AlterColumn("dbo.Customers", "Firstname", c => c.String());
            RenameColumn(table: "dbo.Customers", name: "MemberShipTypeId", newName: "MemberShipType_Id");
            CreateIndex("dbo.Customers", "MemberShipType_Id");
            AddForeignKey("dbo.Customers", "MemberShipType_Id", "dbo.MemberShipTypes", "Id");
        }
    }
}
