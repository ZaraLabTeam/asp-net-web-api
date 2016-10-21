namespace JokesApi.Web.ViewModels.Joke
{
    using System;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;
    using Services.Web;

    public class JokeViewModel : IMapFrom<Joke>, IHaveCustomMappings
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public string Category { get; set; }

        public string CreatedById { get; set; }

        public DateTime CreatedOn { get; set; }

        public string CreatedBy { get; set; }

        public string Url
        {
            get
            {
                IIdentifierProvider identifier = new IdentifierProvider();
                return $"/Joke/{identifier.EncodeId(this.Id)}";
            }
        }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<Joke, JokeViewModel>()
                .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name))
                .ForMember(x => x.CreatedBy, opt => opt.MapFrom(x => x.CreatedBy.Email));
        }
    }
}
