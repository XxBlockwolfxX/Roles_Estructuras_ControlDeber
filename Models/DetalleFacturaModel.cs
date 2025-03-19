namespace Roles_Estructuras_Control.Models
{
    public class DetalleFacturaModel
    {
        public int Id { get; set; }
        public int Cantidad { get; set; }
        public float Valor { get; set; }

        //Relacion Productos
        public int ProductoModelsId { get; set; }
        public ProductoModels ProductoModels { get; set; }

        //Relacion Factura
        public int FacturaModelId { get; set; }
        public FacturaModel FacturaModel { get; set; }

        //relacion Stock
        public int StockModelsId { get; set; }
        public StockModels StockModels { get; set; }

    }
}
