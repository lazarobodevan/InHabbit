using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.OS;
using InHabbit.App.XAppConstants;
using InHabbit.App.Services;
using System;

namespace InHabbit.App.Droid
{
    [Activity(Label = "CustomUrlSchemeInterceptorActivity", NoHistory = true, LaunchMode = LaunchMode.SingleTop)]
    [IntentFilter(
        new[] { Intent.ActionView },
        Categories = new[] { Intent.CategoryDefault, Intent.CategoryBrowsable },
        DataSchemes = new[] { XAppConstants.XAppConstants.Data},
        DataPath = "/oauth2redirect")]
    public class CustomURLSchemeInterceptorActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Converts Android.Net.URL to URI
            var uri = new Uri(Intent.Data.ToString());

            //Google page redirect
            AuthenticationState.Authenticator.OnPageLoading(uri);
            var intent = new Intent(this, typeof(MainActivity));
            intent.SetFlags(ActivityFlags.ClearTop | ActivityFlags.SingleTop);

            StartActivity(intent);

            this.Finish();
            return;
            
        }
    }
}