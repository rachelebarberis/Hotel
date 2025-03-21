using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Prenotazione
    {
        [Key]
        public Guid PrenotazioneId { get; set; }

        [Required]
      
        public Guid ClienteId { get; set; }

        [Required]
    
        public Guid CameraId { get; set; }

        [Required]
        [DataType(DataType.Date)]
      
        public DateTime DataInizio { get; set; }

        [Required]
        [DataType(DataType.Date)]
   
        public DateTime DataFine { get; set; }

        [Required]
        [StringLength(20)]
       
        public required string Stato { get; set; } 

    
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }

        [ForeignKey("CameraId")]
        public virtual Camera Camera { get; set; }

        [NotMapped]
        public int DurataGiorni => (DataFine - DataInizio).Days;

        [NotMapped]
        [DataType(DataType.Currency)]
        public decimal CostoTotale => Camera != null ? Camera.PrezzoPerNotte * DurataGiorni : 0;
    }
}
