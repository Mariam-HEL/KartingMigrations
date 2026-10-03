using System.ComponentModel.DataAnnotations;

namespace KartingMigrations.Models
{
    public class Pilote
    {
        [Key]
        public int IdPilote { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nom { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Prenom { get; set; } = string.Empty;

        [MaxLength(20)]
        public string? licence { get; set; }

        [MaxLength(100)]
        [EmailAddress]
        public string? Email { get; set; }

        public int? IDEquipe { get; set; }

    }
}
