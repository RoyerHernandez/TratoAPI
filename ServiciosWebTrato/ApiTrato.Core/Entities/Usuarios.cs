using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdTipoIdentifiacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string NumeroContacto { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string Contrasena { get; set; }
        public int IdEstado { get; set; }

        public virtual Estados IdEstadoNavigation { get; set; }
        public virtual TiposIdentificacion IdTipoIdentifiacionNavigation { get; set; }
    }
}
