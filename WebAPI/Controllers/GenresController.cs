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
    public class GenresController : ControllerBase
    {
        IGenreService _genreService;
        private readonly IMapper _mapper;
        public GenresController(IGenreService genreService , IMapper mapper)
        {
            _genreService = genreService;
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<ActionResult<List<GenreDetailDto>>> GetAllAsync()
        {
            var result = await _genreService.GetAllAsync();
            if (result == null)
                return NotFound();
            var genresDto = _mapper.Map<IEnumerable<GenreDetailDto>>(result);
            return Ok(genresDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<GenreDetailDto>> GetAsync([FromRoute] int id)
        {
            var result = await _genreService.GetAsync(id);
            if (result == null)
                return NotFound();
            var genresDto = _mapper.Map<GenreDetailDto>(result);
            return Ok(genresDto);
        }
    }
}
