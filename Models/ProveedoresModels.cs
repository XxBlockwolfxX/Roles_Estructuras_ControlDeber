using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Roles_Estructuras_Control.Models
{
    public class ProveedoresModels
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del Proveedor")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [MinLength(3, ErrorMessage ="El campo requiere minimo de 3 letras")]
        public string NombreProveedor { get; set; }
        [Display(Name = "Direccion")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [MinLength(3, ErrorMessage = "El campo requiere minimo de 3 letras")]
        public string Direccion { get; set; }
        [Display(Name = "Telefono")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [MinLength(3, ErrorMessage = "El campo requiere minimo de 3 letras")]
        public string Telefono { get; set; }
        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El campo es obligatorio")]
        [MinLength(3, ErrorMessage = "El campo requiere minimo de 3 letras")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage ="No es un formato de correo electronico")]
        public string Correo { get; set; }

    }
}
