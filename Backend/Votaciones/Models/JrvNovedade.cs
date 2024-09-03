using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class JrvNovedade
{
    [Key]
    [Column("id_novedades")]
    public long IdNovedades { get; set; }
    [Column("descripcion_novedad")]
    public string? DescripcionNovedad { get; set; }
    [Column("referencia1_novedades")]
    public string? Referencia1Novedades { get; set; }
    [Column("referencia2_novedades")]
    public string? Referencia2Novedades { get; set; }
    [Column("id_jrv")]
    public string? IdJrv { get; set; }
    [Column("id_region")]
    public long? IdRegion { get; set; }
    [Column("id_provincia")]
    public long? IdProvincia { get; set; }
    [Column("id_canton")]
    public long? IdCanton { get; set; }
    [Column("id_parroquia")]
    public long? IdParroquia { get; set; }
    [Column("id_recinto")]
    public string? IdRecinto { get; set; }
}
