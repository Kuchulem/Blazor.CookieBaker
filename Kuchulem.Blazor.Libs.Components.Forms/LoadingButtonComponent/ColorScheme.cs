using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.Blazor.Libs.Components.Forms.LoadingButtonComponent
{
    public class ColorScheme
    {
        /// <summary>
        /// Color for the button's text
        /// </summary>
        public string ButtonText { get; set; }

        /// <summary>
        /// The coor of the button's borders when in <see cref="WorkingState.None"/> state
        /// </summary>
        public string ButtonBorders { get; set; }

        /// <summary>
        /// The color of the icon of the button when in <see cref="WorkingState.Success" state/>
        /// </summary>
        public string SuccessIcon { get; set; }

        /// <summary>
        /// The color of the icon of the button when in <see cref="WorkingState.Failure" state/>
        /// </summary>
        public string FailureIcon { get; set; }

        /// <summary>
        /// The color of the icon of the button when in <see cref="WorkingState.Working" state/>
        /// </summary>
        public string WorkingIcon { get; set; }

        /// <summary>
        /// The color of the button's borders when in <see cref="WorkingState.Success" state/>
        /// </summary>
        public string SuccessBorders { get; set; }

        /// <summary>
        /// The color of the button's borders when in <see cref="WorkingState.Failure" state/>
        /// </summary>
        public string FailureBorders { get; set; }

        /// <summary>
        /// The color of the button's borders when in <see cref="WorkingState.Working" state/>
        /// </summary>
        public string WorkingBorders { get; set; }

        /// <summary>
        /// Provides a default color scheme. Usefull for testing and having a quick result.<br/>
        /// It provides black borders and black text, with green success icon, blue working icon
        /// and red failure icon
        /// </summary>
        public static ColorScheme Default => new()
        {
            ButtonBorders = "rgb(0,0,0)",
            ButtonText = "rgb(0,0,0)",
            FailureIcon = "rgb(255,33,40)",
            SuccessIcon = "rgb(33,140,40)",
            WorkingIcon = "rgb(33,40,255)"
        };

        /// <summary>
        /// Provides a alternative color scheme. Usefull for testing and having a quick result.<br/>
        /// It provides white borders and white text, with green success icon, blue working icon
        /// and red failure icon
        /// </summary>
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
