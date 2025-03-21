using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Cliente
    {
        [Key]
        public Guid ClienteId { get; set; }

        [Required]
        [StringLength(50)]
    
        public required string Nome { get; set; }

        [Required]
        [StringLength(50)]
   
        public required string Cognome { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(200)]
     
        public required string Email { get; set; }

        [Phone]
        [StringLength(20)]
  
        public required string Telefono { get; set; }

        public virtual ICollection<Prenotazione> Prenotazioni { get; set; }

    }
}
