using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HRMShop.Shared;

namespace HRMShop.Api.Models
{
    public interface ICountryRepository
    {
        IEnumerable<Country> GetAllCountries();
        Country GetCountryById(int countryId);
    }
}
