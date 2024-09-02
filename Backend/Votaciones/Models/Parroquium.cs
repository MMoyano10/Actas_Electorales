using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class Parroquium
{
    public long IdParroquia { get; set; }

    public long? IdRegion { get; set; }

    public long? IdProvincia { get; set; }

    public long? IdCanton { get; set; }

    public string? CodigoParroquia { get; set; }

    public string? NombreParroquia { get; set; }

    public decimal? PoblacionParroquia { get; set; }

    public string? CoordinadorParroquia { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();

    public virtual Canton? IdCantonNavigation { get; set; }

    public virtual Provincium? IdProvinciaNavigation { get; set; }

    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();

    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
