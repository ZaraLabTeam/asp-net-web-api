namespace JokesApi.Web
{
    using System.Linq;
    using System.Net.Http.Formatting;
    using System.Web.Http;
    using Microsoft.Owin.Security.OAuth;
    using Newtonsoft.Json.Serialization;

    public class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.
            // This will used the HTTP header: "Authorization"      Value: "Bearer 1234123412341234asdfasdfasdfasdf"
            config.SuppressDefaultHostAuthentication();
            config.Filters.Add(new HostAuthenticationFilter(OAuthDefaults.AuthenticationType));

            // Web API routes
            config.MapHttpAttributeRoutes();

            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();

            config.Routes.MapHttpRoute(
                    name: "JokesApi",
                    routeTemplate: "api/{controller}/{id}",
                    defaults: new { id = RouteParameter.Optional });
        }
    }
}
