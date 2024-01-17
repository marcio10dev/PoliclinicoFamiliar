using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ClientPoliclinicoLaFamilia.Models
{
    public class Paciente
    {
        [Key]
        [Column("IDPaciente")]
        public int Idpaciente { get; set; }

        [StringLength(100)]
      
        public string? Nombre { get; set; }

        public DateOnly? FechaNacimiento { get; set; }

        [StringLength(20)]
     
        public string? Genero { get; set; }

        [StringLength(255)]
     
        public string? Direccion { get; set; }

        [StringLength(20)]
       
        public string? Telefono { get; set; }

        [StringLength(100)]
       
        public string? CorreoElectronico { get; set; }

        [StringLength(50)]
     
        public string? SeguroMedico { get; set; }

       
    }
}
