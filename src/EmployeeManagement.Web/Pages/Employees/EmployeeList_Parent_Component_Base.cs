using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages.Employees
{
    public class EmployeeList_Parent_Component_Base : ComponentBase
    {
        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        public IEnumerable<Employee> Employees { get; set; }

        public bool ShowFooter { get; set; } = true;

        protected async override Task OnInitializedAsync()
        {
            Employees = (await EmployeeService.GetEmployees()).ToList();
        }

        protected int SelectedEmployeeCount { get; set; } = 0;
        protected void EmployeeSelectionChanged(bool isSelected)
        {
            if (isSelected)
                SelectedEmployeeCount++;
            else
                SelectedEmployeeCount--;
        }

    }
}
