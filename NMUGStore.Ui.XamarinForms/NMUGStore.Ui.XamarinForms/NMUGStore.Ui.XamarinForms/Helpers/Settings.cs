// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using Xamarin.Forms;

namespace NMUGStore.Ui.XamarinForms.Helpers
{
    /// <summary>
    /// This is the Settings static class that can be used in your Core solution or in any
    /// of your client applications. All settings are laid out the same exact way with getters
    /// and setters. 
    /// </summary>
    public static class Settings
    {
        private static ISettings AppSettings
        {
            get { return CrossSettings.Current; }
        }

        #region Setting Constants

        private const string SettingsKey = "settings_key";
        private static readonly string SettingsDefault = string.Empty;

        private const string developmentMachineIpAddressKey = "development_machine_string_key";
        private static readonly string developmentMachineIpAddressDefault = "192.168.10.167";


        public static string DevelopmentMachineIpAddress
        {
            get { return AppSettings.GetValueOrDefault(developmentMachineIpAddressKey, developmentMachineIpAddressDefault); }
            set { AppSettings.AddOrUpdateValue(developmentMachineIpAddressKey, value); }
        }

        #endregion

        public static string WCFHostUrl
        {
            get
            {
#if DEBUG
                switch (Device.RuntimePlatform)
                {
                    case Device.Android:
                        return String.Format("http://{0}/NMUG.WCFHost/MeetingService.svc", DevelopmentMachineIpAddress);
                    case Device.UWP:
                        return String.Format("http://{0}/NMUG.WCFHost/MeetingService.svc", "localhost");
                    default:
                        throw new Exception("Invalid Device");
                }
#endif
            }
        }
    }
}