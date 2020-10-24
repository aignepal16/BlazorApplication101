using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServer101.Pages
{
    public class CounterBase :ComponentBase
    {
        protected int currentCount = 0;
        protected string fontName;
        //'Segoe UI'

        protected void IncrementCount()
        {
            currentCount++;
        }

        protected void ChangeFont()
        {
            if (fontName is null || fontName.Equals("Segoe UI"))
                fontName = "fantasy";
            else
                fontName = "Segoe UI";
        }
    }
}
