using InRabbit.App.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InRabbit.App
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();

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
