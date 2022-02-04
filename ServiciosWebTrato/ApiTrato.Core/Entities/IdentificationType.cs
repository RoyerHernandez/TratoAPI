using System;
using System.Collections.Generic;

namespace ApiTrato.Core.Entities
{
    public partial class IdentificationType
    {
        public IdentificationType()
        {
            Users = new HashSet<Users>();
        }

        public int IdentificationTypeId { get; set; }
        public string IdentificationTypeName { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
