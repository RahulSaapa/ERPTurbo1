using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Qualificationtype
    {
        public Qualificationtype()
        {
            FamilyEducationDetails = new HashSet<FamilyEducationDetail>();
            Institutions = new HashSet<Institution>();
            UserEducationDetails = new HashSet<UserEducationDetail>();
        }

        public int Id { get; set; }
        public string QualificationName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<FamilyEducationDetail> FamilyEducationDetails { get; set; }
        public virtual ICollection<Institution> Institutions { get; set; }
        public virtual ICollection<UserEducationDetail> UserEducationDetails { get; set; }
    }
}
