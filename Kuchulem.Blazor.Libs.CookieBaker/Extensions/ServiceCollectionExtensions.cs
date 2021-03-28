using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kuchulem.Blazor.Libs.Cookies.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCookieBaker(this IServiceCollection services)
        {
            return services.AddTransient<CookieBaker>();
        }
    }
}
