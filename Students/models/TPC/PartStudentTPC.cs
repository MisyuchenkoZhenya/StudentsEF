using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.models.TPC
{
    public class PartStudentTPC : StudentTPC
    {
        public string FirstPartStudentField { get; set; }
        public int SecondPartStudentField { get; set; }
    }
}
