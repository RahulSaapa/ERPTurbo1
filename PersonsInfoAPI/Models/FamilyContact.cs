using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class FamilyContact
    {
        public int Id { get; set; }
        public int? FamilyId { get; set; }
        public long? MobileNumber { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }

        public virtual Family Family { get; set; }
    }
}
