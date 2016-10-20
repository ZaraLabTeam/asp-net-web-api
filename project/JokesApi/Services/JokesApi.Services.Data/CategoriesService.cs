﻿namespace JokesApi.Services.Data
{
    using System.Linq;

    using JokesApi.Data.Common;
    using JokesApi.Data.Models;

    public class CategoriesService : ICategoriesService
    {
        private readonly IDbRepository<JokeCategory> categories;

        public CategoriesService(IDbRepository<JokeCategory> categories)
        {
            this.categories = categories;
        }

        public JokeCategory EnsureCategory(string name)
        {
            var category = this.categories.All().FirstOrDefault(x => x.Name == name);
            if (category != null)
            {
                return category;
            }

            category = new JokeCategory { Name = name };
            this.categories.Add(category);
            this.categories.Save();
            return category;
        }

        public JokeCategory Find(string category)
        {
            return this.categories.All().First(c => c.Name == category);
        }

        public IQueryable<JokeCategory> GetAll()
        {
            return this.categories.All().OrderBy(x => x.Name);
        }
    }
}
