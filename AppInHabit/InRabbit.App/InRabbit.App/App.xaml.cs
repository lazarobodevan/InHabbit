using InHabbit.App.View;
using InHabbit.App.Views;
using System;
using Xamarin.Forms;

namespace InHabbit.App
{
    public partial class App : Application
    {
        [Obsolete]
        public App()
        {
            InitializeComponent();
            //if (Application.Current.Properties.ContainsKey("Id"))
            //    MainPage = new Home();
            //else
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
