using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Roles_Estructuras_Control.Models
{
    public class FacturaModel
    {
        public int Id { get; set; }
        public DateOnly FechaIngreso { get; set; }
        [Display(Name = "Numero de Factura")]
        public int NumeroFactura { get; set; }

        //Relacion Cliente
        
        public int ClientesModelId { get; set; }
        public ClientesModel ClientesModel { get; set; }
    }
}
