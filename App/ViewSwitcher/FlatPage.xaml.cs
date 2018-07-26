using System;
using Windows.ApplicationModel.Store;
using Windows.Services.Store;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;

namespace ViewSwitcher
{
    public sealed partial class FlatPage : Page
    {
        private App app = Application.Current as App;
        private StoreContext storeContext = StoreContext.GetDefault();

        public FlatPage()
        {
            this.InitializeComponent();
           
        }

        /// <summary>
        /// This method passes data from the flat XAML page to the Unity page. It also navigates to the Unity exclusive main view.
        /// </summary>
        private async void WeatherBtn_Click(object sender, RoutedEventArgs e)
        {
            if (app.MainPageRef != null)
            {
                Button button = sender as Button;

                if (button != null)
                {
                    TextBlock tb = button.Content as TextBlock;
                    
                    if (tb != null)
                    {
                        app.MainPageRef.LoadWeather();
                    }
                }
            }

            if (app.MainViewId != 0)
            {
                await ApplicationViewSwitcher.SwitchAsync(app.MainViewId);
            }
        }

        private async void PartlyCloudy_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var licenseInformation = CurrentAppSimulator.LicenseInformation.ProductLicenses;
                var x = licenseInformation.Keys;
                ProductLicense product;
                //Fetching the two product ID's (By default, it's "1" and "2", and trying to call the purchase on the first one.
                foreach (string y in x)
                {
                    product = licenseInformation[y];
                    await CurrentAppSimulator.RequestProductPurchaseAsync(product.ProductId);
                    break;
                }
                
            }
            catch (Exception ex)
            {
                UnityEngine.Debug.Log(String.Format("Unable to purchase the feature.Exception: {0}", ex.Message));
            }

        }

        //Not using now
        private async void PurchaseAddOn(System.Object sender, RoutedEventArgs e)
        {
            try
            {
                var licenseInformation = CurrentAppSimulator.LicenseInformation.ProductLicenses;
                var x = licenseInformation.Keys;
                ProductLicense product;

                //Fetching the two product ID's (By default, it's "1" and "2", and trying to call the purchase on the first one.
                foreach (string y in x)
                {
                    product = licenseInformation[y];
                    await CurrentAppSimulator.RequestProductPurchaseAsync(product.ProductId);
                    break;
                }

            }
            catch (Exception ex)
            {
                UnityEngine.Debug.Log(String.Format("Unable to purchase the feature.Exception: {0}", ex.Message));
            }

        }
    }
}