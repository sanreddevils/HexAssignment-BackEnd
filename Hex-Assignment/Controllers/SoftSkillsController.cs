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
    public class SoftSkillsController : ApiController
    {

        // GET: api/SoftSkills
        [HttpGet]
        [Authorize]
        public List<SoftSkillsModel> Get(int UserId)
        {
            return SoftSkillsFacade.GetUserSkillRating(UserId);
           
        }
           
       
               

        // POST: api/SoftSkills
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/SoftSkills/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/SoftSkills/5
        public void Delete(int id)
        {
        }
    }
}
