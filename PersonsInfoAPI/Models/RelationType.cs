using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class RelationType
    {
        public RelationType()
        {
            Families = new HashSet<Family>();
        }

        public int Id { get; set; }
        public string RelationName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<Family> Families { get; set; }
    }
}
