using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class Canton
{
    public long IdCanton { get; set; }

    public long? IdRegion { get; set; }

    public long? IdProvincia { get; set; }

    public string? CodigoCanton { get; set; }

    public string? NombreCanton { get; set; }

    public decimal? PoblacionCanton { get; set; }

    public string? CoordinadorCanton { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();

    public virtual Provincium? IdProvinciaNavigation { get; set; }

    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();

    public virtual ICollection<Parroquium> Parroquia { get; set; } = new List<Parroquium>();

    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
