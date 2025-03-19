using System.ComponentModel.DataAnnotations;

namespace Roles_Estructuras_Control.Models
{
    public class ProductoModels
    {
        public int Id { get; set; }
        [Display(Name = "Nombre del Producto")]
        [MinLength(3)]
        public string NombreProducto { get; set; }
        [Display(Name = "Presentacion del produto")]
        [MinLength(3)]
        public string Presentacion { get; set; }
        [Display(Name = "Codigo de Barras")]
        
        public int CodigoBarras { get; set; }
    }
}
