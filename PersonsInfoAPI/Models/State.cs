using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class State
    {
        public State()
        {
            CompanyAddresses = new HashSet<CompanyAddress>();
            CoutryStates = new HashSet<CoutryState>();
            UserAddressDetails = new HashSet<UserAddressDetail>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
        public virtual ICollection<CoutryState> CoutryStates { get; set; }
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
    }
}
