﻿using System.ComponentModel.DataAnnotations;

namespace Roles_Estructuras_Control.Models
{
    public class StockModels
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        public int Cantidad { get; set; }
        [Required(ErrorMessage ="El campo es requerido")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de Fabricacion")]
        public DateOnly FechaFabricacion { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [DataType(DataType.Date)]
        public DateOnly FechaVencimiento { get; set; }
        [Required(ErrorMessage = "El campo es requerido")]
        [DataType(DataType.Date)]
        public DateOnly FechaRegistro { get; set; }
        public int Precio { get; set; }

        //Relacion con producto
        public int ProductoModelsId { get; set; }
        public ProductoModels ProductoModels { get; set; }

        //Relacion con proveedor
        public int ProveedoresModelsId { get; set; }
        public ProveedoresModels ProveedoresModels { get; set; }

    }
}
