using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class Provincium
{
    public long IdProvincia { get; set; }

    public long? IdRegion { get; set; }

    public string? CodigoProvincia { get; set; }

    public string? NombreProvincia { get; set; }

    public string? PoblacionProvincia { get; set; }

    public string? CoordinadorProvincia { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();

    public virtual ICollection<Canton> Cantons { get; set; } = new List<Canton>();

    public virtual Region? IdRegionNavigation { get; set; }

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();

    public virtual ICollection<Parroquium> Parroquia { get; set; } = new List<Parroquium>();

    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
