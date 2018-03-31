using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hex_Assignment.Entity.Test;

namespace Hex_Assignment.Models
{
    public class SoftSkillsModel
    {
        public int ID { get; set; }
        public string SkillSet { get; set; }
        public int SkillValue { get; set; }

        internal static List<SoftSkillsModel> Transfom(List<ICollection<USER_SKILL_RATING>> obj)
        {
            List<SoftSkillsModel> lstSoftSkills = new List<SoftSkillsModel>();
            List<USER_SKILL_RATING> Skills = obj[0].ToList();
            foreach (USER_SKILL_RATING skill in Skills)
            {
                SoftSkillsModel softSkills = new SoftSkillsModel();
                softSkills.ID = skill.SKILLSETID;
                softSkills.SkillSet = skill.SOFTSKILL_AREA.SkillSet;
                softSkills.SkillValue = skill.SKILLSETVALUE;
                lstSoftSkills.Add(softSkills);

            }
            return lstSoftSkills;

        }
    }
}