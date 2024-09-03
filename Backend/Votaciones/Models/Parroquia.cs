using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class Parroquia
{
    [Key]
    [Column("id_parroquia")]
    public long IdParroquia { get; set; }
    [Column("id_region")]
    public long? IdRegion { get; set; }
    [Column("id_provincia")]
    public long? IdProvincia { get; set; }
    [Column("id_canton")]
    public long? IdCanton { get; set; }
    [Column("codigo_parroquia")]
    public string? CodigoParroquia { get; set; }
    [Column("nombre_parroquia")]
    public string? NombreParroquia { get; set; }
    [Column("poblacion_parroquia")]
    public decimal? PoblacionParroquia { get; set; }
    [Column("coordinador_parroquia")]
    public string? CoordinadorParroquia { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();
    [ForeignKey(nameof(IdCanton))]
    public virtual Canton? IdCantonNavigation { get; set; }
    [ForeignKey(nameof(IdProvincia))]
    public virtual Provincia? IdProvinciaNavigation { get; set; }
    [ForeignKey(nameof(IdRegion))]
    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();
    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
