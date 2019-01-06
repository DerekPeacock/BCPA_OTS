using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BCPA_OTS.Models
{
    public enum BCPA_Departments
    {
        Sales,
        Finance,
        Support,
        Catering,
        Manager
    }

    public class Staff
    {
        [Key]
        [ForeignKey("Person")]
        public int StaffID { get; set; }

        [StringLength(20), Required]
        public string JobRole { get; set; }

        public BCPA_Departments Department { get; set; }

        [DataType(DataType.Currency),
         DisplayFormat(DataFormatString = "{0:c}", 
            ApplyFormatInEditMode = false)]
        public decimal Salary { get; set; }

        public virtual Person Person { get; set; }

    }
}
