namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class atNoEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Horses", "HorseNumber", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Horses", "HorseNumber");
        }
    }
}
