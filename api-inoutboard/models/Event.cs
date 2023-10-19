using Microsoft.AspNetCore.Http.HttpResults;

namespace api_inoutboard.models
{
    public class Event
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int StatusId { get; set; }
        public string Notes { get; set; }

        public Event(int UserId, DateTime Start, DateTime End, int StatusId, string Notes)
        {
            Random rnd = new Random();

            Id = rnd.Next(999999);
            this.UserId = UserId;
            this.Start = Start;
            this.End = End;
            this.StatusId = StatusId;
            this.Notes = Notes;
            
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}
