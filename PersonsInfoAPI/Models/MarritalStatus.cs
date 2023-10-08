using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class MarritalStatus
    {
        public MarritalStatus()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string StatusName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
