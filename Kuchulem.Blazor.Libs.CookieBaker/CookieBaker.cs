using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web;

namespace Kuchulem.Blazor.Libs.Cookies
{
    public class CookieBaker
    {
        private readonly IJSRuntime jSRuntime;
        private Dictionary<string, string> storedCookies;

        public CookieBaker(IJSRuntime jSRuntime)
        {
            this.jSRuntime = jSRuntime;
        }

        private async Task RefreshStoredCookies()
        {
            var result = new Dictionary<string, string>();
            var data = await jSRuntime.InvokeAsync<string>("k6m.cookieBaker.get").ConfigureAwait(false);

            var cookies = data.Split(';');

            foreach (var cookie in cookies)
            {
                var keyValue = cookie.Split('=');

                if (keyValue.Length < 2)
                    continue;

                var key = keyValue[0].Trim();
                var value = keyValue[1].Trim();

                result.Add(HttpUtility.UrlDecode(key), HttpUtility.UrlDecode(value));
            }

            storedCookies = result;
        }

        public async Task<string> GetAsync(string key, bool forceRefresh = false)
        {
            if(forceRefresh || storedCookies is null)
                await RefreshStoredCookies().ConfigureAwait(false);

            if (storedCookies.TryGetValue(key, out string data))
                return data;
            else if(!forceRefresh)
                return await GetAsync(key, true).ConfigureAwait(false);

            return null;
        }

        public async Task SetAsync(string key, string value, DateTime? expirationDate, string path = "/")
        {
            var line = $"{HttpUtility.UrlEncode(key)}={HttpUtility.UrlEncode(value)};";

            if (expirationDate != null)
            {
                var strDate = expirationDate?.ToString("O", CultureInfo.InvariantCulture);
                line += $" Expires={strDate};";
            }

            if (!string.IsNullOrEmpty(path))
                line += $" path={path};";

            line += $" SameSite=Strict";

            await jSRuntime.InvokeVoidAsync($"k6m.cookieBaker.set", line).ConfigureAwait(false);

            await RefreshStoredCookies().ConfigureAwait(false);
        }

        public Task UnsetAsync(string key)
        {
            return SetAsync(key, string.Empty, DateTime.MinValue);
        }
    }
}
