using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class UserSkill
    {
        public int Id { get; set; }
        public int? SkillId { get; set; }
        public bool? IsPrimary { get; set; }
        public int? UserId { get; set; }
        public int? OrderId { get; set; }

        public virtual Skill Skill { get; set; }
        public virtual User User { get; set; }
    }
}
