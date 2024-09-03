using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class Provincia
{
    [Key]
    [Column("id_provincia")]
    public long IdProvincia { get; set; }
    [Column("id_region")]
    public long? IdRegion { get; set; }
    [Column("codigo_provincia")]
    public string? CodigoProvincia { get; set; }
    [Column("nombre_provincia")]
    public string? NombreProvincia { get; set; }
    [Column("poblacion_provincia")]
    public string? PoblacionProvincia { get; set; }
    [Column("coordinador_provincia")]
    public string? CoordinadorProvincia { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();

    public virtual ICollection<Canton> Cantons { get; set; } = new List<Canton>();

    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();

    public virtual ICollection<Parroquia> Parroquia { get; set; } = new List<Parroquia>();

    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
