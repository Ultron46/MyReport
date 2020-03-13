using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;


namespace Training_TFS.Models
{
    public class Shopping
    {
        
        [Required(ErrorMessage = "Product Id is mandatory!")]
        [Display(Name = "IDs : ")]
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Please enter name")]
        [StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]
        [Display(Name = "Product Name : ")]
        public string ProductName { get; set; }
        
        [RegularExpression(@"^P[A-Z]\d{4}$", ErrorMessage = "Product Code should be of the type PA0001 ... PZ9999")]
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }
        [Required(ErrorMessage = "Please enter Quantity")]
        [Range(1, 500, ErrorMessage = "Please enter Quantity between 1-500")]
        public int Quantity { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Please enter Price as a number with at most two decimal places.")]
        [Required(ErrorMessage = "Please enter Price")]
        [Display(Name = "Product Price")]
        public float price { get; set; }

        [Required(ErrorMessage = "Please Enter Description")]
        [StringLength(30, ErrorMessage = "Do not enter more than 40 characters")]
        [Display(Name = "Product Description :")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Enter Color")]
        [Display(Name = "Product Color :")]
        public string Color { get; set; }

        [Display(Name = "Is In Stock :")]
        public bool InStock { get; set; }

        [Display(Name = "Product Category :")]
        public string Category { get; set; }

        [Display(Name = "Product Rating :")]
        [Range(1, 5, ErrorMessage = "Ratings between 1 to 5")]
        public int Rating { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}")]
        public DateTime ProductionDate { get; set; }

      

        [DisplayFormat(DataFormatString = "{0:dd/mm/yyyy}")]
        public DateTime ExpiryDate { get; set; }
    }
    public class ShoppingContext : DbContext
    {
        public DbSet<Shopping> Products { get; set; }

        public System.Data.Entity.DbSet<Training_TFS.Models.Shopping> Shoppings { get; set; }
    }
}