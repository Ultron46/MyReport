using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Training_TFS.Models
{
    public class Student
    {

        [Key]
      
        public int studentId { get; set; }
        [Required(ErrorMessage = "firstname is required.")]
        [MaxLength(50)]
      
        public string FirstName { get; set; }
        [Required(ErrorMessage = "lastname is required.")]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "address is required.")]
        [StringLength(50)]
        public string address { get; set; }
        [Required(ErrorMessage = "date of birth is required.")]
        [DisplayFormat(DataFormatString = "{0:dd MMM yyyy}")]
        [Display(Name = "Date of Birthday")]
        [DataType(DataType.Date)]
        
        public DateTime dob { get; set; }
        [Required(ErrorMessage = "mobile number is required.")]
        [MaxLength(10)]

        public int mobileNumber { get; set; }
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Enrollment number is required.")]
       
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int enrollmentNumber { get; set; }
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "city is required.")]
        public string city { get; set; }
        [Required(ErrorMessage = "age is required.")]
        public int Age { get; set; }
      

    }
}