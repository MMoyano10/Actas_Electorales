using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class Region
{
    [Key]
    [Column("id_region")]
    public long IdRegion { get; set; }
    [Column("nombre_region")]
    public string? NombreRegion { get; set; }
    [Column("poblacion_region")]
    public decimal? PoblacionRegion { get; set; }
    [Column("coordinador_region")]
    public string? CoordinadorRegion { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();

    public virtual ICollection<Canton> Cantons { get; set; } = new List<Canton>();

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();

    public virtual ICollection<Parroquia> Parroquia { get; set; } = new List<Parroquia>();

    public virtual ICollection<Provincia> Provincia { get; set; } = new List<Provincia>();

    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
