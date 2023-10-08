using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Medium
    {
        public Medium()
        {
            InstitutionAddresses = new HashSet<InstitutionAddress>();
            Institutions = new HashSet<Institution>();
        }

        public int Id { get; set; }
        public string Medium1 { get; set; }
        public string Code { get; set; }

        public virtual ICollection<InstitutionAddress> InstitutionAddresses { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
    }
}
