using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Country
    {
        public Country()
        {
            Cities = new HashSet<Cities>();
            Departments = new HashSet<Departments>();
            Locations = new HashSet<Locations>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Cities> Cities { get; set; }
        public virtual ICollection<Departments> Departments { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
    }
}
