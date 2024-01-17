using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Policlinico_La_Familia.Modelos;

public partial class Cita
{
    [Key]
    [Column("IDCita")]
    public int Idcita { get; set; }

    [Column("IDPaciente")]
    public int? Idpaciente { get; set; }

    [Column("IDMédico")]
    public int? Idmédico { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? FechaHoraCita { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? Motivo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EstadoCita { get; set; }

    [InverseProperty("IdcitaNavigation")]
    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    [ForeignKey("Idmédico")]
    [InverseProperty("Cita")]
    public virtual Medico? IdmédicoNavigation { get; set; }

    [ForeignKey("Idpaciente")]
    [InverseProperty("Cita")]
    public virtual Paciente? IdpacienteNavigation { get; set; }

    [InverseProperty("IdcitaNavigation")]
    public virtual ICollection<ServiciosMedico> ServiciosMedicos { get; set; } = new List<ServiciosMedico>();
}
