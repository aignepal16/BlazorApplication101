using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Web.Pages.DataBinding
{
    public class DataBindingDemo_Base : ComponentBase
    {
        protected string Name { get; set; } = "Tom";
        protected string Gender { get; set; } = "Male";

        public string Color { get; set; } = "background-color:white";
    }
}
