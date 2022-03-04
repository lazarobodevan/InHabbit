using InHabbit.App.View;
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
         
            MainPage = new Register();

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
