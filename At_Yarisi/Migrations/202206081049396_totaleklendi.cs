namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class totaleklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bets", "TotalAmount", c => c.Double(nullable: false));
            DropColumn("dbo.Bets", "EarningAmount");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bets", "EarningAmount", c => c.Double(nullable: false));
            DropColumn("dbo.Bets", "TotalAmount");
        }
    }
}
