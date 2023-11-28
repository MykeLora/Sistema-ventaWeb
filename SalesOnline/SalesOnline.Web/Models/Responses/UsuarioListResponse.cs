namespace SalesOnline.Web.Models.Responses
{
    public class UsuarioListResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public List<UsuarioViewResult> data { get; set; }
    }

    public class UsuarioViewResult
    {
        public int idUsuario { get; set; }
        public string nombreCompleto { get; set; }
        public string corro { get; set; }
        public DateTime fechaRegistro { get; set; }
    }
}
