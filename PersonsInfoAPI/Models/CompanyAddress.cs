using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class CompanyAddress
    {
        public CompanyAddress()
        {
            CompanyContacts = new HashSet<CompanyContact>();
            CompanyEmails = new HashSet<CompanyEmail>();
            UserCompanies = new HashSet<UserCompany>();
        }

        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public string FlotNo { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public int? CountryId { get; set; }

        public virtual Company Company { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual ICollection<CompanyContact> CompanyContacts { get; set; }
        public virtual ICollection<CompanyEmail> CompanyEmails { get; set; }
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
    }
}
