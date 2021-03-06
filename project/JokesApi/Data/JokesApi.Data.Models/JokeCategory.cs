﻿namespace JokesApi.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using JokesApi.Data.Common.Models;

    public class JokeCategory : BaseModel<int>
    {
        public JokeCategory()
        {
            this.Jokes = new HashSet<Joke>();
        }

        [Required]
        [MinLength(4)]
        [MaxLength(1000)]
        [Index(IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Joke> Jokes { get; set; }

        public string CreatedById { get; set; }

        public virtual ApplicationUser CreatedBy { get; set; }
    }
}
