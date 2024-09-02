using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class Jrv
{
    public long IdJrv { get; set; }

    public long? IdRegion { get; set; }

    public long? IdProvincia { get; set; }

    public long? IdCanton { get; set; }

    public long? IdParroquia { get; set; }

    public long? IdRecinto { get; set; }

    public string? DescripcionJrv { get; set; }

    public int? VotantesmJrv { get; set; }

    public string? VotantesfJrv { get; set; }

    public string? CoordinadorJrv { get; set; }

    public string? ObservacionesJrv { get; set; }

    public string? AdicionalesJrv { get; set; }

    public string? ArchivoJrv { get; set; }

    public string? ImagenJrv { get; set; }

    public virtual Canton? IdCantonNavigation { get; set; }

    public virtual Parroquium? IdParroquiaNavigation { get; set; }

    public virtual Provincium? IdProvinciaNavigation { get; set; }

    public virtual Recinto? IdRecintoNavigation { get; set; }

    public virtual Region? IdRegionNavigation { get; set; }
}
