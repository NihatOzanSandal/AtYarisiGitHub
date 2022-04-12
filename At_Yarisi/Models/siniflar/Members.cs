using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace At_Yarisi.Models.siniflar
{
    public class Members
    {
        //Bu veritabanın da oluşturmayı yaptı ama değişiklikleri yaparken olmayıca tabloyu silip kendim birdaha yazdım ??

        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "UserName")]
        public String UserName { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage ="Email is not Valid")]
        public String Email { get; set; }
        [Required]
        [Display(Name = "Password")]
        public String Password { get; set; }
        [Required]
        [Display(Name = "SecurityQuestion")]
        public String SecurityQuestion { get; set; }
        [Required]
        [Display(Name = "Answer")]
        public String Answer { get; set; }
        [Required]
        [Display(Name = "BirthDay")]
        public DateTime BirthDay { get; set; }
       
    }
}