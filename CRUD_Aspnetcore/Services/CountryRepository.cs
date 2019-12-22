using System.Collections.Generic;
using System.Linq;
using CRUD_Aspnetcore.Models;

namespace CRUD_Aspnetcore.Services
{
    public class CountryRepository : ICountryRepository
    {
        private BookDbContext _countryContext;

        public CountryRepository(BookDbContext countryContext)
        {
            _countryContext = countryContext;
        }
        
        public IEnumerable<Country> GetCountries()
        {
            return _countryContext.Countries.OrderBy(c => c.Name).ToList();
        }

        public Country GetCountry(int countryId)
        {
            return _countryContext.Countries.FirstOrDefault(c => c.Id == countryId);
        }

        public Country GetCountryOfAnAuthor(int authorId)
        {
            return _countryContext.Authors.Where(a => a.Id == authorId).Select(c => c.Country).FirstOrDefault();
        }

        public IEnumerable<Author> GetAuthorsFromACountry(int countryId)
        {
            return _countryContext.Authors.Where(a => a.Country.Id == countryId).ToList();
        }

        public bool CountryExists(int countryId)
        {
            return _countryContext.Countries.Any(c => c.Id == countryId);
        }
    }
}