namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbDenemesi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Members",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        SecurityQuestion = c.String(nullable: false),
                        Answer = c.String(nullable: false),
                        BirthDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Members");
        }
    }
}
