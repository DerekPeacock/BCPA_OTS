using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    public class Staff
    {
        [ForeignKey("Person")]
        public int StaffID { get; set; }

        public string JobRole { get; set; }

        public string Department { get; set; }

        public Person Person { get; set; }

    }
}
