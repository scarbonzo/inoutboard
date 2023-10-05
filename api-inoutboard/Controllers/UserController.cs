using api_inoutboard.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System.Reflection.Metadata.Ecma335;

namespace api_inoutboard.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [Route("api/user")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var user = new User()
            {
                Id = 1,
                UserName = "reodice",
                DisplayName = "Rich",
                Email = "reodice@lsnj.org",
                GroupId = 1,
                Weeks = new List<Week>(),
                Updated = DateTime.Now
            };

            user.Weeks.Add(new Week
            {

            });

            return Ok(user);


            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var colUsers = database.GetCollection<User>(Configuration.userscollection);

                var results = colUsers
                    .AsQueryable()
                    .ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
