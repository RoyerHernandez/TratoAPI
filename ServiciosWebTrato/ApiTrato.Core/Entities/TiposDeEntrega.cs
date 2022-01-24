using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class TiposDeEntrega
    {
        public TiposDeEntrega()
        {
            Intercambios = new HashSet<Intercambios>();
            Subastas = new HashSet<Subastas>();
        }

        public int IdTipoEntrega { get; set; }
        public string NombreTipoEntrega { get; set; }
        public int IdEstado { get; set; }

        public virtual Estados IdEstadoNavigation { get; set; }
        public virtual ICollection<Intercambios> Intercambios { get; set; }
        public virtual ICollection<Subastas> Subastas { get; set; }
    }
}
