using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Institution
    {
        public Institution()
        {
            InstitutionAddressInstitutions = new HashSet<InstitutionAddress>();
            InstitutionAddressStates = new HashSet<InstitutionAddress>();
        }

        public int Id { get; set; }
        public string InstitutionName { get; set; }
        public int? QualificationtypeId { get; set; }
        public int? MediumId { get; set; }

        public virtual Medium Medium { get; set; }
        public virtual Qualificationtype Qualificationtype { get; set; }
        public virtual ICollection<InstitutionAddress> InstitutionAddressInstitutions { get; set; }
        public virtual ICollection<InstitutionAddress> InstitutionAddressStates { get; set; }
    }
}
