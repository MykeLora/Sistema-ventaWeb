
using Newtonsoft.Json;
using System;

namespace SalesOnline.Application.Dtos.Base
{
    public abstract class DtoBase
    {
        [JsonProperty("idUsuario")]
        public int idUsuario { get; set; }

        [JsonProperty("FechaMod")]
        public DateTime? FechaMod { get; set; }
    }
}
