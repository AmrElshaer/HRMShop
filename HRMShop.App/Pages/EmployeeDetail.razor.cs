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
        [Parameter]
        public string EmployeeId { get; set; }
        public Employee Employee { get; set; } = new();
        public IEnumerable<Employee> Employees { get; set; }
        public List<Country> Countries { get; set; }
        public List<JobCategory> JobCategories { get; set; }
        protected override Task OnInitializedAsync()
        {
            InitCountries();
            InitJobCategories();
            InitEmployees();
            Employee= Employees.FirstOrDefault(e=>e.EmployeeId==int.Parse(EmployeeId));
            return base.OnInitializedAsync();
        }

        private void InitCountries()
        {
            Countries = new List<Country>() {
              new Country()
              {
                  CountryId=1,
                  Name="Egypt"
              }
            };

        }

        private void InitJobCategories()
        {
            JobCategories = new List<JobCategory>()
            {
                new JobCategory{JobCategoryId=1,JobCategoryName="Job"}
            };
        }

        private void InitEmployees()
        {
            Employees = new List<Employee>()
            {
                new Employee()
                {
                    CountryId=1,
                    EmployeeId=1,
                    JobCategoryId=1,
                    FirstName="Amr",
                    LastName="Elshaer"
                }
            };
        }
    }
}
