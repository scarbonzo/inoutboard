using api_inoutboard.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace api_inoutboard.Controllers
{
    [ApiController]
    public class GroupController : ControllerBase
    {
        [Route("api/groups/seed")]
        [HttpGet]
        public ActionResult Seed()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<Group>(Configuration.groupscollection);

                List<Group> groups = new List<Group>
                {
                    new Group("Management", true),
                    new Group("Core", true),
                    new Group("Helpdesk", true),
                    new Group("Web", true),
                    new Group("Multi", true)
                };

                collection.InsertMany(groups);

                var results = collection.AsQueryable()
                .ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("api/groups")]
        [HttpGet]
        public ActionResult GetAllActive()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<Group>(Configuration.groupscollection);

                var results = collection.AsQueryable()
                    .Where(g => g.Active)
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
