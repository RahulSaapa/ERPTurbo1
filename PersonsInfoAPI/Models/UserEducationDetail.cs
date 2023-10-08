using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class UserEducationDetail
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? QualificationtypeId { get; set; }
        public int? YearOfPassout { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? InstitutionId { get; set; }
        public int? Percentage { get; set; }

        public virtual Qualificationtype Qualificationtype { get; set; }
        public virtual User User { get; set; }
    }
}
