using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class CoutryState
    {
        public int Id { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }

        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
    }
}
