using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class DeliveryTypes
    {
        public DeliveryTypes()
        {
            Excanges = new HashSet<Exchanges>();
            Auctions = new HashSet<Auctions>();
        }

        public int DeliveryTypeId { get; set; }
        public string DeliveryTypeName { get; set; }
        public int StateId { get; set; }

        public virtual States States { get; set; }
        public virtual ICollection<Exchanges> Excanges { get; set; }
        public virtual ICollection<Auctions> Auctions { get; set; }
    }
}
