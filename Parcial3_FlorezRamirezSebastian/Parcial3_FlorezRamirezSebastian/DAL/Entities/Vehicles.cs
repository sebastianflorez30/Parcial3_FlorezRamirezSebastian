using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Parcial3_FlorezRamirezSebastian.DAL.Entities
{
    public class Vehicles:Entity //Creacion Entidades : Herencia 
    {
        [Display(Name = "Propietario")]
        [Required]
        public string Owner { get; set; }
        [Display(Name = "Placa")]
        [Required]
        public string NumberPlate { get; set; } 

    }
}
