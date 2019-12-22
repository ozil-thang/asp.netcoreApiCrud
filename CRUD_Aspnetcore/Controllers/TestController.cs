using CRUD_Aspnetcore.Models;
using CRUD_Aspnetcore.Services;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Aspnetcore.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestController : ControllerBase
    {
        private ICountryRepository _countryRepository;
        // GET
        public TestController(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }
        
        [HttpGet]
        public ActionResult<Country> Index()
        {
            return Ok(_countryRepository.GetCountryOfAnAuthor(2));
        }
    }
}