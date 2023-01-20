using Plugin.Settings.Abstractions;
using Plugin.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinMobile.Helper
{
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get
            {
                return CrossSettings.Current;
            }
        }
        public static string token
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>("token", "");
            }

            set
            {
                AppSettings.AddOrUpdateValue<string>("token", value);
            }
        }

    }
}
