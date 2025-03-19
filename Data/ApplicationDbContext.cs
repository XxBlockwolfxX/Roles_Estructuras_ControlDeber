using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Roles_Estructuras_Control.Models;

namespace Roles_Estructuras_Control.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<ProveedoresModels> Proveedores { get; set; }
    public DbSet<ProductoModels> Productos { get; set; }
    public DbSet<StockModels> Stock { get; set; }
    public DbSet<ClientesModel> Clientes { get; set; }
    public DbSet<FacturaModel> Facturas { get; set; }
    public DbSet<DetalleFacturaModel> DetalleFactura { get; set; }




}
