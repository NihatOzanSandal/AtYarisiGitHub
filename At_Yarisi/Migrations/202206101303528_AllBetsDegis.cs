namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AllBetsDegis : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AllBets", newName: "Bets");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Bets", newName: "AllBets");
        }
    }
}
