using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Policlinico_La_Familia.Modelos;

public partial class Paciente
{
    [Key]
    [Column("IDPaciente")]
    public int Idpaciente { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    public DateOnly? FechaNacimiento { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Genero { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CorreoElectronico { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SeguroMedico { get; set; }

    [InverseProperty("IdpacienteNavigation")]
    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    [InverseProperty("IdpacienteNavigation")]
    public virtual ICollection<HistorialesMedico> HistorialesMedicos { get; set; } = new List<HistorialesMedico>();
}
