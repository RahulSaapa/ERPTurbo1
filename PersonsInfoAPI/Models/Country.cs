using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Country
    {
        public Country()
        {
            CompanyAddresses = new HashSet<CompanyAddress>();
            CoutryStates = new HashSet<CoutryState>();
            InstitutionAddresses = new HashSet<InstitutionAddress>();
            UserAddressDetails = new HashSet<UserAddressDetail>();
        }

        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
        public virtual ICollection<CoutryState> CoutryStates { get; set; }
        public virtual ICollection<InstitutionAddress> InstitutionAddresses { get; set; }
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
    }
}
