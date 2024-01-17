using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Policlinico_La_Familia.Modelos;

public partial class ServiciosMedico
{
    [Key]
    [Column("IDServicio")]
    public int Idservicio { get; set; }

    [Column("IDCita")]
    public int? Idcita { get; set; }

    [Column(TypeName = "text")]
    public string? DescripcionServicio { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Costo { get; set; }

    [Column(TypeName = "text")]
    public string? ResultadosPruebasMedicas { get; set; }

    [ForeignKey("Idcita")]
    [InverseProperty("ServiciosMedicos")]
    public virtual Cita? IdcitaNavigation { get; set; }
}
