using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class Recinto
{
    public long IdRecinto { get; set; }

    public long? IdRegion { get; set; }

    public long? IdProvincia { get; set; }

    public long? IdCanton { get; set; }

    public long? IdParroquia { get; set; }

    public string? CodigoRecinto { get; set; }

    public string? NombreRecinto { get; set; }

    public string? DireccionRecinto { get; set; }

    public int? JrvmNumeroRecinto { get; set; }

    public int? JrvfNumeroRecinto { get; set; }

    public string? JrvmVotantesRecinto { get; set; }

    public string? JrvfVotantesRecinto { get; set; }

    public string? CoordinadorRecinto { get; set; }

    public string? FotoCoordinadorRecinto { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();

    public virtual Canton? IdCantonNavigation { get; set; }

    public virtual Parroquium? IdParroquiaNavigation { get; set; }

    public virtual Provincium? IdProvinciaNavigation { get; set; }

    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();
}
