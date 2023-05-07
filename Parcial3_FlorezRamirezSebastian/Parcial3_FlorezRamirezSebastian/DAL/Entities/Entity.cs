using System.ComponentModel.DataAnnotations;

namespace Parcial3_FlorezRamirezSebastian.DAL.Entities
{
    public class Entity
    {
        [Key] //DataAnnotations -> asigna clave primaria, son para darle control a cierta propiedad
        [Required]//este campo es requerido o obligatorio
        public Guid Id { get; set; } //guid para poner el id mas seguro y unico

        public DateTime? CreatedDate { get; set; }   //indicar cuando se crea cada registro en base de datos, ? esto indica que puede ser null

        public DateTime? ModifiedDate { get; set; } //indicar cuando se modifica cada registro en base de datos
    }
}
