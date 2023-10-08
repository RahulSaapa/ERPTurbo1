﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Family
    {
        public Family()
        {
            FamilyContacts = new HashSet<FamilyContact>();
            FamilyEducationDetails = new HashSet<FamilyEducationDetail>();
        }

        public int Id { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? RelationTypeId { get; set; }
        public bool? IsGuardian { get; set; }

        public virtual RelationType RelationType { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<FamilyContact> FamilyContacts { get; set; }
        public virtual ICollection<FamilyEducationDetail> FamilyEducationDetails { get; set; }
    }
}
