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
        public int MemberId { get; set; }

        [Required]
        [Display(Name = "UserName")]
        public String UserName { get; set; }
        //CHAR OLMALI 12 KARAKTER
        //***************
        [Required]
        [Display(Name = "CardNumber")]
        [MaxLength(12)]
        [MinLength(12)]
        public Char CardNumber { get; set; }
        //DENENMEDİ ŞUAN DB YOK
        //***************
        [Required]
        [Display(Name = "SecurityCode")]
        public int SecurityCode { get; set; }

        [Required]
        [Display(Name = "Month")]
        public int Month { get; set; }

        [Required]
        [Display(Name = "Year")]
        public int Year { get; set; }


    }
}