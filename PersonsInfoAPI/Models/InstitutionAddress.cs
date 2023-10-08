using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class InstitutionAddress
    {
        public InstitutionAddress()
        {
            FamilyEducationDetails = new HashSet<FamilyEducationDetail>();
            FamilyEmails = new HashSet<FamilyEmail>();
            InstitutionContacts = new HashSet<InstitutionContact>();
            InstitutionEmails = new HashSet<InstitutionEmail>();
        }

        public int Id { get; set; }
        public int? InstitutionId { get; set; }
        public string FlotNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }
        public int? MediumId { get; set; }

        public virtual Country Country { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual Medium Medium { get; set; }
        public virtual Institution State { get; set; }
        public virtual ICollection<FamilyEducationDetail> FamilyEducationDetails { get; set; }
        public virtual ICollection<FamilyEmail> FamilyEmails { get; set; }
        public virtual ICollection<InstitutionContact> InstitutionContacts { get; set; }
        public virtual ICollection<InstitutionEmail> InstitutionEmails { get; set; }
    }
}
