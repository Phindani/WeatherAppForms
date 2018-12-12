using MvvmCross.ViewModels;
using WeatherAppForms.Services;
using System.Threading.Tasks;
using MvvmCross.Navigation;
using WeatherAppForms.Enums;
using WeatherAppForms.Platform.Services;
using System.ComponentModel;
using Xamarin.Forms;
using MvvmCross.Commands;

namespace WeatherAppForms.ViewModels
{
    public class MainWeatherViewModel : MvxViewModel
    {
        private readonly IWeatherService _weatherService;
        private readonly IMvxNavigationService _navigationService;


        public MainWeatherViewModel(
            IWeatherService weatherService, 
            IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
            _weatherService = weatherService;

            MyCommand = new MvxAsyncCommand(DoMyCommand, MyCommandCanExecute);
        }
        public override void Start()
        {
            base.Start();
            //City = _preferenceService.GetValue(PreferenceType.CityName);
        }

        private string _cityName;
        public string City
        {
            get { return _cityName; }
            set
            {
                SetProperty(ref _cityName, value);
                MyCommand.RaiseCanExecuteChanged();
            }
        }

        public bool MyCommandCanExecute()
        {
            return !string.IsNullOrEmpty(City);
        }

        public MvxAsyncCommand MyCommand { get; }
        private async Task DoMyCommand()
        {
            //_progressService.Show("Featching your weather");
            try
            {
                var result = await _weatherService.GetWeather(City);
              
                    //_systemCache.WeatherDetails = result;
                   // _preferenceService.SaveValue(PreferenceType.CityName, City);
                    await _navigationService.Navigate<WeatherDetailsViewModel>();
                
              
            }
            finally {
                //_progressService.Hide();
            }

        }
    }
}

