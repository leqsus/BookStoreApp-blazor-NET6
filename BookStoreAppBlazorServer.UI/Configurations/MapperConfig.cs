using AutoMapper;
using BookStoreAppBlazorServer.UI.Services.Base;

namespace BookStoreAppBlazorServer.UI.Configurations
{
    public class MapperConfig:Profile
    {
        public MapperConfig()
        {
                CreateMap<AuthorReadOnlyDto,AuthorUpdateDto>().ReverseMap();
        }
    }
}
