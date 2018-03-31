using Hex_Assignment.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hex_Assignment.Facades
{
    public class LoginFacade
    {
        public static string Login(string email,string password)
        {

            using (HexModel db = new HexModel())
            {
                List<USER_MASTER> users = db.USER_MASTER.Where(t => t.Email == email && t.Password == password).ToList();
                if (users.Count > 0)
                    return "success";
                else
                    return "moonji";
            }

            return "success";
        }
    }
}