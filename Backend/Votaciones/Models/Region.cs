using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class Region
{
    public long IdRegion { get; set; }

    public string? NombreRegion { get; set; }

    public decimal? PoblacionRegion { get; set; }

    public string? CoordinadorRegion { get; set; }

    public virtual ICollection<Acta> Acta { get; set; } = new List<Acta>();

    public virtual ICollection<Canton> Cantons { get; set; } = new List<Canton>();

    public virtual ICollection<Jrv> Jrvs { get; set; } = new List<Jrv>();

    public virtual ICollection<Parroquium> Parroquia { get; set; } = new List<Parroquium>();

    public virtual ICollection<Provincium> Provincia { get; set; } = new List<Provincium>();

    public virtual ICollection<Recinto> Recintos { get; set; } = new List<Recinto>();
}
