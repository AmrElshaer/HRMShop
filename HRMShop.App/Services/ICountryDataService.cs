using System.Collections.Generic;
using System.Threading.Tasks;
using HRMShop.Shared;

namespace HRMShop.App.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
