using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Localidad
    {
        public int IdLocalidad { get; set; }
        public string NombreLocalidad { get; set; }
        public int IdCiudad { get; set; }
        public int IdDepartamento { get; set; }
        public int IdPais { get; set; }

        public virtual Ciudades IdCiudadNavigation { get; set; }
        public virtual Departamentos IdDepartamentoNavigation { get; set; }
        public virtual Pais IdPaisNavigation { get; set; }
    }
}
