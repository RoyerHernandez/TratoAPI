using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class TiposIdentificacion
    {
        public TiposIdentificacion()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int IdTipoIdentificacion { get; set; }
        public string TipoIdentificacion { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Usuarios> Usuarios { get; set; }
    }
}
