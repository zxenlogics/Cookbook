using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

using MC.Internal.DevOps.Entities;

namespace MC.Internal.DevOps.MCDataAccess
{
    public class MCDbContext : DbContext
    {
        public MCDbContext() : base("DefaultConnection")
        {
            // Provides EF Logging for debugging
            Database.Log = sql => System.Diagnostics.Debug.Write(sql);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();



            modelBuilder.Entity<Environment>()
                .HasOptional(p => p.Project);
         
            modelBuilder.Entity<Project>()
                .HasRequired(x => x.Environments);

            //modelBuilder.Entity<Blog>()
            //.Property(b => b.Created)
            //.HasDefaultValueSql("getdate()");

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Environment> Environments { get; set; }
        public DbSet<EnvironmentType> EnvironmentTypes { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Server> Servers { get; set; }
        public DbSet<ServerRole> ServerRoles { get; set; }               
        public DbSet<DbInstance> DbInstances { get; set; }
        public DbSet<MC.Internal.DevOps.Entities.Database> Databases { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Branch> Branches { get; set; }
        //public DbSet<EnvironmentDatabase> EnvironmentDatabases { get; set; }
    }
}
