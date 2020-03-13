using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Training_TFS.Models
{
    public class Employee
    {
        [ScaffoldColumn(false)]
        public int EmployeeId { get; set; }

        [Required (ErrorMessage ="Name is Required")]
        [StringLength(80)]
        public string Name { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required(ErrorMessage = "Email is Required")]
        [EmailAddress]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}" , ErrorMessage = "Incorrect Email format")]
        public string Email { get; set; }

        [Required]
        [Compare("Email",ErrorMessage ="Email Not Match")]
        public string ConfirmEmail { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        [DisplayName("Contact Number")]
        [Phone]
        public int ContactNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        
        public string Nationality { get; set; }

        [Required]
        [DisplayName("Marital Status")]
        public string MaritalStatus { get; set; }

        [Required]
        [Range(18,120,ErrorMessage ="Age must be between 18 to 120")]
        public int Age { get; set; }

        [Required]
        public string Skills { get; set; }

        [Required]
        public string Qualification { get; set; }

        [Required]
        public string AdharNumber { get; set; }
        
        public string PassportNumber { get; set;  }

        [Url]
        public string LinkedInProfile { get; set; }
       
    }
}