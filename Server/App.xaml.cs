using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Server.Views;

namespace Server
{
    public partial class App : Application
    {
        public static NavigationPage _NavigationPage;
        public App()
        {
            InitializeComponent();
            _NavigationPage = new NavigationPage(new VerifyPin());
            MainPage = _NavigationPage;
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
