using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Policlinico_La_Familia.Modelos;

public partial class Receta
{
    [Key]
    [Column("IDReceta")]
    public int Idreceta { get; set; }

    [Column("IDHistorial")]
    public int? Idhistorial { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Medicamento { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Dosificación { get; set; }

    [StringLength(60)]
    [Unicode(false)]
    public string? Instrucciones { get; set; }

    [ForeignKey("Idhistorial")]
    [InverseProperty("Receta")]
    public virtual HistorialesMedico? IdhistorialNavigation { get; set; }
}
