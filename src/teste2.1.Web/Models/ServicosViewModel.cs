using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace teste2._1.Web.Models
{
    public class ServicosViewModel
    {
        [Key]
     public int Codigo { get; set; }

        [MaxLength (50)]
        [MinLength (10)]
        [Required]
        public string Nome { get; set; }

        [Phone]
        [Required]
        public string Telefone { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }


    }
}