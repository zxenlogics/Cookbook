namespace MC.Internal.DevOps.MCDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Client",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Abbreviation = c.String(nullable: false, maxLength: 5),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Database",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    DBInstanceId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.DBInstance", t => t.DBInstanceId, cascadeDelete: true)
                .Index(t => t.DBInstanceId);

            CreateTable(
                "dbo.DBInstance",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    DBEngineId = c.Int(nullable: false),
                    DBEngine = c.String(),
                    ServerId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Server", t => t.ServerId, cascadeDelete: true)
                .Index(t => t.ServerId);

            CreateTable(
                "dbo.Server",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Hostname = c.String(nullable: false),
                    IP = c.String(nullable: false),
                    DomainId = c.Int(nullable: false),
                    EnvironmentId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Domain", t => t.DomainId, cascadeDelete: true)
                .ForeignKey("dbo.Environment", t => t.EnvironmentId, cascadeDelete: true)
                .Index(t => t.DomainId)
                .Index(t => t.EnvironmentId);

            CreateTable(
                "dbo.Domain",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    DomainAbbreviation = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Environment",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    IsCluster = c.Boolean(nullable: false),
                    ClientId = c.Int(nullable: false),
                    EnvironmentTypeId = c.Int(nullable: false),
                    Project_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Client", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.EnvironmentType", t => t.EnvironmentTypeId, cascadeDelete: true)
                .ForeignKey("dbo.Project", t => t.Project_Id)
                .Index(t => t.ClientId)
                .Index(t => t.EnvironmentTypeId)
                .Index(t => t.Project_Id);

            CreateTable(
                "dbo.EnvironmentType",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.ServerRole",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    Description = c.String(nullable: false),
                    Server_Id = c.Int(),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Server", t => t.Server_Id)
                .Index(t => t.Server_Id);

            CreateTable(
                "dbo.Project",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.Team",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Name = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TeamMember",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    TeamId = c.Int(nullable: false),
                    UserId = c.Int(nullable: false),
                    IsActive = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.User", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.Team", t => t.TeamId, cascadeDelete: true)
                .Index(t => t.TeamId)
                .Index(t => t.UserId);

            CreateTable(
                "dbo.User",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    FirstName = c.String(nullable: false),
                    LastName = c.String(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            CreateTable(
                "dbo.TeamProject",
                c => new
                {
                    Team_Id = c.Int(nullable: false),
                    Project_Id = c.Int(nullable: false),
                })
                .PrimaryKey(t => new { t.Team_Id, t.Project_Id })
                .ForeignKey("dbo.Team", t => t.Team_Id, cascadeDelete: true)
                .ForeignKey("dbo.Project", t => t.Project_Id, cascadeDelete: true)
                .Index(t => t.Team_Id)
                .Index(t => t.Project_Id);

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TeamMember", "TeamId", "dbo.Team");
            DropForeignKey("dbo.TeamMember", "UserId", "dbo.User");
            DropForeignKey("dbo.TeamProject", "Project_Id", "dbo.Project");
            DropForeignKey("dbo.TeamProject", "Team_Id", "dbo.Team");
            DropForeignKey("dbo.Environment", "Project_Id", "dbo.Project");
            DropForeignKey("dbo.DBInstance", "ServerId", "dbo.Server");
            DropForeignKey("dbo.ServerRole", "Server_Id", "dbo.Server");
            DropForeignKey("dbo.Server", "EnvironmentId", "dbo.Environment");
            DropForeignKey("dbo.Environment", "EnvironmentTypeId", "dbo.EnvironmentType");
            DropForeignKey("dbo.Environment", "ClientId", "dbo.Client");
            DropForeignKey("dbo.Server", "DomainId", "dbo.Domain");
            DropForeignKey("dbo.Database", "DBInstanceId", "dbo.DBInstance");
            DropIndex("dbo.TeamProject", new[] { "Project_Id" });
            DropIndex("dbo.TeamProject", new[] { "Team_Id" });
            DropIndex("dbo.TeamMember", new[] { "UserId" });
            DropIndex("dbo.TeamMember", new[] { "TeamId" });
            DropIndex("dbo.ServerRole", new[] { "Server_Id" });
            DropIndex("dbo.Environment", new[] { "Project_Id" });
            DropIndex("dbo.Environment", new[] { "EnvironmentTypeId" });
            DropIndex("dbo.Environment", new[] { "ClientId" });
            DropIndex("dbo.Server", new[] { "EnvironmentId" });
            DropIndex("dbo.Server", new[] { "DomainId" });
            DropIndex("dbo.DBInstance", new[] { "ServerId" });
            DropIndex("dbo.Database", new[] { "DBInstanceId" });
            DropTable("dbo.TeamProject");
            DropTable("dbo.User");
            DropTable("dbo.TeamMember");
            DropTable("dbo.Team");
            DropTable("dbo.Project");
            DropTable("dbo.ServerRole");
            DropTable("dbo.EnvironmentType");
            DropTable("dbo.Environment");
            DropTable("dbo.Domain");
            DropTable("dbo.Server");
            DropTable("dbo.DBInstance");
            DropTable("dbo.Database");
            DropTable("dbo.Client");
        }
    }
}
