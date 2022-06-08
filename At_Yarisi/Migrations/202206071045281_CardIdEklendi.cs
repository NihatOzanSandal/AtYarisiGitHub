namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CardIdEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bets", "CardId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bets", "CardId");
        }
    }
}
