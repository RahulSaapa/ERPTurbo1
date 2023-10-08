using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string GenderName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
