using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class Jrv
{
    [Key]
    [Column("id_jrv")]
    public long IdJrv { get; set; }
    [Column("id_region")]
    public long? IdRegion { get; set; }
    [Column("id_provincia")]

    public long? IdProvincia { get; set; }
    [Column("id_canton")]
    public long? IdCanton { get; set; }
    [Column("id_parroquia")]
    public long? IdParroquia { get; set; }
    [Column("id_recinto")]
    public long? IdRecinto { get; set; }
    [Column("descripcion_jrv")]
    public string? DescripcionJrv { get; set; }
    [Column("votantesm_jrv")]
    public int? VotantesmJrv { get; set; }
    [Column("votantesf_jrv")]
    public string? VotantesfJrv { get; set; }
    [Column("coordinador_jrv")]
    public string? CoordinadorJrv { get; set; }
    [Column("observaciones_jrv")]
    public string? ObservacionesJrv { get; set; }
    [Column("adicionales_jrv")]
    public string? AdicionalesJrv { get; set; }
    [Column("archivo_jrv")]
    public string? ArchivoJrv { get; set; }
    [Column("imagen_jrv")]
    public string? ImagenJrv { get; set; }

    [ForeignKey(nameof(IdCanton))]
    public virtual Canton? IdCantonNavigation { get; set; }

    [ForeignKey(nameof(IdParroquia))]
    public virtual Parroquia? IdParroquiaNavigation { get; set; }

    [ForeignKey(nameof(IdProvincia))]
    public virtual Provincia? IdProvinciaNavigation { get; set; }
    [ForeignKey(nameof(IdRecinto))]
    public virtual Recinto? IdRecintoNavigation { get; set; }
    [ForeignKey(nameof(IdRegion))]
    public virtual Region? IdRegionNavigation { get; set; }
}
