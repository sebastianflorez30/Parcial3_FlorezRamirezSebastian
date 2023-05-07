namespace Parcial3_FlorezRamirezSebastian.DAL.Entities
{
    public class VehicleDetail:Entity
    {
        public Vehicle vehicle { get; set; } //clave foranea de vehiculo
        public DateTime? CreationDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
    }
}
