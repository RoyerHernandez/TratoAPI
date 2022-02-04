using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiTrato.Core.Entities
{
    public partial class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int IdentificationTypeId { get; set; }
        public string IdentificationNumber { get; set; }
        public string ContactNumber { get; set; }
        public string EMail { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public int StateId { get; set; }

        public virtual States States { get; set; }
        public virtual IdentificationType IdentificationType { get; set; }
    }
}
