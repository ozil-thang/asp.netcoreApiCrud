using System.Collections.Generic;
using System.Linq;
using CRUD_Aspnetcore.Dtos;
using CRUD_Aspnetcore.Models;
using CRUD_Aspnetcore.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Aspnetcore.Controllers
{
    
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        // GET
        private ICountryRepository _countryRepository;

        public CountriesController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(IEnumerable<CountryDto>))]
        public IActionResult GetCountries()
        {
            var countriesDto = _countryRepository.GetCountries().Select(c => new CountryDto()
            {
                Id = c.Id,
                Name = c.Name
            });
            return Ok(countriesDto);
        }
        
        [HttpGet("{countryId}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(CountryDto))]
        public IActionResult GetCountry(int countryId)
        {

            var country = _countryRepository.GetCountry(countryId);
            if (country == null)
                return NotFound();

            var countryDto = new CountryDto()
            {
                Id = country.Id,
                Name = country.Name
            };

            return Ok(countryDto);
        }

        [HttpGet("authors/{authorId}")]
        [ProducesResponseType(404)]
        [ProducesResponseType(200, Type = typeof(CountryDto))]
        public IActionResult GetCountryOfAnAuthor(int authorId)
        {
            var country = _countryRepository.GetCountryOfAnAuthor(authorId);

            if (country == null)
                return NotFound();
            
            var countryDto = new CountryDto()
            {
                Id = country.Id,
                Name = country.Name
            };

            return Ok(countryDto);

        }
    }
}