using Blogy.WebUI.Areas.Writer.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Blogy.WebUI.Areas.Writer.ViewComponents.DasboardComponents
{
    public class _WeatherViewComponentPartial:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://api.openweathermap.org/data/2.5/weather?q=k%C4%B1r%C4%B1kkale&appid=7"),
                Headers =
    {
        { "X-RapidAPI-Key", "d1128cd1b69582e97b9ca468b5e7ef05" },
        { "X-RapidAPI-Host", "api.openweathermap.org" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel>(body);
                return View(values);
            }
        }
    }
}
//https://api.openweathermap.org/data/2.5/weather?q=k%C4%B1r%C4%B1kkale&appid=d1128cd1b69582e97b9ca468b5e7ef05