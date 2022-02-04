using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Departments
    {
        public Departments()
        {
            Cities = new HashSet<Cities>();
            Locations = new HashSet<Locations>();
        }

        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public int CountryId { get; set; }

        public virtual Country Countries { get; set; }
        public virtual ICollection<Cities> Cities { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
    }
}
