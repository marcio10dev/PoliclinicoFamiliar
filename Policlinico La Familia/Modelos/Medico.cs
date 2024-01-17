using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Policlinico_La_Familia.Modelos;

public partial class Medico
{
    [Key]
    [Column("IDMédico")]
    public int Idmédico { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Nombre { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Especialidad { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Telefono { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CorreoElectronico { get; set; }

    [InverseProperty("IdmédicoNavigation")]
    public virtual ICollection<Cita> Cita { get; set; } = new List<Cita>();

    [InverseProperty("IdmédicoNavigation")]
    public virtual ICollection<HistorialesMedico> HistorialesMedicos { get; set; } = new List<HistorialesMedico>();
}
