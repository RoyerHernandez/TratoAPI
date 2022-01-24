using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Estados
    {
        public Estados()
        {
            Intercambios = new HashSet<Intercambios>();
            Subastas = new HashSet<Subastas>();
            TiposDeEntrega = new HashSet<TiposDeEntrega>();
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdEstado { get; set; }
        public string NombreEstado { get; set; }

        public virtual ICollection<Intercambios> Intercambios { get; set; }
        public virtual ICollection<Subastas> Subastas { get; set; }
        public virtual ICollection<TiposDeEntrega> TiposDeEntrega { get; set; }
        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
