namespace api_inoutboard.models
{
    public class Event
    {
        public int Id { get; set; }
        public bool UserId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int StatusID { get; set; }
        public string Notes { get; set; }
    }
}
