using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace At_Yarisi.Models.siniflar
{
    public class Rules
    {
        [Key]
        public int ID { get; set; }
        [Required]

        public String RuleTitle { get; set; }
        [Required]
        public String Rule { get; set; }




    }
}