using System.ComponentModel.DataAnnotations;

namespace Parcial3_FlorezRamirezSebastian.DAL.Entities
{
    public class Services:Entity
    {
        [Display(Name="Servicio")] //nombre como quiere que se visualice
        [Required]
        public string Name { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
