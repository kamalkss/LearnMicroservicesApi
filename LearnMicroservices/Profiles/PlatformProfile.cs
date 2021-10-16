using AutoMapper;
using LearnMicroservices.Dtos;
using LearnMicroservices.Models;

namespace LearnMicroservices.Profiles
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
