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
        [Required(ErrorMessage = "Please enter Id")]
        [Key]
        public int ProductId { get; set; }

        [Required(ErrorMessage= "Please enter name")]
        [StringLength(30, ErrorMessage = "Do not enter more than 30 characters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Please enter Quantity")]
        [Range(1, 500, ErrorMessage = "Please enter Quantity between 1-500")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Please enter Price")]
        public float price { get; set; }

        [StringLength(30, ErrorMessage = "Do not enter more than 40 characters")]
        public string ShortDescription { get; set; }

        public string Color { get; set; }

        public string Category { get; set; }
        [Range(1, 5, ErrorMessage = "Ratings between 1 to 5")]
        public int Rating { get; set; }
    }

    public class ShoppingContext : DbContext
    {
        public DbSet<Shopping> Products { get; set; }

        public System.Data.Entity.DbSet<Training_TFS.Models.Shopping> Shoppings { get; set; }
    }
}