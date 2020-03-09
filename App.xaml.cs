using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using inClassAppPractice1.Services;
using inClassAppPractice1.Views;

namespace inClassAppPractice1
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
