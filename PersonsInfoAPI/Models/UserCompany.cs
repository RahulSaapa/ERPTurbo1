using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class UserCompany
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CompanyId { get; set; }
        public int? YearOfPassout { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? Salary { get; set; }
        public int? Percentage { get; set; }
        public int? DesignationId { get; set; }

        public virtual CompanyAddress Company { get; set; }
        public virtual Designation Designation { get; set; }
        public virtual User User { get; set; }
    }
}
