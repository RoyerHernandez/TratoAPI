using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Intercambios
    {
        public int IdIntercambio { get; set; }
        public int IdCategoria { get; set; }
        public int IdEstado { get; set; }
        public string Producto { get; set; }
        public string Marca { get; set; }
        public int Alto { get; set; }
        public int Ancho { get; set; }
        public int Largo { get; set; }
        public int Peso { get; set; }
        public int IdCiudad { get; set; }
        public int IdLocalidad { get; set; }
        public int IdTipoEntrega { get; set; }
        public string Imagenes { get; set; }

        public virtual Categories IdCategoriaNavigation { get; set; }
        public virtual Ciudades IdCiudadNavigation { get; set; }
        public virtual Estados IdEstadoNavigation { get; set; }
        public virtual TiposDeEntrega IdTipoEntregaNavigation { get; set; }
    }
}
