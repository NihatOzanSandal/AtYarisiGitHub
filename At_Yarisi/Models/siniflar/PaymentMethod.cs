using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace At_Yarisi.Models.siniflar
{
    public class PaymentMethod
    {
        //Ay ve yıla max değerler atanmalı

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
        //16 KARAKTER İLE DEĞİŞTİR
        public string CardNumber { get; set; }
        //DENENMEDİ ŞUAN DB YOK
        //***************
        [Required]
        [Display(Name = "SecurityCode")]
        public int SecurityCode { get; set; }

        [Required]
        [Display(Name = "Month")]
        //[MaxLength(12)]
        public int Month { get; set; }

        [Required]
        [Display(Name = "Year")]
        //[MaxLength(9999)]        
        public int Year { get; set; }


    }
}