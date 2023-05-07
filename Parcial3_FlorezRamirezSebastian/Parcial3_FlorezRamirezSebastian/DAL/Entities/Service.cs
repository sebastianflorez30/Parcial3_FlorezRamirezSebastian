using System.ComponentModel.DataAnnotations;

namespace Parcial3_FlorezRamirezSebastian.DAL.Entities
{
    public class Service:Entity
    {
        [Display(Name="Servicio")] //nombre como quiere que se visualice
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public float Price { get; set; }
    }
}
