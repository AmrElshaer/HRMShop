using HRMShop.App.Services;
using HRMShop.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMShop.App.Pages
{
    public partial class EmployeeDetail
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        [Inject]
        public IJobCategoryDataService JobCategoryDataService { get; set; }

        [Parameter]
        public string EmployeeId { get; set; }


        protected string JobCategory = string.Empty;

        public Employee Employee { get; set; } = new Employee();

        protected override async Task OnInitializedAsync()
        {
            Employee = await EmployeeDataService.GetEmployeeDetails(int.Parse(EmployeeId));
            JobCategory = (await JobCategoryDataService.GetJobCategoryById(Employee.JobCategoryId)).JobCategoryName;
        }
    }
}
