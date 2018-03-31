using Hex_Assignment.Entity;
using Hex_Assignment.Entity.Test;
using Hex_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hex_Assignment.Facades
{
    public class SoftSkillsFacade
    {
        public static List<SoftSkillsModel> GetUserSkillRating(int UserId)
        {
            //using (HexModel db = new HexModel())
            //{
            //    USER_MASTER user = db.USER_MASTER.Where(x => x.ID == UserId).SingleOrDefault();
            //    List<USER_SKILL_RATING> users = db.USER_SKILL_RATING.ToList();
            //    return users;

                

            //    //List<USER_SKILL_RATING> users = db.USER_SKILL_RATING.ToList();
            //    //return users;


            //}
            
            var db = new TestModel();
            List<Entity.Test.USER_MASTER> userDetails = new List<Entity.Test.USER_MASTER>();
            userDetails = db.USER_MASTER.Where(x =>x.ID == UserId).ToList();
            var obj = userDetails.Select(x => x.USER_SKILL_RATING).ToList();

            List<SoftSkillsModel> softSkills = SoftSkillsModel.Transfom(obj);
            return softSkills;


            
            //return db.USER_SKILL_RATING.Where(rs => rs.USERID == UserId).Where(x => x.USER_MASTER.ID == UserId).Where(x => x.SKILLSETID == x.SOFTSKILL_AREA.ID).ToList();
           // return db.USER_SKILL_RATING.ToList();

           
        }
    }
}