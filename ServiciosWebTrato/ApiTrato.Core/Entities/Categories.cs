using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class Categories
    {
        public Categories()
        {
            Exchanges = new HashSet<Exchanges>();
            Auctions = new HashSet<Auctions>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual ICollection<Exchanges> Exchanges { get; set; }
        public virtual ICollection<Auctions> Auctions { get; set; }
    }
}
