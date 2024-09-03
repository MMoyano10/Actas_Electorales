namespace Votaciones.Models.DTOs
{        public class JrvNovedadesDto
    {
            public long IdNovedades { get; set; }
            public string? DescripcionNovedad { get; set; }
            public string? Referencia1Novedades { get; set; }
            public string? Referencia2Novedades { get; set; }
            public string? NombreJrv { get; set; }
            public long? NombreRegion { get; set; }
            public long? NombreProvincia { get; set; }
            public long? NombreCanton { get; set; }
            public long? NombreParroquia { get; set; }
            public string? NombreRecinto { get; set; }
        }
}
