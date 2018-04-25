using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.models.TPT;

namespace Students.context.TPT
{
    public class ContextTPT : DbContext
    {
        public ContextTPT()
            : base("StudentsTPT")
        { }

        public DbSet<StudentTPT> Stud { get; set; }
        public DbSet<FullStudentTPT> FullStud { get; set; }
        public DbSet<PartStudentTPT> PartStud { get; set; }
    }
}
