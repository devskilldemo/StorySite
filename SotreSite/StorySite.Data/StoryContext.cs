using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorySite.Data
{
    public class StoryContext : DbContext
    {
        public StoryContext()
            :base("name=DefaultConnection")
        {
            //Database.SetInitializer<StoryContext>(null);
        }

        public DbSet<Story> Story { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
