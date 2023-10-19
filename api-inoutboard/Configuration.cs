using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_inoutboard
{
    public class Configuration
    {
        public static string dbconnection = "";
        public static string dbname = "inoutboard";
        public static string userscollection = "users";
        public static string eventscollection = "events";
        public static string statusescollection = "statuses";
        public static string groupscollection = "groups";
    }
}
