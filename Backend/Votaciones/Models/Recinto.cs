using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class Recinto
{
    [Key]
    [Column("id_recinto")]
    public long IdRecinto { get; set; }
    [Column("id_region")]
    public long? IdRegion { get; set; }
    [Column("id_provincia")]
    public long? IdProvincia { get; set; }
    [Column("id_canton")]
    public long? IdCanton { get; set; }
    [Column("id_parroquia")]
    public long? IdParroquia { get; set; }
    [Column("codigo_recinto")]
    public string? CodigoRecinto { get; set; }
    [Column("nombre_recinto")]
    public string? NombreRecinto { get; set; }
    [Column("direccion_recinto")]
    public string? DireccionRecinto { get; set; }
    [Column("jrv_m_numero_recinto")]
    public int? JrvmNumeroRecinto { get; set; }
    [Column("jrvf_numero_recinto")]
    public int? JrvfNumeroRecinto { get; set; }
    [Column("jrvm_votantes_recinto")]
    public string? JrvmVotantesRecinto { get; set; }
    [Column("jrvf_votantes_recinto")]
    public string? JrvfVotantesRecinto { get; set; }
    [Column("coordinador_recinto")]
    public string? CoordinadorRecinto { get; set; }
    [Column("foto_coordinador_recinto")]
    public string? FotoCoordinadorRecinto { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();
    [ForeignKey(nameof(IdCanton))]
    public virtual Canton? IdCantonNavigation { get; set; }

    [ForeignKey(nameof(IdParroquia))]
    public virtual Parroquia? IdParroquiaNavigation { get; set; }

    [ForeignKey(nameof(IdProvincia))]
    public virtual Provincia? IdProvinciaNavigation { get; set; }
    [ForeignKey(nameof(IdRegion))]
    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();
}
