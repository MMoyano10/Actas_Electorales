using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Votaciones.Models;

public partial class Acta
{
    [Key]
    [Column("id_acta")]
    public long IdActa { get; set; }
    [Column("descripcion_acta")]
    public string? DescripcionActa { get; set; }
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
    [Column("id_jrv")]
    public long? IdJrv { get; set; }
    [Column("candidato1_jrv")]
    public long? Candidato1Jrv { get; set; }
    [Column("candidato2_jrv")]
    public long? Candidato2Jrv { get; set; }
    [Column("candidato3_jrv")]
    public long? Candidato3Jrv { get; set; }
    [Column("candidato4_jrv")]
    public long? Candidato4Jrv { get; set; }
    [Column("candidato5_jrv")]
    public long? Candidato5Jrv { get; set; }
    [Column("candidato6_jrv")]
    public long? Candidato6Jrv { get; set; }
    [Column("candidato7_jrv")]
    public long? Candidato7Jrv { get; set; }
    [Column("candidato8_jrv")]
    public long? Candidato8Jrv { get; set; }
    [Column("candidato9_jrv")]
    public long? Candidato9Jrv { get; set; }
    [Column("candidato10_jrv")]
    public long? Candidato10Jrv { get; set; }
    [Column("candidato11_jrv")]
    public long? Candidato11Jrv { get; set; }
    [Column("candidato12_jrv")]
    public long? Candidato12Jrv { get; set; }
    [Column("candidato13_jrv")]
    public long? Candidato13Jrv { get; set; }
    [Column("candidato14_jrv")]
    public long? Candidato14Jrv { get; set; }
    [Column("candidato15_jrv")]
    public long? Candidato15Jrv { get; set; }
    [Column("candidato16_jrv")]
    public long? Candidato16Jrv { get; set; }
    [Column("candidato17_jrv")]
    public long? Candidato17Jrv { get; set; }
    [Column("candidato18_jrv")]
    public long? Candidato18Jrv { get; set; }
    [Column("candidato19_jrv")]
    public long? Candidato19Jrv { get; set; }
    [Column("candidato20_jrv")]
    public long? Candidato20Jrv { get; set; }
    [Column("nulos_jrv")]
    public string? NulosJrv { get; set; }
    [Column("blancos_jrv")]
    public string? BlancosJrv { get; set; }
    [Column("observaciones_jrv")]
    public string? ObservacionecsJrv { get; set; }
    [Column("total_padron_jrv")]
    public long? TotalPadronJrv { get; set; }
    [Column("total_eleccion_jrv")]
    public long? TotalEleccionJrv { get; set; }

    public virtual Canton? IdCantonNavigation { get; set; }

    public virtual Parroquia? IdParroquiaNavigation { get; set; }

    public virtual Provincia? IdProvinciaNavigation { get; set; }

    public virtual Recinto? IdRecintoNavigation { get; set; }

    public virtual Region? IdRegionNavigation { get; set; }
}
