using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Entities.DTOs;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TvSeriesController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;
        ITvSeriesService _tvService;
        private readonly IMapper _mapper;
        public TvSeriesController(ITvSeriesService tvService, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _tvService =tvService;
            _mapper = mapper;

        }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<TvSeriesDetailDto>> GetAsync([FromRoute] int id)
        {
            var result = await _tvService.GetAsync(id);
            if (result == null)
                return NotFound();
            var genresDto = _mapper.Map<TvSeriesDetailDto>(result);
            return Ok(genresDto);
        }
        [HttpGet("getAll")]
        public async Task<ActionResult<List<TvSeriesDetailDto>>> GetAllAsync()
        {
            

            var result = await _tvService.GetAllAsync();
            if (result == null)
                return NotFound();
            var tvDto = _mapper.Map<IEnumerable<TvSeriesDetailDto>>(result);
            return Ok(tvDto);
        }
        [HttpGet("genre/{genre}")]
        public async Task<ActionResult<List<TvSeriesDetailDto>>> GetAllByGenreAsync([FromRoute] string genre)
        {
            if (string.IsNullOrEmpty(genre))
                return BadRequest();
            var result = await _tvService.GetAllByGenreAsync(genre);
            if (result == null)
                return NotFound();

            var tvDto = _mapper.Map<IEnumerable<TvSeriesDetailDto>>(result);
            return Ok(tvDto);
        }
        [HttpGet("actor/{actor}")]
        public async Task<ActionResult<List<TvSeriesDetailDto>>> GetAllByActorAsync([FromRoute] string actor)
        {
            if (string.IsNullOrEmpty(actor))
                return BadRequest();
            var result = await _tvService.GetAllByActorAsync(actor);
            if (result == null)
                return NotFound();

            var tvDto = _mapper.Map<IEnumerable<TvSeriesDetailDto>>(result);
            return Ok(tvDto);
        }
        [HttpGet("Company/{company}")]
        public async Task<ActionResult<List<TvSeriesDetailDto>>> GetAllByCompanyAsync([FromRoute] string company)
        {
            if (string.IsNullOrEmpty(company))
                return BadRequest();
            var result = await _tvService.GetAllByCompanyAsync(company);
            if (result == null)
                return NotFound();

            var tvDto = _mapper.Map<IEnumerable<TvSeriesDetailDto>>(result);
            return Ok(tvDto);
        }
        [HttpGet("country/{country}")]
        public async Task<ActionResult<List<TvSeriesDetailDto>>> GetAllByCountryAsync([FromRoute] string country)
        {
            if (string.IsNullOrEmpty(country))
                return BadRequest();
            var result = await _tvService.GetAllByCountryAsync(country);
            if (result == null)
                return NotFound();

            var tvDto = _mapper.Map<IEnumerable<TvSeriesDetailDto>>(result);
            return Ok(tvDto);
        }


    }
}
