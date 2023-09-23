using SalesOnline.Domain.Core;

namespace SalesOnline.Domain.Entities
{
    public class Producto : Gestion
    {
        public int idProducto{ get; set; }
        public int? idCategoria { get; set; }
        public int? stock { get; set; }

    }
}
