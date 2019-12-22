using System.Collections;
using System.Collections.Generic;
using CRUD_Aspnetcore.Models;

namespace CRUD_Aspnetcore.Services
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetCountries();
        Country GetCountry(int countryId);
        Country GetCountryOfAnAuthor(int authorId);
        IEnumerable<Author> GetAuthorsFromACountry(int countryId);

        bool CountryExists(int countryId);
    }
}