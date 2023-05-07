using Microsoft.EntityFrameworkCore;
using Parcial3_FlorezRamirezSebastian.DAL.Entities;


namespace Parcial3_FlorezRamirezSebastian.DAL
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }      

        public DbSet<Service> Services { get; set; } //se debe crear uno por cada tabla que se creara en la base de datos
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> VehicleDetails { get; set; }


    }
}
