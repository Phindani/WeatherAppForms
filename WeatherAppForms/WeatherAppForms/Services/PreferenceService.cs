﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;
using WeatherAppForms.Enums;

namespace WeatherAppForms.Services
{
    public class PreferenceService:IPreferenceService
    {
        public string GetValue(PreferenceType key)
        {
            return Preferences.Get(key.ToString(), string.Empty);
        }

        public void SaveValue(PreferenceType preferenceType, string value)
        {
            Preferences.Set(preferenceType.ToString(), value);
        }
    }
}
