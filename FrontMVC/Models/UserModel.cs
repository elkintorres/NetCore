using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FrontMVC.Models
{
    public class UserModel
    {
        [DisplayName("Usuario")]
        [MaxLength(15)]
        [Required]
        public string UserName { get; set; }

        [DisplayName("Contraseña")]
        [MaxLength(30)]
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
    }
}
