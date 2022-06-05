using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace At_Yarisi.Models.siniflar
{
    public class Horse
    {

        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "HorseName")]
        public String HorseName { get; set; }

        [Required]
        [Display(Name = "HorseRatio")]
        public double HorseRatio { get; set; }

        [Required]
        [Display(Name = "HorseNumber")]
        public int HorseNumber { get; set; }


    }
}