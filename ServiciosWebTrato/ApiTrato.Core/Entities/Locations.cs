using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Locations
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int CityId { get; set; }
        public int DepartmentId { get; set; }
        public int CountryId { get; set; }

        public virtual Cities Cities { get; set; }
        public virtual Departments Departments { get; set; }
        public virtual Country Countries { get; set; }
    }
}
