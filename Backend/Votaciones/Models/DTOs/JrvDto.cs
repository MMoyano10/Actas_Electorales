namespace Votaciones.Models.DTOs
{
    public class JrvDto
    {
        public long IdJrv { get; set; }
        public string? NombreRegion { get; set; }
        public string? NombreProvincia { get; set; }
        public string? NombreCanton { get; set; }
        public string? NombreParroquia { get; set; }
        public string? NombreRecinto { get; set; }
        public string? DescripcionJrv { get; set; }
        public int? VotantesmJrv { get; set; }
        public string? VotantesfJrv { get; set; }
        public string? CoordinadorJrv { get; set; }
        public string? ObservacionesJrv { get; set; }
        public string? AdicionalesJrv { get; set; }
        public string? ArchivoJrv { get; set; }
        public string? ImagenJrv { get; set; }
    }

}
