using System;
using System.ComponentModel.DataAnnotations;

namespace Contactos.Models{
    public class Users{
        
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
        
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime Created { get; set; }     
    }
}