namespace JokesApi.Web
{
    using System.Web.Http;

    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
        }
    }
}
