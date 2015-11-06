using System.Data.Entity;
using De.Brickmakers.Tutorials.EF.DatabaseLayer.Entities;

namespace De.Brickmakers.Tutorials.EF.DatabaseLayer
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
            : base("SchoolContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SchoolContext, Migrations.Configuration>("SchoolContext"));
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Standard> Standards { get; set; }

    }
}
