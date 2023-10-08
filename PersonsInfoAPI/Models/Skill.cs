using System;
using System.Collections.Generic;

#nullable disable

namespace PersonsInfoAPI.Models
{
    public partial class Skill
    {
        public Skill()
        {
            UserSkills = new HashSet<UserSkill>();
        }

        public int Id { get; set; }
        public string SkillName { get; set; }
        public string Code { get; set; }

        public virtual ICollection<UserSkill> UserSkills { get; set; }
    }
}
