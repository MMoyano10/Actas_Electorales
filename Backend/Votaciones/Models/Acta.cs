using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class Acta
{
    public long IdActa { get; set; }

    public string? DescripcionActa { get; set; }

    public long? IdRegion { get; set; }

    public long? IdProvincia { get; set; }

    public long? IdCanton { get; set; }

    public long? IdParroquia { get; set; }

    public long? IdRecinto { get; set; }

    public long? IdJrv { get; set; }

    public long? Candidato1Jrv { get; set; }

    public long? Candidato2Jrv { get; set; }

    public long? Candidato3Jrv { get; set; }

    public long? Candidato4Jrv { get; set; }

    public long? Candidato5Jrv { get; set; }

    public long? Candidato6Jrv { get; set; }

    public long? Candidato7Jrv { get; set; }

    public long? Candidato8Jrv { get; set; }

    public long? Candidato9Jrv { get; set; }

    public long? Candidato10Jrv { get; set; }

    public long? Candidato11Jrv { get; set; }

    public long? Candidato12Jrv { get; set; }

    public long? Candidato13Jrv { get; set; }

    public long? Candidato14Jrv { get; set; }

    public long? Candidato15Jrv { get; set; }

    public long? Candidato16Jrv { get; set; }

    public long? Candidato17Jrv { get; set; }

    public long? Candidato18Jrv { get; set; }

    public long? Candidato19Jrv { get; set; }

    public long? Candidato20Jrv { get; set; }

    public string? NulosJrv { get; set; }

    public string? BlancosJrv { get; set; }

    public string? ObservacionecsJrv { get; set; }

    public long? TotalPadronJrv { get; set; }

    public long? TotalEleccionJrv { get; set; }

    public virtual Canton? IdCantonNavigation { get; set; }

    public virtual Parroquium? IdParroquiaNavigation { get; set; }

    public virtual Provincium? IdProvinciaNavigation { get; set; }

    public virtual Recinto? IdRecintoNavigation { get; set; }

    public virtual Region? IdRegionNavigation { get; set; }
}
