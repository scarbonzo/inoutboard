using api_inoutboard.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace api_inoutboard.Controllers
{
    [ApiController]
    public class StatusController : ControllerBase
    {
        [Route("api/statuses/seed")]
        [HttpGet]
        public ActionResult Seed()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<Status>(Configuration.statusescollection);

                List<Status> statuses = new List<Status>
                {
                    new Status("Office", true),
                    new Status("WFH", true),
                    new Status("Out", true),
                    new Status("Vacation", true),
                    new Status("Holiday", true),
                    new Status("Training", true),
                    new Status("Offsite", true)
                };

                collection.InsertMany(statuses);

                var results = collection.AsQueryable()
                .ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("api/statuses")]
        [HttpGet]
        public ActionResult GetAllActive()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<Status>(Configuration.statusescollection);

                var results = collection.AsQueryable()
                    .Where(s => s.Active)
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
