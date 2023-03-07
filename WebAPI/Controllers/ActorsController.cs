using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActorsController : ControllerBase
    {
        IActorService _actorService;
        private readonly IMapper _mapper;
        public ActorsController(IActorService actorService, IMapper mapper)
        {
            _actorService = actorService;
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<ActionResult<List<ActorDetailDto>>> GetAllAsync()
        {
            var result = await _actorService.GetAllAsync();
            if (result == null)
                return NotFound();
            var actorDto = _mapper.Map<IEnumerable<ActorDetailDto>>(result);
            return Ok(actorDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ActorDetailDto>> GetAsync([FromRoute] int id)
        {
            var result = await _actorService.GetAsync(id);
            if (result == null)
                return NotFound();
            var actorDto = _mapper.Map<ActorDetailDto>(result);
            return Ok(actorDto);
        }
    }
}
