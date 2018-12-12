using WeatherAppForms.Services;

namespace WeatherAppForms.Services
{
    public class SystemCacheService: ISystemCacheService
    {
        public WeatherInfo.RootObject WeatherDetails { get; set; }
    }
}