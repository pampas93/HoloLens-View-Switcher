using Windows.UI.Xaml;

namespace ViewSwitcher
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    sealed partial class App : Application
    {
        public MainPage MainPageRef;
        public int MainViewId;
        public int FlatViewId;
    }
}