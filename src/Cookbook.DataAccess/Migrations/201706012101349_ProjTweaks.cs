namespace MC.Internal.DevOps.MCDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ProjTweaks : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Project", "Branch", c => c.String());
            AddColumn("dbo.Project", "ProjectType", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Project", "ProjectType");
            DropColumn("dbo.Project", "Branch");
        }
    }
}
