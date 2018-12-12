using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherAppForms.ViewModels;
using Xamarin.Forms;

namespace WeatherAppForms
{
    public partial class MainPage : ContentPage
    {
        protected MainWeatherViewModel _viewModel => BindingContext as MainWeatherViewModel;
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = _viewModel;
        }


    }
}
