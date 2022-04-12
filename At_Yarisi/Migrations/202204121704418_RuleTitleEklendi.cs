namespace At_Yarisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RuleTitleEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rules", "RuleTitle", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rules", "RuleTitle");
        }
    }
}
