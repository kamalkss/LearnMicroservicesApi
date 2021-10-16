using AutoMapper;
using LearnMicroservices.Dtos;
using LearnMicroservices.Models;
using LearnMicroservices.Services;
using Microsoft.AspNetCore.Mvc;

namespace LearnMicroservices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformsController : ControllerBase
    {
        private readonly IPlatformRepo _Repository;
        private readonly IMapper _mapper;

        public PlatformsController(IPlatformRepo Repository,IMapper mapper)
        {
            _Repository = Repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult<IEnumerable<PlatformReadDto>> GetPlatforms()
        {
            Console.WriteLine("--> Getting Platform");
            
            var PlatformItem = _Repository.GetAllPlatforms();

            return Ok(_mapper.Map<IEnumerable<PlatformReadDto>>(PlatformItem));
        }
        
        [HttpGet("{id}",Name ="GetPlaformById")]
        public ActionResult<PlatformReadDto> GetPlatformById(Guid Id)
        {
            Console.WriteLine("--> Platform Id");
            var PlatformItem = _Repository.GetPlatformById(Id);
            if(PlatformItem != null)
            {
                return Ok(_mapper.Map<PlatformReadDto>(PlatformItem));
            }

            return NotFound();

        }
        [HttpPost]
        public ActionResult<PlatformReadDto> CreatePlatform(PlatformCreateDto platformCreateDto)
        {
            Console.WriteLine("Creating Platform");
            var PlatformItem = _mapper.Map<Platforms>(platformCreateDto);
            _Repository.CreatePlatform(PlatformItem);
            _Repository.SaveChanges();
            var platformReadDto =  _mapper.Map<PlatformReadDto>(PlatformItem);
            return CreatedAtRoute(nameof(GetPlatformById), new { id = platformReadDto.PlatformId }, platformReadDto);
        }
    }
}
