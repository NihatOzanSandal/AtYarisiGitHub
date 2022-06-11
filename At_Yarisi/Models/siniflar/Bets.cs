using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace At_Yarisi.Models.siniflar
{
    public class Bets
    {


        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "MemberId")]
        public int MemberId { get; set; }

        [Required]
        [Display(Name = "AmountOfBet")]
        public double AmountOfBet { get; set; }

        [Required]
        [Display(Name = "TotalAmount")]
        public double TotalAmount { get; set; }


        [Required]
        [Display(Name = "RaceId")]
        public int RaceId { get; set; }

        [Required]
        [Display(Name = "CardId")]
        public int CardId { get; set; }

        [Required]
        [Display(Name = "HorseId")]
        public double HorseId { get; set; }
    }
}