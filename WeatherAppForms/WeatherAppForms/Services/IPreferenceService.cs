using System;
using System.Collections.Generic;
using System.Text;
using WeatherAppForms.Enums;

namespace WeatherAppForms.Services
{
    public interface IPreferenceService
    {
        void SaveValue(PreferenceType key, string value);
        string GetValue(PreferenceType key);
    }
}
