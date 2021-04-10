using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.Blazor.Libs.Components.Forms.LoadingButtonComponent
{
    public class ColorScheme
    {
        public string ButtonText { get; set; }

        public string ButtonBorders { get; set; }

        public string SuccessIcon { get; set; }
        
        public string FailureIcon { get; set; }

        public string WorkingIcon { get; set; }

        public string SuccessBorders { get; set; }

        public string FailureBorders { get; set; }

        public string WorkingBorders { get; set; }

        public static ColorScheme Default => new()
        {
            ButtonBorders = "rgb(0,0,0)",
            ButtonText = "rgb(0,0,0)",
            FailureIcon = "rgb(255,33,40)",
            SuccessIcon = "rgb(33,140,40)",
            WorkingIcon = "rgb(33,40,255)"
        };

        public static ColorScheme Alt => new()
        {
            ButtonBorders = "rgb(255,255,255)",
            ButtonText = "rgb(255,255,255)",
            FailureIcon = "rgb(255,33,40)",
            SuccessIcon = "rgb(33,140,40)",
            WorkingIcon = "rgb(33,40,255)"
        };
    }
}
