using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace At_Yarisi.Models.siniflar
{
    public class PaymentMethod
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "MemberId")]
        public String MemberId { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public String UserName { get; set; }

        [Required]
        [Display(Name = "CardNumber")]
        public String CardNumber { get; set; }

        [Required]
        [Display(Name = "SecurityCode")]
        public String SecurityCode { get; set; }

        [Required]
        [Display(Name = "Month")]
        public String Month { get; set; }

        [Required]
        [Display(Name = "Year")]
        public String Year { get; set; }


    }
}