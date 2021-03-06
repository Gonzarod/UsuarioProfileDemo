using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuarioProfileService.Api.Models.UsuarioProfile
{
    public class CreateUsuarioProfileViewModel
    {
        // NOMBRE
        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(20, ErrorMessage = "Nombre permite hasta 20 caracteres")]
        [DataType(DataType.Text)]
        public string Nombre { get; set; }
        // APELLIDO
        [Required(ErrorMessage = "Apellido es requerido")]
        [StringLength(20, ErrorMessage = "Apellido permite hasta 20 caracteres")]
        [DataType(DataType.Text)]
        public string Apellido { get; set; }
        // CELULAR
        [StringLength(10, ErrorMessage = "Celular permite 10 caracteres")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Celular { get; set; }
        // CORREO
        [StringLength(50, ErrorMessage = "Correo permite 50 caracteres")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Correo { get; set; }
    }
}
