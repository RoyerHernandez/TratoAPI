using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class States
    {
        public States()
        {
            Exchanges = new HashSet<Exchanges>();
            Auctions = new HashSet<Auctions>();
            DeliveryTypes = new HashSet<DeliveryTypes>();
            Users = new HashSet<Users>();
        }

        public int StateId { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<Exchanges> Exchanges { get; set; }
        public virtual ICollection<Auctions> Auctions { get; set; }
        public virtual ICollection<DeliveryTypes> DeliveryTypes { get; set; }
        public virtual ICollection<Users> Users { get; set; }
    }
}
