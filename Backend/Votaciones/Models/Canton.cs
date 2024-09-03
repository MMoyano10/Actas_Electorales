using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class Canton
{
    [Key]
    [Column("id_canton")]
    public long IdCanton { get; set; }
    [Column("id_region")]
    public long? IdRegion { get; set; }
    [Column("id_provincia")]
    public long? IdProvincia { get; set; }
    [Column("codigo_canton")]
    public string? CodigoCanton { get; set; }
    [Column("nombre_canton")]
    public string? NombreCanton { get; set; }
    [Column("poblacion_canton")]
    public decimal? PoblacionCanton { get; set; }
    [Column("coordinador_canton")]
    public string? CoordinadorCanton { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();
    [ForeignKey(nameof(IdProvincia))]
    public virtual Provincia? IdProvinciaNavigation { get; set; }
    [ForeignKey(nameof(IdRegion))]
    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();

    public virtual ICollection<Parroquia> Parroquia { get; set; } = new List<Parroquia>();

    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
