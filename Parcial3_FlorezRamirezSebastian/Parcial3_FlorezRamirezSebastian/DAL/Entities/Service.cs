using System.ComponentModel.DataAnnotations;

namespace Parcial3_FlorezRamirezSebastian.DAL.Entities
{
    public class Service:Entity
    {
        [Display(Name="Servicio")] //nombre como quiere que se visualice       
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }

        public ICollection<Vehicle>Vehicles { get; set; }
    }
}
