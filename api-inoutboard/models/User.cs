using System.Xml.Linq;

namespace api_inoutboard.models
{
    public class User
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public string UserName { get; set; }
        public string DisplayName { get; set; }
        public int GroupId { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public User(string UserName, string DisplayName, int GroupId, string Email, bool Active)
        {
            Random rnd = new Random();

            Id = rnd.Next(999999);
            this.UserName = UserName;
            this.DisplayName = DisplayName;
            this.GroupId = 406600;
            this.Active = Active;
            this.Email = Email;
            Created = DateTime.Now;
            Updated = DateTime.Now;
        }
    }
}
