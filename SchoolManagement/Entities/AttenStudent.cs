using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Entities
{
    public class AttenStudent
    {
        public int Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public uint TimeShift { get; set; }

    }
}
