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
    public class ProductionCompaniesController : ControllerBase
    {
        IProductionCompanyService _productionCompany;
        private readonly IMapper _mapper;
        public ProductionCompaniesController(IProductionCompanyService productionCompany, IMapper mapper)
        {
            _productionCompany = productionCompany;
            _mapper = mapper;
        }
        [HttpGet("getall")]
        public async Task<ActionResult<List<ProductionCompanyDetailDto>>> GetAllAsync()
        {
            var result = await _productionCompany.GetAllAsync();
            if (result == null)
                return NotFound();
            var productionCompanyDto = _mapper.Map<IEnumerable<ProductionCompanyDetailDto>>(result);
            return Ok(productionCompanyDto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductionCompanyDetailDto>> GetAsync([FromRoute] int id)
        {
            var result = await _productionCompany.GetAsync(id);
            if (result == null)
                return NotFound();
            var productionCompanyDto = _mapper.Map<ProductionCompanyDetailDto>(result);
            return Ok(productionCompanyDto);
        }
    }
}
