using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class User
    {
        public User()
        {
            Families = new HashSet<Family>();
            UserAddressDetails = new HashSet<UserAddressDetail>();
            UserCompanies = new HashSet<UserCompany>();
            UserContacts = new HashSet<UserContact>();
            UserEducationDetails = new HashSet<UserEducationDetail>();
            UserEmails = new HashSet<UserEmail>();
            UserSkills = new HashSet<UserSkill>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? Dob { get; set; }
        public int? GenderId { get; set; }
        public int? MarritalStatusId { get; set; }
        public long? MobileNumber { get; set; }
        public long? AadharNumber { get; set; }
        public string VoterId { get; set; }
        public string PanCardNumber { get; set; }

        public virtual Gender Gender { get; set; }
        public virtual MarritalStatus MarritalStatus { get; set; }
        public virtual ICollection<Family> Families { get; set; }
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
        public virtual ICollection<UserCompany> UserCompanies { get; set; }
        public virtual ICollection<UserContact> UserContacts { get; set; }
        public virtual ICollection<UserEducationDetail> UserEducationDetails { get; set; }
        public virtual ICollection<UserEmail> UserEmails { get; set; }
        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
