using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.models.TPH;

namespace Students.context.TPH
{
    public class ContextTPH : DbContext
    {
        public ContextTPH()
            : base("StudentsTPH")
        { }

        public DbSet<StudentTPH> Stud { get; set; }
        public DbSet<FullStudentTPH> FullStud { get; set; }
        public DbSet<PartStudentTPH> PartStud { get; set; }
    }
}
