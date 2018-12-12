using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherAppForms.Platform.Services
{
    public interface IProgressService
    {
        void Show(string text = null);
        void Hide();
    }
}
