using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kuchulem.Blazor.Libs.Demo.Data
{
    public class EditCookieModel
    {
        public string Key { get; set; }

        public string Data { get; set; }

        public DateTime ExpirationDate { get; set; } = DateTime.Now;

        public bool NoExpirationDate { get; set; }
    }
}
