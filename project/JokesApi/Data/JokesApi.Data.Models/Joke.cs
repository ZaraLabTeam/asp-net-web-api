namespace JokesApi.Data.Models
{
    using Common.Models;

    public class Joke : BaseModel<int>
    {
        public string Content { get; set; }

        public int CategoryId { get; set; }

        public virtual JokeCategory Category { get; set; }

        public string CreatedById { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
    }
}
