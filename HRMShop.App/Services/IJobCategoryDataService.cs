using System.Collections.Generic;
using System.Threading.Tasks;
using HRMShop.Shared;

namespace HRMShop.App.Services
{
    public interface IJobCategoryDataService
    {
        Task<IEnumerable<JobCategory>> GetAllJobCategories();
        Task<JobCategory> GetJobCategoryById(int jobCategoryId);
    }
}
