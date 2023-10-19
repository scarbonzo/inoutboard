using api_inoutboard.models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace api_inoutboard.Controllers
{
    [ApiController]
    public class EventController : Controller
    {
        [Route("api/events/seed")]
        [HttpGet]
        public ActionResult Seed()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<Event>(Configuration.eventscollection);

                List<Event> events = new List<Event>
                {
                    new Event(80762, new DateTime(2023,10,16,8,0,0), new DateTime(2023,10,16,16,0,0), 108982, ""),
                    new Event(80762, new DateTime(2023,10,17,8,0,0), new DateTime(2023,10,17,16,0,0), 108982, ""),
                    new Event(80762, new DateTime(2023,10,18,7,30,0), new DateTime(2023,10,18,15,30,0), 792128, ""),
                    new Event(80762, new DateTime(2023,10,19,8,0,0), new DateTime(2023,10,19,16,0,0), 108982, ""),
                    new Event(80762, new DateTime(2023,10,20,8,0,0), new DateTime(2023,10,20,16,0,0), 108982, "")
                };

                collection.InsertMany(events);

                var results = collection.AsQueryable()
                .ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("api/events/today")]
        [HttpGet]
        public ActionResult GetAllToday()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<Event>(Configuration.eventscollection);

                var results = collection.AsQueryable()
                    .Where(x => x.Start.DayOfYear == DateTime.Now.DayOfYear)
                    .ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("api/events/user/{userid}")]
        [HttpGet]
        public ActionResult GetAllUser(int userid)
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<Event>(Configuration.eventscollection);

                var results = collection.AsQueryable()
                    .Where(x => x.UserId == userid)
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
