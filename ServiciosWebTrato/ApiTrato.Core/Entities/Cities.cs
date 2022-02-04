using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Cities
    {
        public Cities()
        {
            Exchanges = new HashSet<Exchanges>();
            Locations = new HashSet<Locations>();
            Auctions = new HashSet<Auctions>();
        }

        public int CityId { get; set; }
        public string CityName { get; set; }
        public int DepartmentId { get; set; }
        public int CountryId { get; set; }

        public virtual Departments Departments { get; set; }
        public virtual Country Countries { get; set; }
        public virtual ICollection<Exchanges> Exchanges { get; set; }
        public virtual ICollection<Locations> Locations { get; set; }
        public virtual ICollection<Auctions> Auctions { get; set; }
    }
}
