using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Policlinico_La_Familia.Modelos;

public partial class HistorialesMedico
{
    [Key]
    [Column("IDHistorial")]
    public int Idhistorial { get; set; }

    [Column("IDPaciente")]
    public int? Idpaciente { get; set; }

    [Column("IDMédico")]
    public int? Idmédico { get; set; }

    public DateOnly? FechaVisita { get; set; }

    [Column(TypeName = "text")]
    public string? Diagnostico { get; set; }

    [Column(TypeName = "text")]
    public string? Tratamiento { get; set; }

    [Column(TypeName = "text")]
    public string? Prescripciones { get; set; }

    [Column(TypeName = "text")]
    public string? ResultadosPruebasMedicas { get; set; }

    [ForeignKey("Idmédico")]
    [InverseProperty("HistorialesMedicos")]
    public virtual Medico? IdmédicoNavigation { get; set; }

    [ForeignKey("Idpaciente")]
    [InverseProperty("HistorialesMedicos")]
    public virtual Paciente? IdpacienteNavigation { get; set; }

    [InverseProperty("IdhistorialNavigation")]
    public virtual ICollection<Receta> Receta { get; set; } = new List<Receta>();
}
