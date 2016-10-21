namespace JokesApi.Web.ViewModels.Category
{
    using System;
    using System.Collections.Generic;
    using AutoMapper;
    using Data.Models;
    using Infrastructure.Mapping;
    using Joke;

    public class CategoryContentModel : JokeCategorySimpleModel, IMapFrom<JokeCategory>, IHaveCustomMappings
    {
        public ICollection<JokeViewModel> Jokes { get; set; }

        public string CreatedById { get; set; }

        public string CreateBy { get; set; }

        public DateTime CreatedOn { get; set; }

        public void CreateMappings(IMapperConfiguration configuration)
        {
            configuration.CreateMap<JokeCategory, CategoryContentModel>()
                .ForMember(c => c.CreateBy, opt => opt.MapFrom(c => c.CreatedBy.UserName));
        }
    }
}
