using Android.App;
using Android.Content.PM;
using Android.OS;

namespace InHabbit.App.Droid
{
    [Activity(Label = "App - In-Habit", Icon = "@drawable/ic_launcher", Theme = "@style/MainTheme.Splash", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState); // add this line to your code, it may also be called: bundle
            StartActivity(typeof(MainActivity));
            Finish();
        }

        /*
        protected override void OnResume()
        {
            base.OnResume();
            Xamarin.Essentials.Platform.OnResume();
        }
        */

    }
}