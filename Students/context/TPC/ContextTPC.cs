using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.models.TPC;

namespace Students.context.TPC
{
    public class ContextTPC : DbContext
    {
        public ContextTPC()
            : base("StudentsTPC")
        { }

        public DbSet<StudentTPC> Stud { get; set; }
        public DbSet<FullStudentTPC> FullStud { get; set; }
        public DbSet<PartStudentTPC> PartStud { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FullStudentTPC>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("FullStud");
            });
            modelBuilder.Entity<PartStudentTPC>().Map(m =>
            {
                m.MapInheritedProperties();
                m.ToTable("PartStud");
            });
        }
    }
}
