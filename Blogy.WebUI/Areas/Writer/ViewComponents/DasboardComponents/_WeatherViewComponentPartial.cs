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
                RequestUri = new Uri("https://weatherapi-com.p.rapidapi.com/forecast.json?q=%C4%B0stanbul&days=7"),
                Headers =
    {
        { "X-RapidAPI-Key", "01e2c3d585msh1afb95d2ac454c2p1bb84djsnc18b9688678f" },
        { "X-RapidAPI-Host", "weatherapi-com.p.rapidapi.com" },
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