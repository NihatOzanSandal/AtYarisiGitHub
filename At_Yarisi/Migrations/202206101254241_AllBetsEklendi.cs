namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllBetsEklendi : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AllBets",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MemberId = c.Int(nullable: false),
                        AmountOfBet = c.Double(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        RaceId = c.Int(nullable: false),
                        CardId = c.Int(nullable: false),
                        HorseId = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AllBets");
        }
    }
}
