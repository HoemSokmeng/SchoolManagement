using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    public class Student
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Sex { get; set; }
        public string? Department { get; set; }
        public ICollection<AttenStudent>? Attens { get; set; }

    }
}
