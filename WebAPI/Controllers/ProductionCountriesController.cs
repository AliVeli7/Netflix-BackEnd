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
    public class ProductionCountriesController : ControllerBase
    {
        IProductionCountryService _productionCountry;
        private readonly IMapper _mapper;
        public ProductionCountriesController(IProductionCountryService productionCountry, IMapper mapper)
        {
            _productionCountry = productionCountry;
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<ActionResult<List<ProductionCountryDetailDto>>> GetAllAsync()
        {
            var result = await _productionCountry.GetAllAsync();
            if (result == null)
                return NotFound();
            var productionCountryDto = _mapper.Map<IEnumerable<ProductionCountryDetailDto>>(result);
            return Ok(productionCountryDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductionCountryDetailDto>> GetAsync([FromRoute] int id)
        {
            var result = await _productionCountry.GetAsync(id);
            if (result == null)
                return NotFound();
            var productionCountryDto = _mapper.Map<ProductionCountryDetailDto>(result);
            return Ok(productionCountryDto);
        }
    }
}
