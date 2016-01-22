namespace TVMovieSample
{
    using System.Threading.Tasks;

    using Windows.ApplicationModel.Activation;
    using Windows.UI.Xaml;

    using Template10.Services.NavigationService;

    using TVMovieSample.Views;

    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
            SplashFactory = e => new Splash(e);

            RequestedTheme = ApplicationTheme.Light;
            ShowShellBackButton = true;
        }

        // runs even if restored from state
        public override async Task OnInitializeAsync(IActivatedEventArgs args)
        {
            // setup hamburger shell
            var nav = NavigationServiceFactory(BackButton.Attach, ExistingContent.Include) as NavigationService;
            Window.Current.Content = new Views.Shell(nav);
            await Task.Yield();
        }

        // runs only when not restored from state
        public override async Task OnStartAsync(StartKind startKind, IActivatedEventArgs args)
        {
            // perform long-running load
            await Task.Delay(0);

            // navigate to first page
            NavigationService.Navigate(typeof(MainPage));
        }
    }
}