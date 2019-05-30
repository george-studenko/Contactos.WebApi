using System;
using System.ComponentModel.DataAnnotations;

namespace Contactos.Models{
    public class User{
        
        [Key]
        [Required]
        [Display(Name="Username")]
        [StringLength(20, ErrorMessage = "El valor para {0} debe contener entre {1} y {2} caracteres", MinimumLength=6)]
        public string Username {get; set;}
        
        [Required]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        [StringLength(100, ErrorMessage = "El valor para {0} debe contener entre {1} y {2} caracteres", MinimumLength=6)]
        public string Password {get;set;}
    }
}