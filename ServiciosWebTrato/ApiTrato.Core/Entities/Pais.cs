using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Pais
    {
        public Pais()
        {
            Ciudades = new HashSet<Ciudades>();
            Departamentos = new HashSet<Departamentos>();
            Localidad = new HashSet<Localidad>();
        }

        public int IdPais { get; set; }
        public string NombrePais { get; set; }

        public virtual ICollection<Ciudades> Ciudades { get; set; }
        public virtual ICollection<Departamentos> Departamentos { get; set; }
        public virtual ICollection<Localidad> Localidad { get; set; }
    }
}
