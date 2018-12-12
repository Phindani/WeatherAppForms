using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WeatherAppForms.Services
{
    public interface IWeatherService
    {
       Task<WeatherInfo.RootObject> GetWeather(string cityName);
    }
}