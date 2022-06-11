namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BetsSil : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Bets");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Bets",
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
    }
}
