using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace AddEmployeeMigration.Entity

{
    public class EmployeeInfo
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage ="First name is required")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required")]
        [Display(Name ="Last Name")]
        public string LastName { get; set; }    

        [EmailAddress]
        [Required(ErrorMessage = "Email address ")]
        public string Email { get; set; }
    }
}
