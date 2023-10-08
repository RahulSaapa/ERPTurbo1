using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Designation
    {
        public Designation()
        {
            UserCompanies = new HashSet<UserCompany>();
        }

        public int Id { get; set; }
        public string DesignationName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<UserCompany> UserCompanies { get; set; }
    }
}
