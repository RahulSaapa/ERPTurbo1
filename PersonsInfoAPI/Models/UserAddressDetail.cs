using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class UserAddressDetail
    {
        public int Id { get; set; }
        public string FlotNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? UserId { get; set; }
        public bool? IsPermanent { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual User User { get; set; }
    }
}
