using HRMShop.App.Services;
using HRMShop.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HRMShop.App.Pages
{
    public partial class EmployeeOverview
    {
        [Inject]
        public IEmployeeDataService EmployeeDataService { get; set; }

        public List<Employee> Employees { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Employees = (await EmployeeDataService.GetAllEmployees()).ToList();
        }
        
    }
}
