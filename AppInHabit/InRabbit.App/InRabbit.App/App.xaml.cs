using InHabbit.App.Services;
using InHabbit.App.Views;
using System;
using Xamarin.Auth;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InHabbit.App
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            if (AuthenticationState.Authenticator.IsAuthenticated())
                MainPage = new Home();
            else
                MainPage = new Login();

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
