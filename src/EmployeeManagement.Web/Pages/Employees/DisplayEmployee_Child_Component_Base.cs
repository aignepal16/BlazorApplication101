using EmployeeManagement.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages.Employees
{
    public class DisplayEmployee_Child_Component_Base : ComponentBase
    {
        [Parameter]
        public Employee ChildEmployee { get; set; }
        [Parameter]
        public bool ChildShowFooter { get; set; }

        [Parameter]
        public EventCallback<bool> onEmployeeSelection { get; set; }

        protected async Task CheckBoxChanged(ChangeEventArgs e)
        {
            await onEmployeeSelection.InvokeAsync((bool)e.Value);
        }
    }
}
