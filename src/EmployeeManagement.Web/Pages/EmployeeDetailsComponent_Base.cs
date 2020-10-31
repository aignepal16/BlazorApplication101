using EmployeeManagement.Models;
using EmployeeManagement.Web.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages
{
    public class EmployeeDetailsComponent_Base : ComponentBase
    {
        public Employee Employee { get; set; } = new Employee();

        [Inject]
        public IEmployeeService EmployeeService { get; set; }

        [Parameter]
        public string Id { get; set; }


       
        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Employee = await EmployeeService.GetEmployee(int.Parse(Id));            
        }

        //================================================================================
        protected string Coordinates { get; set; } = "N/A";
        protected void Mouse_Move(MouseEventArgs mouseEventArgs)
        {
            Coordinates = $"X = {mouseEventArgs.ClientX} , Y = {mouseEventArgs.ClientY}";
        }

        //================================================================================

        protected string ButtonText { get; set; } = "Hide Footer";
        protected string ButtonCssClass { get; set; } = null;

        protected void ButtonClick_Fn()
        {
            if (ButtonText == "Hide Footer")
            {
                ButtonText = "Show Footer";
                ButtonCssClass = "HideFooter";
            }
            else
            {
                ButtonCssClass = null;
                ButtonText = "Hide Footer";
            }
        }


    }
}
