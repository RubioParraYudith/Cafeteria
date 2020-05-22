namespace Café.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateFirstMigration : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Users");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SupplierCode = c.Int(nullable: false),
                        UserName = c.String(),
                        Email = c.String(),
                        Phone = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
    }
}
