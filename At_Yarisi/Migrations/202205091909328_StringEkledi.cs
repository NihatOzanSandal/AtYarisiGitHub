namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StringEkledi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MemberId = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        CardNumber = c.String(nullable: false),
                        SecurityCode = c.String(nullable: false),
                        Month = c.String(nullable: false),
                        Year = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentMethods");
        }
    }
}
