namespace api_inoutboard.models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public int GroupId { get; set; }
        public string Email { get; set; }
        public List<Week> Weeks { get; set; }
        public DateTime Updated { get; set; }

        public User() {
            Random rnd = new Random();

            Id = rnd.Next(999999);
            Updated = DateTime.Now;
            UserName = "reodice";
            DisplayName = "Rich";
            GroupId = 1;
            Email = "reodice@lsnj.org";
            Weeks = new List<Week>();
        }
    }
}
