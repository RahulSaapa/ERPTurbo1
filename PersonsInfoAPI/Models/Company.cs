using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Company
    {
        public Company()
        {
            CompanyAddresses = new HashSet<CompanyAddress>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<CompanyAddress> CompanyAddresses { get; set; }
    }
}
