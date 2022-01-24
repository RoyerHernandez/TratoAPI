using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            Ciudades = new HashSet<Ciudades>();
            Localidad = new HashSet<Localidad>();
        }

        public int IdDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        public int IdPais { get; set; }

        public virtual Pais IdPaisNavigation { get; set; }
        public virtual ICollection<Ciudades> Ciudades { get; set; }
        public virtual ICollection<Localidad> Localidad { get; set; }
    }
}
