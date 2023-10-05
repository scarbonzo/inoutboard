using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_inoutboard
{
    public class Configuration
    {
        public static string dbconnection = "mongodb://192.168.50.125:27017";
        public static string dbname = "inoutboard2";
        public static string userscollection = "users";
        public static string templatecollection = "templates";
        public static string statusescollection = "statuses";
        public static string groupscollection = "groups";
        public static string oncallscollection = "oncall";
    }
}
