namespace api_inoutboard.models
{
    public class Status
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }

        public Status(string Name, bool Active)
        {
            Random rnd = new Random();

            Id = rnd.Next(999999);
            this.Active = Active;
            this.Name = Name;
        }
    }
}
