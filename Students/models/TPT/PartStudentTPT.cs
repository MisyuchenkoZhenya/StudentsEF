using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.models.TPT
{
    [Table("PartStudentTPT")]
    public class PartStudentTPT : StudentTPT
    {
        public string FirstPartStudentField { get; set; }
        public int SecondPartStudentField { get; set; }
    }
}
