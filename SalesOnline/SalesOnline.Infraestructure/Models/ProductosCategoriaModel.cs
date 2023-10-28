using System;
using System.Collections.Generic;
using System.Text;

namespace SalesOnline.Infraestructure.Models
{
    public class ProductosCategoriaModel
    {

        public ProductosCategoriaModel()
        {
            this.ProductoModel = new ProductoModel();
            this.CategoriaModels = new List<CategoriaModel>();
        }
        public ProductoModel? ProductoModel { get; set; }
        public List<CategoriaModel> CategoriaModels { get; set; }
    }
}
}
