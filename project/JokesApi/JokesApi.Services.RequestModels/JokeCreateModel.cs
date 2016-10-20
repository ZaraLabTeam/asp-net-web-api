namespace JokesApi.Services.RequestModels
{
    using System.ComponentModel.DataAnnotations;

    public class JokeCreateModel
    {
        [Required]
        [MinLength(10)]
        public string Content { get; set; }

        [Required]
        public string Category { get; set; }

        public string CreatedById { get; set; }
    }
}