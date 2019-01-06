using System.ComponentModel.DataAnnotations;


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

    public class Staff : Person
    {
        [StringLength(20), Required]
        public string JobRole { get; set; }

        public BCPA_Departments Department { get; set; }

        [DataType(DataType.Currency),
         DisplayFormat(DataFormatString = "{0:c}", 
            ApplyFormatInEditMode = false)]
        public decimal Salary { get; set; }

    }
}
