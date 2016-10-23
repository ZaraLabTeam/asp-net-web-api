namespace Crawler
{
    using System;
    using AngleSharp;
    using JokesApi.Data;
    using JokesApi.Data.Common;
    using JokesApi.Data.Models;
    using JokesApi.Services.Data;

    public static class Program
    {
        private static CategoriesService categoriesService;
        private static ApplicationDbContext db;

        public static void Main()
        {
            db = new ApplicationDbContext();
            var repo = new DbRepository<JokeCategory>(db);
            categoriesService = new CategoriesService(repo);

            var configuration = Configuration.Default.WithDefaultLoader();
            var browsingContext = BrowsingContext.New(configuration);

            for (int i = 1; i <= 10000; i++)
            {
                var url = $"http://vicove.com/vic-{i}";
                var document = browsingContext.OpenAsync(url).Result;
                var jokeContent = document.QuerySelector("#content_box .post-content").TextContent.Trim();
                if (!string.IsNullOrWhiteSpace(jokeContent))
                {
                    var categoryName = document.QuerySelector("#content_box .thecategory a").TextContent.Trim();
                    TryAddJoke(jokeContent, categoryName);

                    if (i % 100 == 0)
                    {
                        TrySaveChanges(i);
                    }
                }
            }
        }

        private static void TryAddJoke(string jokeContent, string categoryName)
        {
            try
            {
                var category = categoriesService.EnsureCategory(categoryName);
                var joke = new Joke { Category = category, Content = jokeContent };
                db.Jokes.Add(joke);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid joke model skipping this one");
            }
        }

        private static void TrySaveChanges(int i)
        {
            try
            {
                db.SaveChanges();
                Console.WriteLine("Created {0} jokes", i);
            }
            catch (Exception)
            {
            }
        }
    }
}
