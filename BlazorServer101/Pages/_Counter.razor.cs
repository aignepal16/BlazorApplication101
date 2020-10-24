using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer101.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;
        string fontName;
        //'Segoe UI'

        private void IncrementCount()
        {
            currentCount++;
        }

        void ChangeFont()
        {
            if (fontName is null || fontName.Equals("Segoe UI"))
                fontName = "fantasy";
            else
                fontName = "Segoe UI";
        }
    }
}
