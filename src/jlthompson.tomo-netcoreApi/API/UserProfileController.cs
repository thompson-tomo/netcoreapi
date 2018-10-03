using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using jlthompson.tomo_netcoreApi.Data;
using jlthompson.tomo_netcoreApi.Models;

namespace jlthompson.tomo_netcoreApi.API
{
    [Produces("application/json")]
    [Route("api/jlthompson_tomo_at_outlook_com/profiles")]
    public class UserProfileController : Controller
    {
        public UserProfileController(PrimaryDbContext PrimaryDb)
        {
            this.primaryDb = PrimaryDb;
        }

        public PrimaryDbContext primaryDb;
        // GET: api/UserProfile
        [HttpGet]
        public IEnumerable<UserProfiles> Get()
        {
            return primaryDb.UserProfiles.ToList();
        }

        // GET: api/UserProfile/5
        [HttpGet("{id}", Name = "Get")]
        public UserProfiles Get(int id)
        {
            return primaryDb.UserProfiles.FirstOrDefault(x => x.UserId == id);
        }
        
        // POST: api/UserProfile
        [HttpPost]
        public UserProfiles Post([FromBody]UserProfiles profile)
        {
            if (!ModelState.IsValid)
            {
                Response.StatusCode = 400;
                return null;
            }
            if (string.IsNullOrWhiteSpace(profile.Team))
            {
                profile.Team = "Not provided.";
            }
            if (string.IsNullOrWhiteSpace(profile.Department))
            {
                profile.Department = "Not provided.";
            }
            primaryDb.UserProfiles.Add(profile);
            return profile;
        }
        
        // PUT: api/UserProfile/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]UserProfiles profile)
        {
            if (!ModelState.IsValid || id == 0 || id != profile.UserId)
            {
                Response.StatusCode = 400;
                return;
            }
            if (primaryDb.UserProfiles.Any(x => x.UserId == id))
            {
                if (profile == null)
                {
                    Response.StatusCode = 400;
                }
                primaryDb.UserProfiles.Update(profile);
                Response.StatusCode = 204;
            }
            else
            {
                Response.StatusCode = 500;
            }
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public UserProfiles Delete(int id)
        {
            UserProfiles profiles = primaryDb.UserProfiles.FirstOrDefault(x => x.UserId == id);
            if (profiles != null)
            {
                primaryDb.UserProfiles.Remove(profiles);
                Response.StatusCode = 200;
            }
            else
            {
                Response.StatusCode = 404;
            }
            return profiles;
        }
    }
}
