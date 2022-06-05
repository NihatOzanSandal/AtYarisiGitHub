namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class HorseTablosuAdd : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Horses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        HorseName = c.String(nullable: false),
                        HorseRatio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Horses");
        }
    }
}
