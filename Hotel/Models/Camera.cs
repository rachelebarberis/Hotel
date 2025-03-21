using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Hotel.Models
{
    public class Camera
    {
        [Key]
        public Guid CameraId { get; set; }

        [Required]
       
        public int NumeroCamera { get; set; }

        [Required]
        [StringLength(50)]

        public required string Tipo { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
   
        public decimal PrezzoPerNotte { get; set; }

    
        public virtual ICollection<Prenotazione> Prenotazioni { get; set; }
    }
}
