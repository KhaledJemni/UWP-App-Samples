namespace TVMovieSample.ViewModels
{
    using System;
    using System.Collections.Generic;

    using Windows.UI.ViewManagement;
    using Windows.UI.Xaml.Navigation;

    using Template10.Services.NavigationService;

    using TVMovieSample.Mvvm;

    public class HelpPageViewModel : ViewModelBase
    {
        public override void OnNavigatedTo(object parameter, NavigationMode mode, IDictionary<string, object> state)
        {
            ApplicationView view = ApplicationView.GetForCurrentView();
            view.TryEnterFullScreenMode();
        }

        public override void OnNavigatingFrom(NavigatingEventArgs args)
        {
            try
            {
                ApplicationView view = ApplicationView.GetForCurrentView();
                view.ExitFullScreenMode();
            }
            catch (Exception)
            {
            }
        }
    }
}
