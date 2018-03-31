using Hex_Assignment.Entity;
using Hex_Assignment.Facades;
using Hex_Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hex_Assignment.Controllers
{
    public class LoginController : ApiController
    {
        // GET: api/Login
        [Authorize]
        public string Get()
        {
            return "true";
        }

        // GET: api/Login/5
       
        public USER_MASTER Get(int id)
        {
           
            using (HexModel db = new HexModel())
            {
                List<USER_MASTER> users = db.USER_MASTER.ToList();
                return users[0];
            }
        }

        // POST: api/Login
        [AllowAnonymous]
        public string Post([FromBody]LoginModel model)
        {
           return LoginFacade.Login(model.Email, model.Password);
        }

        
        // PUT: api/Login/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Login/5
        public void Delete(int id)
        {
        }
    }
}
