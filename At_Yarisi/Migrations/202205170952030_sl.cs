namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class sl : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.PaymentMethods");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        UserName = c.String(nullable: false),
                        SecurityCode = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Year = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
    }
}
