
namespace WeatherAppForms.Services
{
    public interface ISystemCacheService
    {
        WeatherInfo.RootObject WeatherDetails { get; set; }
    }
}
