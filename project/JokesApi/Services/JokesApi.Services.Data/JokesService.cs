namespace JokesApi.Services.Data
{
    using System;
    using System.Linq;

    using JokesApi.Data.Common;
    using JokesApi.Data.Models;
    using JokesApi.Services.Web;
    using RequestModels;

    public class JokesService : IJokesService
    {
        private readonly IDbRepository<Joke> jokes;
        private readonly IIdentifierProvider identifierProvider;

        public JokesService(IDbRepository<Joke> jokes, IIdentifierProvider identifierProvider)
        {
            this.jokes = jokes;
            this.identifierProvider = identifierProvider;
        }

        public Joke GetById(string id)
        {
            var intId = this.identifierProvider.DecodeId(id);
            var joke = this.GetById(intId);
            return joke;
        }

        public Joke GetById(int id)
        {
            var joke = this.jokes.GetById(id);
            return joke;
        }

        public IQueryable<Joke> GetRange(int start, int end)
        {
            if (start < 0 || end < start)
            {
                throw new ArgumentException("Invalid start/end parameters");
            }

            return this.jokes.All().OrderBy(j => j.Id).Skip(start).Take(end - start);
        }

        public Joke Create(JokeCreateModel model, JokeCategory category)
        {
            var joke = new Joke
            {
                Category = category,
                CreatedById = model.CreatedById,
                Content = model.Content,
            };

            this.jokes.Add(joke);
            this.jokes.Save();

            return joke;
        }

        public IQueryable<Joke> GetRandomJokes(int count)
        {
            return this.jokes.All().OrderBy(x => Guid.NewGuid()).Take(count);
        }
    }
}
