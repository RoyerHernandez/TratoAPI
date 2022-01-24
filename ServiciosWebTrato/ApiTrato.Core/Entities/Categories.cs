using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Categories
    {
        public Categories()
        {
            Exchanges = new HashSet<Intercambios>();
            Auctions = new HashSet<Subastas>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Intercambios> Exchanges { get; set; }
        public virtual ICollection<Subastas> Auctions { get; set; }
    }
}
