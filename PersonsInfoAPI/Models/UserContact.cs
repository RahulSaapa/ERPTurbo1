using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class UserContact
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public long? MobileNumber { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }

        public virtual User User { get; set; }
    }
}
