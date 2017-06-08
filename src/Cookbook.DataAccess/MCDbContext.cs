using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Annotations;
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



            //modelBuilder.Entity<Environment>()
            //    .HasRequired<Project>(p => p.Project)
            //    .WithMany(p => p.Environments)
            //    .HasForeignKey(p => p.ProjectId);

            modelBuilder.Entity<Environment>()
                .HasOptional(p => p.Project)
                .WithMany(p => p.Environments);


            modelBuilder.Entity<EnvironmentDatabase>()
                .HasKey(edb => new {edb.EnvironmentId, edb.DatabaseId});
            modelBuilder.Entity<EnvironmentDatabase>()
                .HasRequired(d => d.Environment)
                .WithMany(d => d.Databases);
            modelBuilder.Entity<EnvironmentDatabase>()
                .HasRequired(d => d.Database);
            //modelBuilder.Entity<EnvironmentDatabase>()
            //    .Property(d => d.DatabaseId)
            //    .IsRequired()
            //    .HasColumnAnnotation("Index",
            //        new IndexAnnotation(new IndexAttribute("IX_DatabaseId") { IsUnique = true }));




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
        public DbSet<EnvironmentDatabase> EnvironmentDatabases { get; set; }
    }
}
