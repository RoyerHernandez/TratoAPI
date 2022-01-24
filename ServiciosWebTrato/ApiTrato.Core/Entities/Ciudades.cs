using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Intercambios = new HashSet<Intercambios>();
            Localidad = new HashSet<Localidad>();
            Subastas = new HashSet<Subastas>();
        }

        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }
        public int IdDepartamento { get; set; }
        public int IdPais { get; set; }

        public virtual Departamentos IdDepartamentoNavigation { get; set; }
        public virtual Pais IdPaisNavigation { get; set; }
        public virtual ICollection<Intercambios> Intercambios { get; set; }
        public virtual ICollection<Localidad> Localidad { get; set; }
        public virtual ICollection<Subastas> Subastas { get; set; }
    }
}
