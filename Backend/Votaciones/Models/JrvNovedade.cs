using System;
using System.Collections.Generic;

namespace Votaciones.Models;

public partial class JrvNovedade
{
    public long IdNovedades { get; set; }

    public string? DescripcionNovedad { get; set; }

    public string? Referencia1Novedades { get; set; }

    public string? Referencia2Novedades { get; set; }

    public string? IdJrv { get; set; }

    public long? IdRegion { get; set; }

    public long? IdProvincia { get; set; }

    public long? IdCanton { get; set; }

    public long? IdParroquia { get; set; }

    public string? IdRecinto { get; set; }
}
