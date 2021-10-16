using AutoMapper;
using PlatformService.Dtos;
using PlatformService.Models;

namespace PlatformService.Profiles
{
    public class PlatformProfile : Profile
    {
        public PlatformProfile()
        {
            // Source -> Targer
            CreateMap<Platforms, PlatformReadDto>();
            CreateMap<PlatformCreateDto, Platforms>();
        }
    }
}
