using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.models.TPT
{
    [Table("FullStudentTPT")]
    public class FullStudentTPT : StudentTPT
    {
        public string FullStudentField { get; set; }
    }
}
