using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMobile.Booking;
using XamarinMobile.Services;
using XamarinMobile.Views;

[assembly: ExportFont("Knewave-Regular.ttf", Alias = "L-Reg")]
[assembly: ExportFont("Lobster-Regular.ttf", Alias = "L-Reg2")]
[assembly: ExportFont("DanceToday-JRdzM.otf", Alias = "L-Reg3")]
[assembly: ExportFont("CarterOne-Regular.ttf", Alias = "L-Reg4")]
[assembly: ExportFont("Oswald-VariableFont_wght.ttf", Alias = "L-Reg5")]
namespace XamarinMobile
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new LoginPage());
        }
        protected override void OnStart()
        {

        }
        protected override void OnSleep()
        {

        }
        protected override void OnResume()
        {

        }
    }
}
