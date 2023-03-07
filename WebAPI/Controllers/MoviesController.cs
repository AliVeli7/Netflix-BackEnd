using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.Models;
using Entities.DTOs;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        public static IWebHostEnvironment _webHostEnvironment;
        IMovieService _movieService;
        private readonly IMapper _mapper;
        public MoviesController(IMovieService movieService, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
            _movieService = movieService;
            _mapper = mapper;
           
         }

        [HttpGet("get/{id}")]
        public async Task<ActionResult<MovieDetailDto>> GetAsync([FromRoute] int id)
        {
            var result = await _movieService.GetAsync(id);
            if (result == null)
                return NotFound();
            var genresDto = _mapper.Map<MovieDetailDto>(result);
            return Ok(genresDto);
        }
        [HttpGet("getAll")]
        public async Task<ActionResult<List<MovieDetailDto>>> GetAllAsync()
        {
            var languageCode = "en";
            if (string.IsNullOrEmpty(languageCode))
                return BadRequest();

            var result = await _movieService.GetAllAsync(languageCode);
            if (result == null)
                return NotFound();
            var movieDto = _mapper.Map<IEnumerable<MovieDetailDto>>(result);
            return Ok(movieDto);
        }
        [HttpGet("genre/{genre}")]
        public async Task<ActionResult<List<MovieDetailDto>>> GetAllByGenreAsync([FromRoute] string genre)
        {
            if (string.IsNullOrEmpty(genre))
                return BadRequest();
            var result = await _movieService.GetAllByGenreAsync(genre);
            if (result == null)
                return NotFound();

            var movieDto = _mapper.Map<IEnumerable<MovieDetailDto>>(result);
            return Ok(movieDto);
        }
        [HttpGet("actor/{actor}")]
        public async Task<ActionResult<List<MovieDetailDto>>> GetAllByActorAsync([FromRoute] string actor)
        {
            if (string.IsNullOrEmpty(actor))
                return BadRequest();
            var result = await _movieService.GetAllByActorAsync(actor);
            if (result == null)
                return NotFound();

            var movieDto = _mapper.Map<IEnumerable<MovieDetailDto>>(result);
            return Ok(movieDto);
        }
        [HttpGet("Company/{company}")]
        public async Task<ActionResult<List<MovieDetailDto>>> GetAllByCompanyAsync([FromRoute] string company)
        {
            if (string.IsNullOrEmpty(company))
                return BadRequest();
            var result = await _movieService.GetAllByCompanyAsync(company);
            if (result == null)
                return NotFound();

            var movieDto = _mapper.Map<IEnumerable<MovieDetailDto>>(result);
            return Ok(movieDto);
        }
        [HttpGet("country/{country}")]
        public async Task<ActionResult<List<MovieDetailDto>>> GetAllByCountryAsync([FromRoute] string country)
        {
            if (string.IsNullOrEmpty(country))
                return BadRequest();
            var result = await _movieService.GetAllByCountryAsync(country);
            if (result == null)
                return NotFound();

            var movieDto = _mapper.Map<IEnumerable<MovieDetailDto>>(result);
            return Ok(movieDto);
        }


        [HttpPost("add")]
        public async Task<IActionResult>  Add([FromBody] List<MovieDetailDto> addmovies )
        {
            foreach (var addmovie in addmovies)
            {
                var movie = new Movie
                {

                };
            }


            return Ok();
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromForm] Movie movie)
        {
            try
            {
                if (movie.Poster.Length>0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream=System.IO.File.Create(path + movie.Poster.FileName))
                    {
                        movie.Poster.CopyTo(fileStream);
                        fileStream.Flush();
                        return Ok("Done");
                    }
                }
                else
                {
                    return Ok("failed");
                }
            }
            catch (Exception ex)
            {

                return Ok(ex.Message);
            }
        }

        [HttpGet("file/{file}")]
        public async Task<IActionResult> Get([FromRoute] string file)
        {
            string path = _webHostEnvironment.WebRootPath + "\\img\\";
            var filepath = path + file;
            if (System.IO.File.Exists(filepath))
            {
                byte[] b = System.IO.File.ReadAllBytes(filepath);
                return File(b,"image/jpg");
            }
            return Ok("hii");
        }
    }
}
