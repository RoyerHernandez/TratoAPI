using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Exchanges
    {
        public int ExchangeId { get; set; }
        public int CategoryId { get; set; }
        public int StateId { get; set; }
        public string Product { get; set; }
        public string Mark { get; set; }
        public int High { get; set; }
        public int width { get; set; }
        public int Long { get; set; }
        public int Weight { get; set; }
        public int CityId { get; set; }
        public int LocationId { get; set; }
        public int DeliveryTypeId { get; set; }
        public string Image { get; set; }

        public virtual Categories Categories { get; set; }
        public virtual Cities Cities { get; set; }
        public virtual States States { get; set; }
        public virtual DeliveryTypes DeliveriesTypes { get; set; }
    }
}
