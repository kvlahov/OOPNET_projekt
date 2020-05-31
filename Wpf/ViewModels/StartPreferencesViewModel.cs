using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Utilities.POCO;

namespace Wpf.ViewModels
{
    public class StartPreferencesViewModel : ViewModelBase
    {
        private Leagues _leagues = Leagues.MenLeague;
        public Leagues League
        {
            get { return _leagues; }
            set { SetProperty(ref _leagues, value); }
        }

        private Languages _language = Languages.English;
        public Languages Language
        {
            get { return _language; }
            set { 
                SetProperty(ref _language, value);
                SetLanguage(value);
            }
        }

        private bool _isFullscreen = true;
        public bool IsFullscreen
        {
            get { return _isFullscreen; }
            set { SetProperty(ref _isFullscreen, value); }
        }

        private string _resolutionString;
        public string ResolutionString
        {
            get { return _resolutionString; }
            set
            {
                SetProperty(ref _resolutionString, value);
                Resolution = GetSizeFromString(value);
            }
        }

        private Size _resolution;
        public Size Resolution
        {
            get { return _resolution; }
            set
            {
                SetProperty(ref _resolution, value);
            }
        }

        public IList<string> ResolutionsDdl { get; private set; }

        public StartPreferencesViewModel()
        {
            ResolutionsDdl = new List<string>
            {
                "800x600",
                "1280x720",
                "1440x900",
                "1600x900"
            };
        }

        public StartPreferencesViewModel(StartPreferences preferences) : this()
        {
            League = (Leagues)preferences.LeagueId;
            Language = (Languages)preferences.LanguageId;
            if(preferences.Resolution == ResolutionEnum.Fullscreen.ToString())
            {
                IsFullscreen = true;
                ResolutionString = String.Empty;
            }
            else
            {
                IsFullscreen = false;
                ResolutionString = preferences.Resolution;
            }
        }

        private Size GetSizeFromString(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return new Size(0, 0);
            }
            var splitted = value.ToLower().Split('x').Select(s => double.Parse(s)).ToArray();
            return new Size(splitted[0], splitted[1]);
        }

        private void SetLanguage(Languages value)
        {
            var culture = value == Languages.Croatian ? "hr-HR" : "en";

            Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(culture);
        }
    }
}
