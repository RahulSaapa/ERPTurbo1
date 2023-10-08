using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class InstitutionContact
    {
        public int Id { get; set; }
        public int? InstitutionAddressId { get; set; }
        public long? MobileNumber { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }

        public virtual InstitutionAddress InstitutionAddress { get; set; }
    }
}
