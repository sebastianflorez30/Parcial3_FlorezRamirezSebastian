using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Parcial3_FlorezRamirezSebastian.DAL.Entities
{
    public class Vehicle:Entity //Creacion Entidades : Herencia 
    {
        [Display(Name = "Propietario")]
        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        public string Owner { get; set; }


        [Display(Name = "Placa")]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string NumberPlate { get; set; } 

    }
}
