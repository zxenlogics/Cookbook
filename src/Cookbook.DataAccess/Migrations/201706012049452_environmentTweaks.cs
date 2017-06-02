namespace MC.Internal.DevOps.MCDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class environmentTweaks : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ServerRole", "Server_Id", "dbo.Server");
            DropForeignKey("dbo.Environment", "Project_Id", "dbo.Project");
            DropIndex("dbo.Environment", new[] { "Project_Id" });
            DropIndex("dbo.ServerRole", new[] { "Server_Id" });
            CreateTable(
                "dbo.ProjectEnvironment",
                c => new
                    {
                        Project_Id = c.Int(nullable: false),
                        Environment_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Project_Id, t.Environment_Id })
                .ForeignKey("dbo.Project", t => t.Project_Id, cascadeDelete: true)
                .ForeignKey("dbo.Environment", t => t.Environment_Id, cascadeDelete: true)
                .Index(t => t.Project_Id)
                .Index(t => t.Environment_Id);
            
            CreateTable(
                "dbo.ServerRoleServer",
                c => new
                    {
                        ServerRole_Id = c.Int(nullable: false),
                        Server_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ServerRole_Id, t.Server_Id })
                .ForeignKey("dbo.ServerRole", t => t.ServerRole_Id, cascadeDelete: true)
                .ForeignKey("dbo.Server", t => t.Server_Id, cascadeDelete: true)
                .Index(t => t.ServerRole_Id)
                .Index(t => t.Server_Id);
            
            AddColumn("dbo.Environment", "State", c => c.String());
            AddColumn("dbo.Environment", "CurrentVersion", c => c.String());
            AddColumn("dbo.Environment", "TargetVersion", c => c.String());
            AddColumn("dbo.Environment", "Notes", c => c.String());
            AddColumn("dbo.Environment", "LastUpdated", c => c.DateTime(nullable: false));
            DropColumn("dbo.Environment", "Project_Id");
            DropColumn("dbo.ServerRole", "Server_Id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ServerRole", "Server_Id", c => c.Int());
            AddColumn("dbo.Environment", "Project_Id", c => c.Int());
            DropForeignKey("dbo.ServerRoleServer", "Server_Id", "dbo.Server");
            DropForeignKey("dbo.ServerRoleServer", "ServerRole_Id", "dbo.ServerRole");
            DropForeignKey("dbo.ProjectEnvironment", "Environment_Id", "dbo.Environment");
            DropForeignKey("dbo.ProjectEnvironment", "Project_Id", "dbo.Project");
            DropIndex("dbo.ServerRoleServer", new[] { "Server_Id" });
            DropIndex("dbo.ServerRoleServer", new[] { "ServerRole_Id" });
            DropIndex("dbo.ProjectEnvironment", new[] { "Environment_Id" });
            DropIndex("dbo.ProjectEnvironment", new[] { "Project_Id" });
            DropColumn("dbo.Environment", "LastUpdated");
            DropColumn("dbo.Environment", "Notes");
            DropColumn("dbo.Environment", "TargetVersion");
            DropColumn("dbo.Environment", "CurrentVersion");
            DropColumn("dbo.Environment", "State");
            DropTable("dbo.ServerRoleServer");
            DropTable("dbo.ProjectEnvironment");
            CreateIndex("dbo.ServerRole", "Server_Id");
            CreateIndex("dbo.Environment", "Project_Id");
            AddForeignKey("dbo.Environment", "Project_Id", "dbo.Project", "Id");
            AddForeignKey("dbo.ServerRole", "Server_Id", "dbo.Server", "Id");
        }
    }
}
