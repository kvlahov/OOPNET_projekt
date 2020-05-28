using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Utilities.POCO;

namespace Wpf.ViewModels
{
    public class StartPreferencesViewModel : ViewModelBase
    {
        private Leagues _leagues;
        public Leagues League
        {
            get { return _leagues; }
            set { SetProperty(ref _leagues, value); }
        }

        private Languages _language;
        public Languages Language
        {
            get { return _language; }
            set { SetProperty(ref _language, value); }
        }

        private bool _isFullscreen;
        public bool IsFullscreen
        {
            get { return _isFullscreen; }
            set { SetProperty(ref _isFullscreen, value); }
        }

        private Size _resolution;
        public Size Resolution
        {
            get { return _resolution; }
            set { SetProperty(ref _resolution, value); }
        }

    }
}
