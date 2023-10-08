﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class CompanyContact
    {
        public int Id { get; set; }
        public int? CompanyAddressId { get; set; }
        public long? MobileNumber { get; set; }
        public bool? IsPrimary { get; set; }
        public int? OrderId { get; set; }

        public virtual CompanyAddress CompanyAddress { get; set; }
    }
}
