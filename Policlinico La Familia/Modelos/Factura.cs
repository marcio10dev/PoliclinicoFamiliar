using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Policlinico_La_Familia.Modelos;

public partial class Factura
{
    [Key]
    [Column("IDFactura")]
    public int Idfactura { get; set; }

    [Column("IDCita")]
    public int? Idcita { get; set; }

    public DateOnly? FechaEmision { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? MontoTotal { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? EstadoPago { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MetodoPago { get; set; }

    [ForeignKey("Idcita")]
    [InverseProperty("Facturas")]
    public virtual Cita? IdcitaNavigation { get; set; }
}
