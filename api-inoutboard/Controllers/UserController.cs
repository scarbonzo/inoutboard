﻿using api_inoutboard.models;
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
        [Route("api/users/seed")]
        [HttpGet]
        public ActionResult Seed()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<User>(Configuration.userscollection);

                List<User> users = new List<User>
                {
                    new User("REodice", "Rich Eodice", 406600, "reodice@lsnj.org", true)
                };

                collection.InsertMany(users);

                var results = collection.AsQueryable()
                .ToList();

                return Ok(results);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("api/users")]
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                var dbClient = new MongoClient(Configuration.dbconnection);
                var database = dbClient.GetDatabase(Configuration.dbname);
                var collection = database.GetCollection<User>(Configuration.userscollection);

                var results = collection.AsQueryable()
                    .Where(u => u.Active)
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
