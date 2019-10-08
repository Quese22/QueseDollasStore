using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QueseDollas.Models
{
    public class Product
    {
        [Key] // this shows that the one immeditately under it set it as the unique identifier
        public int ProductID { get; set; }
        [Required] //has to have a value
        [Display(Name= "Product Name")] //changes this so this is what is shows instead of what it is identified as
        public string Name { get; set; }
        [Required]
        [Display(Name="# In Stock")]
        public int InventoryCount { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        [Display(Name="It is Food")]
        public bool IsFood { get; set; }
    }
}