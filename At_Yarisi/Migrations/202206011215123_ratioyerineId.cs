namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ratioyerineId : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bets", "HorseId", c => c.Double(nullable: false));
            DropColumn("dbo.Bets", "HorseNumberId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bets", "HorseNumberId", c => c.Double(nullable: false));
            DropColumn("dbo.Bets", "HorseId");
        }
    }
}
