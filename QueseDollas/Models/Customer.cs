using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QueseDollas.Models
{
    public class Customer
    {
        //ID
        //firstName
        //LastName
        //contact info
        //IsPleasant
        [Key]
        public int CustomerID { get; set; }
        [Required]
        [Display(Name="First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display (Name ="Last Name")]
        public string LastName { get; set; }
        [Required]
        [Display (Name ="Cell phone Number")]
        public int ContactInfo { get; set; }
        [Required]
        [Display (Name ="Would you recommend this customer?")]
        public bool IsPleasant { get; set; }
    }
}