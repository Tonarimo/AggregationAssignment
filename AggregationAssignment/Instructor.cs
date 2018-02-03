using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregationAssignment
{
    class Instructor
    {
        public Instructor()
        {

        }

        public Instructor(string name, string email, string officeLocation)
        {
            Name = name;
            email = Email;
            OfficeLocation = officeLocation;
        }

        [Key]
        public int InstructorID { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string OfficeLocation { get; set; }

        public override string ToString()
        {
            return Name + "\n" + Email + "\n" + OfficeLocation + "\n";
        }
    }
}
